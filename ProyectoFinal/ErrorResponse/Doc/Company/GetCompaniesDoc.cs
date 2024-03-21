using ProyectoFinal.Core.DTOs.Company;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Company
{
    public class GetCompaniesDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<CompaniesDTO>
                {
                    new CompaniesDTO
                    {
                        IdCompany = 1,
                        Description = "Moto tienda"
                    },
                    new CompaniesDTO
                    {
                        IdCompany = 1,
                        Description = "MundiMotos"
                    },
                    new CompaniesDTO
                    {
                        IdCompany = 1,
                        Description = "Motos"
                    }
                }
            };
        }
    }
}
