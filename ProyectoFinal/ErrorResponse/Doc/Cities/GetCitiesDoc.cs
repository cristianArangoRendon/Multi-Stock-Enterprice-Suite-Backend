using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.City;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Cities
{
    public class GetCitiesDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<CitiesDTO>
                {
                    new CitiesDTO
                    {
                        idCity = 1,
                        Description = "Medellín"
                    },
                    new CitiesDTO
                    {
                        idCity = 1,
                        Description = "Bogota"
                    },
                    new CitiesDTO
                    {
                        idCity = 1,
                        Description = "Cartagena"
                    }
                }
            };
        }
    }
}
