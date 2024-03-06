using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ProyectoFinal.Core.DTOs.Common;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Users
{
    public class UsersBLL : IUserBLL
    {

        private readonly IUsersRepository _userRepository;
        private readonly ILogService _logService;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public UsersBLL(IUsersRepository Users, ILogService logService, IOptions<AppSettings> appSettings, IConfiguration configuration)
        {
            _userRepository = Users;
            _logService = logService;
            _configuration = configuration;
            _appSettings = appSettings.Value;
        }

        public async Task<ResponseDTO> Auth(string User, string password)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int hours = _configuration.GetValue<int>("Hors");
            string keyToken = _configuration["AppSettings:SecretToken"];
            try
            {
                password = Hash256Helper.GetSHA256Hash(password);
                response = await _userRepository.Auth(User, password);
                if (response.Message == "ok")
                {
                    UsersDTO userData = await _userRepository.GetUserByEmail(User);
                    response.IsSuccess = true;
                    response.Data = GenerateTokenHelper.GenerateToken(userData, keyToken, hours);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> CreateUser(CreateUserDTO userDTO )
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                userDTO.password = Hash256Helper.GetSHA256Hash(userDTO.password);
                return await _userRepository.CreateUsersRepository(userDTO);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteUser(int id)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                if (id <= 0)
                {
                    respuesta.Message = "Enter a ValidUserID\r\n";
                    return respuesta;
                }
                return await _userRepository.DeleteUserRepository(id);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetUser(int idCompany)
        {

            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _userRepository.GetUsersRepository(idCompany); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> IGetUserById(int id)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _userRepository.GetUserByIdRepository(id); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateUser(UsersDTO userDTO)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                userDTO.password = Hash256Helper.GetSHA256Hash(userDTO.password);
                ResponseDTO responseRepository = await _userRepository.UpdateUserRepository(userDTO);
                return responseRepository;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
