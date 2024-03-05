using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Products
{
    public interface IProductsBLL
    {
        Task<ResponseDTO> CreateProductBLL(CreateProductDTO products);
        Task<ResponseDTO> UpdateProductBLL(ProductsDTO products);
        Task<ResponseDTO> GetProductsBLL();
        Task<ResponseDTO> GetProductsByIdBLL(int IdProducts);
        Task<ResponseDTO> DeleteProductBLL(int IdProducts);
    }
}
