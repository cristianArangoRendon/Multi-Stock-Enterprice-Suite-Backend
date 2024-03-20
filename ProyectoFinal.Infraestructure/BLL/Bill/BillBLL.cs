using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Bill;
using ProyectoFinal.Core.Interfaces.IRepository.Bill;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.BLL.Bill
{
    public class BillBLL : IBillBLL
    {
        private readonly IBillRepository _billRepository;
        private readonly ILogService _logService;
        
        public BillBLL(IBillRepository billRepository, ILogService logService)
        {
            _billRepository = billRepository;
            _logService = logService;
        }


        public async Task<ResponseDTO> CreateBill(CreateBillDTO createBill)
        {
           ResponseDTO response = new ResponseDTO();
           response.IsSuccess = false;
            try
            {
                return await _billRepository.CreateBill(createBill);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }

        }

        public async Task<ResponseDTO> DeleteBill(int idBill, int idUser)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _billRepository.DeleteBill(idBill, idUser);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetBill(int idUser)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _billRepository.GetBill(idUser);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetBillById(int idBill, int idUser)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _billRepository.GetBillById(idBill, idUser);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateBill(UpdateBill update)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;
            try
            {
                return await _billRepository.UpdateBill(update);
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_logService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
