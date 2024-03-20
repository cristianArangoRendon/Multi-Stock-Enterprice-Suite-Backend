using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.MethodPayment;
using ProyectoFinal.Core.Interfaces.IRepository.MethodPayment;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.MethodPayment
{
    public class MethodPaymentBLL : IMethodPaymentBLL
    {
        private readonly ILogService _logService;
        private readonly IMethodPaymentRepository _methodPaymentRepository;

        public MethodPaymentBLL(ILogService logs, IMethodPaymentRepository method)
        {
            _logService = logs;
            _methodPaymentRepository = method;
        }
        public async Task<ResponseDTO> CreateMethodPayment(string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _methodPaymentRepository.CreateMethodPayment(Description);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteMethodPayment(int idMethodPayment)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _methodPaymentRepository.DeleteMethodPayment(idMethodPayment);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetMethodPayment()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _methodPaymentRepository.GetMethodPayment();
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateMethodPayment(int idMethodPayment, string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _methodPaymentRepository.UpdateMethodPayment(idMethodPayment, Description);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
