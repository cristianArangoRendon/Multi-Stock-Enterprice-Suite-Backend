using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.Interfaces.IBLL.Products;
using ProyectoFinal.ErrorResponse.Doc.ProductsDoc;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsBLL _productsBLL;

        public ProductsController(IProductsBLL productsBLL)
        {
            _productsBLL = productsBLL;
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="products">
        /// - `Description`: The description of the product.
        /// - `stock`: The stock quantity of the product.
        /// - `idCategory`: The identifier of the category to which the product belongs.
        /// - `idBrand`: The identifier of the brand associated with the product.
        /// - `idProvider`: The identifier of the provider associated with the product.
        /// - `uniqueCode`: The unique code assigned to the product.
        /// - `idUser`: The identifier of the user creating the product.
        /// </param>
        /// <remarks>
        /// This endpoint creates a new product with the provided data. 
        /// It requires authorization to determine the user associated with the creation operation.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>

        [HttpPost("/Product")]
        [SwaggerResponseExample(200, (typeof(GetProductsDoc)))]
        public async Task<IActionResult> CreateProduct(CreateProductDTO products)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            products.idUser = idUser;

            var response = await _productsBLL.CreateProductBLL(products);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="idProducts">
        ///  - `idProducts`:The ID of the product to delete.</param>
        /// <remarks>This endpoint deletes a product based on the provided product ID.</remarks>
        [HttpDelete("/Product")]
        [SwaggerResponseExample(200, (typeof(DeleteProductDoc)))]
        public async Task<IActionResult> DeleteProducts(int idProducts)
        {
            var response = await _productsBLL.DeleteProductBLL(idProducts);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="idProduct">
        ///  - `idProducts`:The ID of the product to retrieve.</param>
        /// <remarks>This endpoint retrieves a product based on the provided product ID.</remarks>
        [HttpGet("/Product/By/Id")]
        [SwaggerResponseExample(200, (typeof(GetProductByIdDoc)))]
        public async Task<IActionResult> GetProductsById(int idProduct)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());

            var response = await _productsBLL.GetProductsByIdBLL(idProduct, idUser);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <remarks>This endpoint retrieves all products available in the system.</remarks>
        [HttpGet("/Products")]
        [SwaggerResponseExample(200, (typeof(GetProductsDoc)))]
        public async Task<IActionResult> GetProducts()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());

            var response = await _productsBLL.GetProductsBLL(idUser);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Updates product information.
        /// </summary>
        /// <param name="product">
        /// - `idProduct`: The identifier of the product.
        /// - `description`: The description of the product.
        /// - `minimunQuantity`: The minimum quantity of the product.
        /// - `stock`: The stock quantity of the product.
        /// - `idCategory`: The identifier of the category to which the product belongs.
        /// - `idBrand`: The identifier of the brand associated with the product.
        /// - `idProvider`: The identifier of the provider associated with the product.
        /// - `uniqueCode`: The unique code assigned to the product.
        /// - `idUser`: The identifier of the user updating the product.
        /// </param>
        /// <remarks>
        /// This endpoint updates product information based on the provided data.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the update operation.</returns>

        [HttpPut("/Products")]
        [SwaggerResponseExample(200, (typeof(UpdateProducDoc)))]
        public async Task<IActionResult> UpdateProducts(ProductsDTO product)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            product.idUser = idUser;

            var response = await _productsBLL.UpdateProductBLL(product);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
