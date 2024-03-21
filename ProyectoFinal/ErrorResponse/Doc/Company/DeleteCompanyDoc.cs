using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Company
{
    public class DeleteCompanyDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "Company Delete successfully",
                Data = null
            };
        }

    }
}
