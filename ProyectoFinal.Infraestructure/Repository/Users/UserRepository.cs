using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.DataContext;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Infraestructure.Repository.Users
{
    public class UserRepository : IUsersRepository
    {
        private readonly IDataContextProyectoFinal _dataContext;
        private readonly ILogService _logService;
        private readonly IExecuteStoredProcedureServiceService _ExecuteStoredProcedureServiceService;

        public UserRepository(IDataContextProyectoFinal dataContext, ILogService logService, IExecuteStoredProcedureServiceService Service)
        {
            _dataContext = dataContext;
            _logService = logService;
            _ExecuteStoredProcedureServiceService = Service;
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

        public async Task<ResponseDTO> CreateUsersRepository(CreateUserDTO userDTO)
        {
            object obj = userDTO.ToObject<CreateUserDTO>();
            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("dbo.CreateUsers", obj);
        }

        public async Task<ResponseDTO> DeleteUserRepository(int id)
        {
            var parameters = new
            {
                UserId = id,
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("dbo.DeleteUsers", parameters);
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
            var parameters = new
            {
                IdUser = idUser,
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteSingleObjectStoredProcedure("dbo.GetUserById", parameters, MapToObjHelper.MapToObj<UsersDTO>);
        }

        public async Task<ResponseDTO> GetUsersRepository(int idRol)
        {
            var parameters = new
            {
                idRol = idRol,
            };

            return await _ExecuteStoredProcedureServiceService.ExecuteDataStoredProcedure("dbo.GetUsers", parameters, MapToListHelper.MapToList<UsersDTO>);
        }

        public async Task<ResponseDTO> UpdateUserRepository(UsersDTO userDTO)
        {
            object obj = userDTO.ToObject<UsersDTO>();
            return await _ExecuteStoredProcedureServiceService.ExecuteStoredProcedure("dbo.UpdateUsers", obj);
        }
    }
}
