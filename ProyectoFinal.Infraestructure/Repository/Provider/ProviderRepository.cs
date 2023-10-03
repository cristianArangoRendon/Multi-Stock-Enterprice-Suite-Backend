using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Products;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;
using ProyectoFinal.Infraestructure.DataContext;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Provider
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly IDataContextProyectoFinal _DataContext;
        private readonly ILogService _LogService;

        public ProviderRepository(IDataContextProyectoFinal dataContext, ILogService logService)
        {
            _DataContext = dataContext;
            _LogService = logService;
        }

        public async Task<ResponseDTO> CreateProviderRepository(string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.CreateProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description", Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return  response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateUsers: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public  async Task<ResponseDTO> DeleteProviderRepository(int idProvider)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.DeleteProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idProvider", idProvider);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP DeleteProvider: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetProviderByIdRepository(int idProvider)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.GetProviderById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idProvider", idProvider);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToObjHelper.MapToObj<ProviderDTO>(reader);
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = "Successful Petition";
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP GetProviderById: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public  async Task<ResponseDTO> GetProviderRepository()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.GetProvider";
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToListHelper.MapToList<ProviderDTO>(reader);
                await reader.ReadAsync();
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP GetProvider: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateProviderRepository(ProviderDTO providerDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _DataContext.CreateCommand();
                command.CommandText = "dbo.UpdateProvider";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idProvider",providerDTO.IdProvider);
                command.Parameters.AddWithValue("@Description",providerDTO.Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el SP UpdateProvider: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
