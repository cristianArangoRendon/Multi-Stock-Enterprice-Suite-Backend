using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDataContextProyectoFinal _DataContext;
        private readonly ILogService _logService;
        public CategoryRepository (IDataContextProyectoFinal dataContext)
        {
            _DataContext = dataContext;
        }

        public async Task<ResponseDTO> CreateCategoryRepository(string description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.CreateCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description",description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateCategory: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> DeleteCategoryRepository(int idCategory)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.DeleteCategory";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCategory", idCategory);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP DeleteCategory: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetCategoryByIdRepository(int idCategory)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "GetCategoryById";
                command.Parameters.AddWithValue("@IdCategory", idCategory);
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                categoryDTO azureAdDTO = MapToObjHelper.MapToObj<categoryDTO>(reader);
                response.IsSuccess = true;
                response.Message = "Successful Petition";
                response.Data = azureAdDTO;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP AzureAdId: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetCategoryRepository()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.GetCategory";
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                List<categoryDTO> category = MapToListHelper.MapToList<categoryDTO>(reader);
                response.IsSuccess = true;
                response.Message = "Successful Petition";
                response.Data = category;

                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetCategory: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
            public async Task<ResponseDTO> UpdateCategoryRepository(categoryDTO idCategory)
            {
                ResponseDTO response = new ResponseDTO();
                response.IsSuccess = false;
                try
                {
                    using SqlCommand command = _DataContext.CreateCommand();
                    command.CommandText = "dbo.UpdateCategory";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idCategory", idCategory.IdCategory);
                    command.Parameters.AddWithValue("Description", idCategory.Description);
                    using SqlDataReader reader = await command.ExecuteReaderAsync();
                    await reader.ReadAsync();
                    response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                    response.IsSuccess = true;
                    return response;
                }
                catch (Exception ex)
                {
                    _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP UpdateCategory: " + ex.Message);
                    response.Message += ex.ToString();
                    return response;
                }
            }
        }
    }

