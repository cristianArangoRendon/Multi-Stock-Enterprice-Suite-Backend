using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Neighborhood;
using ProyectoFinal.Core.Interfaces.IRepository.neighborhood;
using ProyectoFinal.Infraestructure.Helpers;
using System.Text;

namespace ProyectoFinal.Infraestructure.BLL.Neighborhood
{
    public class NeighborhoodBLL : INeighborhoodBLL
    {
        private readonly INeighborhoodRepository _repository;
        private readonly ILogService _logService;
        public NeighborhoodBLL(INeighborhoodRepository repository, ILogService logService)
        {
            _repository = repository;
            _logService = logService;
        }

        public async Task<ResponseDTO> CreateNeighborhood(string Description, int idCity)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _repository.CreateNeighborhood(Description,idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteNeighborhood(int idNeighborhood)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _repository.DeleteNeighborhood(idNeighborhood);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetNeighborhood(int idCity)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _repository.GetNeighborhood(idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetNeighborhoodById(int idNeighborhood, int idCity)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _repository.GetNeighborhoodById(idNeighborhood, idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateNeighborhoodById(int idNeighborhood, string Description, int idCity)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _repository.UpdateNeighborhoodById(idNeighborhood, Description, idCity);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
