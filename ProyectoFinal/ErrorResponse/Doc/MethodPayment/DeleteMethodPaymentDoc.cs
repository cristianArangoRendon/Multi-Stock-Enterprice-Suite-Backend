using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.MethodPayment
{
    public class DeleteMethodPaymentDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "MethodPayment Delete successfully",
                Data = null
            };
        }

    }
}
