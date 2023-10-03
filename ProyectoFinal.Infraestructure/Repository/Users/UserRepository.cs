using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Users
{
    public class UserRepository : IUsersRepository
    {
        private readonly IDataContextProyectoFinal _dataContext;
        private readonly ILogService _logService;

        public UserRepository(IDataContextProyectoFinal dataContext, ILogService logService)
        {
            _dataContext = dataContext;
            _logService = logService;
        }

        public async Task<ResponseDTO> Auth(string email, string password)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.Auth";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message =reader.GetString(reader.GetOrdinal("ResultCode"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP Auth: " + ex.Message);
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ResponseDTO> CreateUsersRepository(UsersDTO userDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.CreateUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Names", userDTO.Names);
                command.Parameters.AddWithValue("@lastNames", userDTO.lastNames);
                command.Parameters.AddWithValue("@Email", userDTO.Email);
                command.Parameters.AddWithValue("@password", userDTO.password);
                command.Parameters.AddWithValue("@idRol", userDTO.idRol);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP CreateUsers: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> DeleteUserRepository(int id)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {

                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.DeleteUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", id);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));

                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP DeleteUsers: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<UsersDTO> GetUserByEmail(string user)
        {
            using SqlCommand command = _dataContext.CreateCommand();
            command.CommandText = "dbo.GetUserByEmail";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", user);
            using SqlDataReader reader = await command.ExecuteReaderAsync();
            UsersDTO userdto = MapToObjHelper.MapToObj<UsersDTO>(reader);
           
            return userdto;
        }


        public async Task<ResponseDTO> GetUserByIdRepository(int idUser)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;
            try
            {
                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.GetUserById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdUser", idUser);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                respuesta.Data = MapToObjHelper.MapToObj<UsersDTO>(reader);
                respuesta.IsSuccess = true;
                return respuesta;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetUserById: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }

        public async Task<ResponseDTO> GetUsersRepository(int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.GetUsers";
                command.Parameters.AddWithValue("@idRol", idRol);
                command.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                List<UsersDTO> Rol = MapToListHelper.MapToList<UsersDTO>(reader);
                response.IsSuccess = true;
                response.Message = "Successful Petition";
                response.Data = Rol;

                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP  GetUsers: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateUserRepository(UsersDTO userDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                using SqlCommand command = _dataContext.CreateCommand();
                command.CommandText = "dbo.UpdateUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idUser", userDTO.IdUser);
                command.Parameters.AddWithValue("@Names", userDTO.Names);
                command.Parameters.AddWithValue("@lastNames", userDTO.lastNames);
                command.Parameters.AddWithValue("@Email", userDTO.Email);
                command.Parameters.AddWithValue("@password", userDTO.password);
                command.Parameters.AddWithValue("@idRol", userDTO.idRol);
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();
                response.IsSuccess = true;
                response.Message = reader.GetString(reader.GetOrdinal("ResultMessage"));
                return response;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el SP UpdateUsers: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
