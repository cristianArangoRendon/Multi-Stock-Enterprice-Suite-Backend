using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.Repository.Products
{
    public class ProductsRepository : IProductsRepository
    {

        private readonly IExecuteStoredProcedureServiceService _ExecuteStoredProcedureService;

        public ProductsRepository(IDataContextProyectoFinal dataContext, ILogService logService, IExecuteStoredProcedureServiceService executeStoredProcedureServiceService) => _ExecuteStoredProcedureService = executeStoredProcedureServiceService;
        

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

        public async Task<ResponseDTO> GetProductsByIdRepository(int IdProducts)
        {

            var parameters = new
            {
                IdProduct = IdProducts
            };

            return await _ExecuteStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetProductsById", parameters, MapToObjHelper.MapToObj<ProductsDTO>);
        }


        public async Task<ResponseDTO> GetProductsRepository() =>  await _ExecuteStoredProcedureService.ExecuteData("dbo.GetProducts", MapToListHelper.MapToList<ProductsDTO>);
        

        public async Task<ResponseDTO> UpdateProductRepository(ProductsDTO products)
        {
            object obj = products.ToObject<ProductsDTO>();
            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateProduct", obj);
        }
    }
}
