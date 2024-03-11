using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.MethodPayment;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.MethodPayment;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.MethodPayment
{
    public class MethodPaymentRepository : IMethodPaymentRepository
    {

        private readonly IExecuteStoredProcedureServiceService _serviceService;
        public MethodPaymentRepository(IExecuteStoredProcedureServiceService executeStoreProcedure) => _serviceService = executeStoreProcedure;  
        public async Task<ResponseDTO> CreateMethodPayment(string Description)
        {
            var parameters = new
            {
                Description = Description,
            };
            return await _serviceService.ExecuteStoredProcedure("CreateMethodPayment", parameters);
        }

        public async Task<ResponseDTO> DeleteMethodPayment(int idMethodPayment)
        {
            var parameters = new
            {
                IdMethodPayment = idMethodPayment,
            };
            return await _serviceService.ExecuteStoredProcedure("DeleteMethodPayment", parameters);
        }

        public async Task<ResponseDTO> GetMethodPayment() =>  await _serviceService.ExecuteData("GetMethodPayment", MapToListHelper.MapToList<MethodPaymentDTO>);

        public async Task<ResponseDTO> UpdateMethodPayment(int idMethodPayment, string Description)
        {
            var parameters = new
            {
                IdMethodPayment = idMethodPayment,
                Description = Description,
            };
            return await _serviceService.ExecuteStoredProcedure("UpdateMethodPayment", parameters);
        }
    }
}
