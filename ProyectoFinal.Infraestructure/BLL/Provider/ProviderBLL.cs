using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;

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

        public async Task<ResponseDTO> CreateProviderBLL(string providerDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.CreateProviderRepository(providerDTO);
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll CreateProviderBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }


        public async Task<ResponseDTO> DeleteProviderBLL(int idProvider)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.DeleteProviderRepository(idProvider);
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll DeleteProviderBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetProviderBLL( )
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.GetProviderRepository();
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetProviderBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetProviderByIdBLL(int IdProvider)
        {

            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.GetProviderByIdRepository(IdProvider);
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetProviderBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateProviderBLL(ProviderDTO providerDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _providerRepository.UpdateProviderRepository(providerDTO);
            }
            catch (Exception ex)
            {
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll UpdateProviderBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
