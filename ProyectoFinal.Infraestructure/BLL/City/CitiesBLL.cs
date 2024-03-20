using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.City;
using ProyectoFinal.Core.Interfaces.IRepository.City;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.City
{
    public class CitiesBLL : ICitiesBLL
    {
        private readonly ICitiesRepository _cityRepository;
        private readonly ILogService _logService;
        public CitiesBLL(ICitiesRepository cityRepository, ILogService logService)
        {
            _cityRepository = cityRepository;
            _logService = logService;
        }

        public async Task<ResponseDTO> CityById(int idCity)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _cityRepository.CityById(idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> CreateCity(string Description)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _cityRepository.CreateCity(Description);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteCity(int idCity)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _cityRepository.DeleteCity(idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetCities()
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _cityRepository.GetCities();
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateCity(int idCity, string Description)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _cityRepository.UpdateCity(idCity, Description);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
