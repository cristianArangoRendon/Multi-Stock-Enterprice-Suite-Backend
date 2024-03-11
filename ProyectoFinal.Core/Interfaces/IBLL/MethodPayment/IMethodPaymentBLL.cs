using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.MethodPayment
{
    public interface IMethodPaymentBLL
    {
        public Task<ResponseDTO> CreateMethodPayment(string Description);
        public Task<ResponseDTO> GetMethodPayment();
        public Task<ResponseDTO> DeleteMethodPayment(int idMethodPayment);
        public Task<ResponseDTO> UpdateMethodPayment(int idMethodPayment, string Description);
    }
}
