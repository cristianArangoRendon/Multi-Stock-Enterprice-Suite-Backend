using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Products;
using ProyectoFinal.Infraestructure.DataContext;
using ProyectoFinal.Infraestructure.Services.LogService;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Products
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IDataContextProyectoFinal _DataContext;
        private readonly ILogService _LogService;

        public ProductsRepository(IDataContextProyectoFinal dataContext, ILogService logService)
        {
            _DataContext = dataContext;
            _LogService = logService;
        }

        public async Task<ResponseDTO> CreateProducsRepository(ProductsDTO products)
        {

            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.CreateProducts";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description", products.Description);
                command.Parameters.AddWithValue("@minimunQuantity",products.minimunQuantity );
                command.Parameters.AddWithValue("@stock", products.stock);
                command.Parameters.AddWithValue("@idCategory", products.idCategory);
                command.Parameters.AddWithValue("@idBrand", products.idBrand);
                command.Parameters.AddWithValue("@idProvider", products.idProvider);
                command.Parameters.AddWithValue("@UniqueCode", products.uniqueCode);
               
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateProducts: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> DeleteProductsRepository(int IdProducts)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.DeleteProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProduct", IdProducts);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP DeleteProduct: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetProductsByIdRepository(int IdProducts)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.GetProductsById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProduct", IdProducts);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToObjHelper.MapToObj<ProductsDTO>(reader);
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetBrandById: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }


        public async Task<ResponseDTO> GetProductsRepository()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.GetProducts";
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToListHelper.MapToList<ProductsDTO>(reader);
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetProducts: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateProductRepository(ProductsDTO products)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.UpdateProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idProduct", products.idProduct);
                command.Parameters.AddWithValue("@Description", products.Description);
                command.Parameters.AddWithValue("@minimunQuantity", products.minimunQuantity);
                command.Parameters.AddWithValue("@stock", products.stock);
                command.Parameters.AddWithValue("@idCategory", products.idCategory);
                command.Parameters.AddWithValue("@idBrand", products.idBrand);
                command.Parameters.AddWithValue("@idProvider", products.idProvider);
                command.Parameters.AddWithValue("@uniqueCode", products.uniqueCode);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP UpdateProduct: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
