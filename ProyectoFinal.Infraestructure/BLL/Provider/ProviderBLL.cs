using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Provider
{
    public class ProviderBLL : IProviderBLL
    {
        private readonly IProviderRepository _providerRepository;
        private readonly ILogService _LogService;
        public ProviderBLL(IProviderRepository providerBLL, ILogService logService)
        {
            _providerRepository = providerBLL;
            _LogService = logService;
        }

        public async Task<ResponseDTO> CreateProviderBLL(string providerDTO, int idCompany)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.CreateProviderRepository(providerDTO, idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }


        public async Task<ResponseDTO> DeleteProviderBLL(int idProvider, int idCompany)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.DeleteProviderRepository(idProvider, idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetProviderBLL(int idCompany)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.GetProviderRepository(idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetProviderByIdBLL(int IdProvider, int idCompany)
        {

            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.GetProviderByIdRepository(IdProvider, idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateProviderBLL(ProviderUpdateDTO providerDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.UpdateProviderRepository(providerDTO);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
