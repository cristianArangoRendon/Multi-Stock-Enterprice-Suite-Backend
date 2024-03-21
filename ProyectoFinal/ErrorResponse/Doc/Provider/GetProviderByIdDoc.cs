using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Provider
{
    public class GetProviderByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new ProviderDTO
                {
                    idProvider = 4,
                    Description = "BikeParts"
                }
            };
        }
    }
}
