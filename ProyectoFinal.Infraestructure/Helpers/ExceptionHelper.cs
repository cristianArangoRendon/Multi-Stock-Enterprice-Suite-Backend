using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Infraestructure.Helpers
{
    public class ExceptionHelper
    {
        public static ResponseDTO  HandleException(ILogService logService, string methodName, Exception ex)
        {
            logService.SaveLogsMessages($"Se ha producido un error al ejecutar BLL: {methodName}: {ex.Message}");
            var response = new ResponseDTO
            {
                IsSuccess = false,
                Message = ex.ToString()
            };
            return response;
        }
    }
}
