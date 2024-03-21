using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Company
{
    public class CreateCompanyDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "Company Create successfully",
                Data = null
            };
        }

    }
}
