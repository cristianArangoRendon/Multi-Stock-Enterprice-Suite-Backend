
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Products;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsBLL _productsBLL;
        public ProductsController(IProductsBLL productsBLL) => _productsBLL = productsBLL;

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="products">
        /// 
        /// - `Description`: The description of the product.
        /// - `minimunQuantity`: The minimum quantity of the product.
        /// - `stock`:  The current stock quantity of the product.
        /// - `idCategory`: The ID of the category to which the product belongs.
        /// - `idBrand`: The ID of the brand to which the product belongs.
        /// - `idProvider`: The ID of the provider supplying the product.
        /// - `uniqueCode`: The unique code assigned to the product.
        /// - `idCompany`: The ID of the company to which the product belongs.
        /// - `idWarehouse`: The ID of the warehouse where the product is located.
        /// </param>
        /// <remarks>This endpoint creates a new product with the provided data.</remarks>
        [HttpPost("/Product")]

        public async Task<ResponseDTO> CreateProduct(CreateProductDTO products)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            products.idUser = idUser;
            return  await _productsBLL.CreateProductBLL(products);
        }
    
        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="idProducts">- `idProducts`: The ID of the product to delete.</param>
        /// <remarks>This endpoint deletes a product based on the provided product ID.</remarks>
        [HttpDelete("/Product")]
        public async Task<ResponseDTO> DeleteProducts(int idProducts) => await _productsBLL.DeleteProductBLL(idProducts);

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="idProducts">- `idProducts`: The ID of the product to retrieve.</param>
        /// <remarks>This endpoint retrieves a product based on the provided product ID.</remarks>
        [HttpGet("/Product/By/Id")]
        public async Task<ResponseDTO> GetProductsById(int idProducts)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            return await _productsBLL.GetProductsByIdBLL(idProducts, idUser);
        }
            
           

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <remarks>This endpoint retrieves all products available in the system.</remarks>
        [HttpGet("/Products")]
        public async Task<ResponseDTO> GetProducts()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            return await _productsBLL.GetProductsBLL(idUser);
        } 
            

        /// <summary>
        /// Updates a product.
        /// </summary>
        /// <param name="product">- `product`: The data of the product to be updated.</param>
        /// <remarks>This endpoint updates a product with the provided product data.</remarks>
        [HttpPut("/Products")]
        public async Task<ResponseDTO> UpdateProducts(ProductsDTO product)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int idUser = int.Parse(user.Value.ToString());
            product.idUser = idUser;
            return await _productsBLL.UpdateProductBLL(product);
        }
            
          




    }

}
