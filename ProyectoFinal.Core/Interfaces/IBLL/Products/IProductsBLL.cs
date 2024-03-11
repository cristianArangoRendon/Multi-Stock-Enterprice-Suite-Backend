using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Products
{
    public interface IProductsBLL
    {
        Task<ResponseDTO> CreateProductBLL(CreateProductDTO products);
        Task<ResponseDTO> UpdateProductBLL(ProductsDTO products);
        Task<ResponseDTO> GetProductsBLL(int idUser);
        Task<ResponseDTO> GetProductsByIdBLL(int IdProducts, int idUser);
        Task<ResponseDTO> DeleteProductBLL(int IdProducts);
    }
}
