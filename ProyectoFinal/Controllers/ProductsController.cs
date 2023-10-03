
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
        





        [HttpPost("Create/Product")]
        public async Task<ResponseDTO> CreateProduct(ProductsDTO products) => await _productsBLL.CreateProductBLL(products);
        


        [HttpDelete("Delete/Product")]
        public async Task<ResponseDTO> DeleteProducts(int idProducts) => await _productsBLL.DeleteProductBLL(idProducts);
        

        [HttpGet("Get/Product/By/Id")]
        public async Task<ResponseDTO> GetProductsById(int idProducts)  => await _productsBLL.GetProductsByIdBLL(idProducts);
        

        [HttpGet("Get/Products")]
        public async Task<ResponseDTO> GetProducts() => await _productsBLL.GetProductsBLL();
        

        [HttpPut("Update/Products")]
        public async Task<ResponseDTO> UpdateProducts(ProductsDTO product) => await _productsBLL.UpdateProductBLL(product);
        


    }

}
