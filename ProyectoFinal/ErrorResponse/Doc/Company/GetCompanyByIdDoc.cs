using ProyectoFinal.Core.DTOs.Company;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Company
{
    public class GetCompanyByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new CompaniesDTO
                {        
                        IdCompany = 1,
                        Description = "Moto tienda"
               }
            };
        }
    }
}
