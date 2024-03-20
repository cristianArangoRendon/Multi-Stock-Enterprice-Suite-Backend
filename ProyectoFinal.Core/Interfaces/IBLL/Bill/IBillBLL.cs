using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Bill
{
    public interface IBillBLL
    {
        public Task<ResponseDTO> CreateBill(CreateBillDTO createBill);
        public Task<ResponseDTO> GetBill(int idUser);
        public Task<ResponseDTO> GetBillById(int idBill, int idUser);
        public Task<ResponseDTO> DeleteBill(int idBill, int idUser);
        public Task<ResponseDTO> UpdateBill(UpdateBill update);
    }
}
