using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Rol;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Rol
{
    public class RolRepository : IRolRepository
    {
        private readonly IDataContextProyectoFinal _context;
        private readonly ILogService _logService;

        public RolRepository(IDataContextProyectoFinal context)
        {
            _context = context;
        }

        public  async Task<ResponseDTO> CreateRolRepository(string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.CreateRol";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description", Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateRol: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }



        public async Task<ResponseDTO> GetRolByIdRepository(int RolId)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.GetRolById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idRol", RolId);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToObjHelper.MapToObj<RolDTO>(reader);
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = "Successful Petition";
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP GetRolById: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

 
        public async Task<ResponseDTO> GetRolesRepository()
        {

            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.GetRol";
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                response.Data = MapToListHelper.MapToList<RolDTO>(reader);
                await reader.ReadAsync();
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP GetRol: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateRolRepository(RolDTO rol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _context.CreateCommand();
                command.CommandText = "dbo.UpdateRol";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("idRol",rol.IdRol);
                command.Parameters.AddWithValue("Description", rol.Description);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                await reader.ReadAsync();
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP GetRol: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
