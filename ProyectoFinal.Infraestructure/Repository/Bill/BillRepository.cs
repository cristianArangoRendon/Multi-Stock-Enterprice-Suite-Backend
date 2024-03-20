using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Bill;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.Repository.Bill
{
    public class BillRepository : IBillRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureServiceService;
        public BillRepository(IExecuteStoredProcedureServiceService executeStoredProcedureServiceService)
        {
            _executeStoredProcedureServiceService = executeStoredProcedureServiceService;
        }

        public async Task<ResponseDTO> CreateBill(CreateBillDTO createBill)
        {
            object obj = createBill.ToObject<CreateBillDTO>();
            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.CreateBill", obj);
        }

        public async Task<ResponseDTO> DeleteBill(int idBill, int idUser)
        {
            var parameters = new
            {
                idBill = idBill,
                idUser = idUser
            };
            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.DeleteBill", parameters);
        }

        public  async Task<ResponseDTO> GetBill(int idUser)
        {
            var parameters = new
            {
                idUser = idUser,
            };
            return await _executeStoredProcedureServiceService.ExecuteDataStoredProcedure("dbo.GetBill", parameters, MapToListHelper.MapToList<BillDTO>);
        }

        public async  Task<ResponseDTO> GetBillById(int idBill, int idUser)
        {
            var parameters = new
            {
                idBill = idBill,
                idUser = idUser
            };
            return await _executeStoredProcedureServiceService.ExecuteSingleObjectStoredProcedure("dbo.GetBillById", parameters, MapToObjHelper.MapToObj<BillDTO>);
        }

        public async Task<ResponseDTO> UpdateBill(UpdateBill update)
        {
            object obj = update.ToObject<UpdateBill>();
            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.UpdateBill", obj);
        }
    }
}
