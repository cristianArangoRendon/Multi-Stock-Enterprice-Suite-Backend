using ActiveDirectoryBack.Core.Interfaces.Services;
using ActiveDirectoryBack.Infrastructure.Helpers;
using crm.Infrastructure.Helpers;
using Microsoft.Extensions.Configuration;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.Core.Interfaces.IRepository.Users;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Users
{
    public class UsersBLL : IUserBLL
    {

        private readonly IUsersRepository _userRepository;
        private readonly ILogService _logService;
        private readonly IConfiguration _configuration;
        private readonly ISendEmailService _sendEmailService;

        public UsersBLL(IUsersRepository Users, ILogService logService,  IConfiguration configuration, ISendEmailService sendEmail)
        {
            _userRepository = Users;
            _logService = logService;
            _configuration = configuration;
            _sendEmailService = sendEmail;
        }

        public async Task<ResponseDTO> Auth(string User, string password)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            int hours = int.Parse(_configuration["Hors"]);
            string keyToken = _configuration["AppSettings:SecretToken"];
            try
            {
                password = Hash256Helper.GetSHA256Hash(password);
                response = await _userRepository.Auth(User, password);
                if (response.Message == "ok")
                {
                    UsersDTO userData = await _userRepository.GetUserByEmail(User);
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
            var body = "";
            try
            {
                userDTO.password = Hash256Helper.GetSHA256Hash(userDTO.password);
                var EmailService = await _sendEmailService.SendEmail(userDTO.Email, body, userDTO.Names);
                var responseData = await _userRepository.CreateUsersRepository(userDTO);
                return  responseData;
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

        public async Task<ResponseDTO> GetUserById(int idUser, int idCompany)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _userRepository.GetUserByIdRepository(idUser, idCompany); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateUser(UpdateUserDTO userDTO)
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
