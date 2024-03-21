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
                        idCity = 2,
                        Description = "Envigado"
                    },
                    new CitiesDTO
                    {
                        idCity = 3,
                        Description = "Itagüí"
                    },
                    new CitiesDTO
                    {
                        idCity = 4,
                        Description = "Bello"
                    },
                    new CitiesDTO
                    {
                        idCity = 5,
                        Description = "Sabaneta"
                    },
                    new CitiesDTO
                    {
                        idCity = 6,
                        Description = "La Estrella"
                    },
                    new CitiesDTO
                    {
                        idCity = 7,
                        Description = "Copacabana"
                    },
                    new CitiesDTO
                    {
                        idCity = 8,
                        Description = "Girardota"
                    },
                    new CitiesDTO
                    {
                        idCity = 9,
                        Description = "Barbosa"
                    },
                    new CitiesDTO
                    {
                        idCity = 10,
                        Description = "Caldas"
                    },
                    new CitiesDTO
                    {
                        idCity = 11,
                        Description = "Rionegro"
                    },
                    new CitiesDTO
                    {
                        idCity = 12,
                        Description = "Santa Fe de Antioquia"
                    },
                    new CitiesDTO
                    {
                        idCity = 13,
                        Description = "Guarne"
                    },
                    new CitiesDTO
                    {
                        idCity = 14,
                        Description = "Carmen de Viboral"
                    },
                    new CitiesDTO
                    {
                        idCity = 15,
                        Description = "El Retiro"
                    },
                    new CitiesDTO
                    {
                        idCity = 16,
                        Description = "La Ceja"
                    },
                    new CitiesDTO
                    {
                        idCity = 17,
                        Description = "San Jerónimo"
                    },
                    new CitiesDTO
                    {
                        idCity = 18,
                        Description = "Marinilla"
                    },
                    new CitiesDTO
                    {
                        idCity = 19,
                        Description = "Abejorral"
                    },
                    new CitiesDTO
                    {
                        idCity = 20,
                        Description = "El Santuario"
                    }

                }
            };
        }
    }
}
