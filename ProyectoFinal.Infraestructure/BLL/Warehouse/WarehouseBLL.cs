using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Warehouse;
using ProyectoFinal.Core.Interfaces.IRepository.Warehouse;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Warehouse
{
    public class WarehouseBLL : IWarehouseBLL
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly ILogService _logService;
        public WarehouseBLL(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public async Task<ResponseDTO> CreateWarehouse(int idHeadquaters, string Description, int  idUser, int idCompany)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _warehouseRepository.CreateWarehouse(idHeadquaters, Description, idUser, idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteWarehouse(int idWarehouse, int idCompany, int idUser, int idRol)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                if (idRol == 1)
                {
                    return await _warehouseRepository.DeleteWarehouse(idWarehouse, idCompany, idUser);
                }
                else
                {
                    response.Message = "You do not have the necessary permissions to perform this action.";
                }
                return response;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetWarehouse(int idHeadquaters, int idCompany)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
                return await _warehouseRepository.GetWarehouse(idHeadquaters, idCompany);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public Task<ResponseDTO> UpdateWarehouse(int idWarehouse)
        {
            throw new NotImplementedException();
        }
    }
}
