using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Headquarter;
using ProyectoFinal.Core.Interfaces.IRepository.Headquarter;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Headquarters
{
    public class HeadquartersBLL : IHeadquarterBLL
    {
        private readonly IHeadquarterRepository _headquarter;
        private readonly ILogService _logger;
        public HeadquartersBLL(IHeadquarterRepository repository, ILogService logs)
        {
            _headquarter = repository;
            _logger = logs;
        }

        public async Task<ResponseDTO> CreateHeadquaters(CreateHeadquartersDTO create)
        {

            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _headquarter.CreateHeadquaters(create);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logger, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetHeadquaters(int idCompany)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _headquarter.GetHeadquaters(idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logger, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateHeadquaters(UpdateHeadquarters updateHeadquarters)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _headquarter.UpdateHeadquaters(updateHeadquarters);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logger, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
