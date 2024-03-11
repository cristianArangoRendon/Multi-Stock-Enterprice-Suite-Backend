using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.Repository.Products
{
    public class ProductsRepository : IProductsRepository
    {

        private readonly IExecuteStoredProcedureServiceService _ExecuteStoredProcedureService;

        public ProductsRepository( ILogService logService, IExecuteStoredProcedureServiceService executeStoredProcedureServiceService) => _ExecuteStoredProcedureService = executeStoredProcedureServiceService;
        

        public async Task<ResponseDTO> CreateProducsRepository(CreateProductDTO products)
        {
            object obj = products.ToObject<CreateProductDTO>();
            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.CreateProducts", obj);
        }

        public async Task<ResponseDTO> DeleteProductsRepository(int IdProducts)
        {

            var parameters = new
            {
                IdProduct = IdProducts
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.DeleteProduct", parameters);
        }

        public async Task<ResponseDTO> GetProductsByIdRepository(int IdProducts, int IdUser)
        {

            var parameters = new
            {
                IdProduct = IdProducts,
                IdUser = IdUser
            };

            return await _ExecuteStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetProductsById", parameters, MapToObjHelper.MapToObj<ProductsDTO>);
        }


        public async Task<ResponseDTO> GetProductsRepository(int idUser)
        {
            var parameters = new
            {
                idUser = idUser
            };
           return await _ExecuteStoredProcedureService.ExecuteDataStoredProcedure("dbo.GetProducts",parameters, MapToListHelper.MapToList<ProductsDTO>);
        }
        

        public async Task<ResponseDTO> UpdateProductRepository(ProductsDTO products)
        {
            object obj = products.ToObject<ProductsDTO>();
            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateProduct", obj);
        }
    }
}
