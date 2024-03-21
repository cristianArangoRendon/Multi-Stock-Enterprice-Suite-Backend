using ProyectoFinal.Core.DTOs.Neighborhood;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Neighborhood
{
    public class GetNeighborhoodDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<NeighborhoodDTO>
                {
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 1,
                        Description = "Bello"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 2,
                        Description = "San Pablo"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 3,
                        Description = "Santo Domingo"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 4,
                        Description = "La Candelaria"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 5,
                        Description = "El Poblado"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 6,
                        Description = "Laureles"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 7,
                        Description = "Envigado"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 8,
                        Description = "Itagüí"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 9,
                        Description = "Robledo"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 10,
                        Description = "Belén"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 11,
                        Description = "Manrique"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 12,
                        Description = "Castilla"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 13,
                        Description = "Buenos Aires"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 14,
                        Description = "Aranjuez"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 15,
                        Description = "Popular"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 16,
                        Description = "Sabaneta"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 17,
                        Description = "Envigado"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 18,
                        Description = "Guayabal"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 19,
                        Description = "San Javier"
                    },
                    new NeighborhoodDTO
                    {
                        idNeighborhood = 20,
                        Description = "El Poblado"
                    }

                }
            };
        }
    }
}
