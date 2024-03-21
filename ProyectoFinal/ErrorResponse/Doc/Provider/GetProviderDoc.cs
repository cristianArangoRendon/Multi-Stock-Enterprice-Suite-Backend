using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Provider
{
    public class GetProviderDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<ProviderDTO>
                {
                    new ProviderDTO
                    {
                        idProvider = 4,
                        Description = "BikeParts"
                    },
                    new ProviderDTO
                    {
                        idProvider = 5,
                        Description = "MotoAccesorios"
                    },
                    new ProviderDTO
                    {
                        idProvider = 6,
                        Description = "SpeedyMoto"
                    },
                    new ProviderDTO
                    {
                        idProvider = 7,
                        Description = "PartsRUs"
                    },
                    new ProviderDTO
                    {
                        idProvider = 8,
                        Description = "MotoWorld"
                    },
                    new ProviderDTO
                    {
                        idProvider = 9,
                        Description = "MotoZone"
                    },
                    new ProviderDTO
                    {
                        idProvider = 10,
                        Description = "SpeedBike"
                    },
                    new ProviderDTO
                    {
                        idProvider = 11,
                        Description = "MotoEmporium"
                    },
                    new ProviderDTO
                    {
                        idProvider = 12,
                        Description = "BikeEmpire"
                    },
                    new ProviderDTO
                    {
                        idProvider = 13,
                        Description = "SpeedGear"
                    },
                    new ProviderDTO
                    {
                        idProvider = 14,
                        Description = "MotoPartsDirect"
                    },
                    new ProviderDTO
                    {
                        idProvider = 15,
                        Description = "MotoPro"
                    },
                    new ProviderDTO
                    {
                        idProvider = 16,
                        Description = "MotoTech"
                    },
                    new ProviderDTO
                    {
                        idProvider = 17,
                        Description = "SpeedyParts"
                    },
                    new ProviderDTO
                    {
                        idProvider = 18,
                        Description = "MotoMall"
                    },
                    new ProviderDTO
                    {
                        idProvider = 19,
                        Description = "BikeWorks"
                    },
                    new ProviderDTO
                    {
                        idProvider = 20,
                        Description = "MotoDepot"
                    }


                }
            };
        }
    }
}
