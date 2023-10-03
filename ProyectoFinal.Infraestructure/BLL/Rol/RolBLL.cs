using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using ProyectoFinal.Core.Interfaces.IBLL.Rol;
using ProyectoFinal.Core.Interfaces.IRepository.Rol;

namespace ProyectoFinal.Infraestructure.BLL.Rol
{
    public class RolBLL : IRolBLL
    {
        private readonly ILogService _logService;
        private IRolRepository _repository;
        public RolBLL(ILogService logService, IRolRepository repository)
        {
            _logService = logService;
            _repository = repository;
        }

        public async Task<ResponseDTO> CreateRolBLL(string description)
        {

            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _repository.CreateRolRepository(description);
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL CreateRolRepository: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }

      

        public async Task<ResponseDTO> GetRolByIdBLL(int RolId)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {  
               
                return await _repository.GetRolByIdRepository(RolId); 
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL GetRolByIdRepository: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }

        public async Task<ResponseDTO> GetRolesBLL()
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _repository.GetRolesRepository(); ;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL GetRolesRepository: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }

        public async Task<ResponseDTO> UpdateRolBLL(RolDTO rol)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _repository.UpdateRolRepository(rol); ;
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL UpdateRolRepository: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }
    }
}
