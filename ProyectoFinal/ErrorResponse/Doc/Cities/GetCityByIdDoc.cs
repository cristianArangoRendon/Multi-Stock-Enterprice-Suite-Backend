using ProyectoFinal.Core.DTOs.City;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Cities
{
    public class GetCityByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new CitiesDTO
                {
                    idCity = 1,
                    Description = "Medellín"
                }
            };
        }
    }
}
