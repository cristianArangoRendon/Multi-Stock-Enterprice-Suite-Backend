using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Products
{
    public interface IProductsRepository
    {
        Task<ResponseDTO> CreateProducsRepository(CreateProductDTO products);
        Task<ResponseDTO> UpdateProductRepository(ProductsDTO products);
        Task<ResponseDTO> GetProductsRepository();
        Task<ResponseDTO> GetProductsByIdRepository(int IdProducts);
        Task<ResponseDTO> DeleteProductsRepository(int Idproducts);
    }
}
