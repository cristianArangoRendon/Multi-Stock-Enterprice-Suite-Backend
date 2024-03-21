using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Brand
{
    public class GetBrandDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<BrandDTO>
                {
                    new BrandDTO
                    {
                        IdBrand = 1,
                        Description = "Yamaha"
                    },
                    new BrandDTO
                    {
                        IdBrand = 2,
                        Description = "Honda"
                    },
                    new BrandDTO
                    {
                        IdBrand = 3,
                        Description = "Suzuki"
                    },
                    new BrandDTO
                    {
                        IdBrand = 4,
                        Description = "Kawasaki"
                    },
                    new BrandDTO
                    {
                        IdBrand = 5,
                        Description = "Ducati"
                    },
                    new BrandDTO
                    {
                        IdBrand = 6,
                        Description = "BMW Motorrad"
                    },
                    new BrandDTO
                    {
                        IdBrand = 7,
                        Description = "Harley-Davidson"
                    },
                    new BrandDTO
                    {
                        IdBrand = 8,
                        Description = "Triumph"
                    },
                    new BrandDTO
                    {
                        IdBrand = 9,
                        Description = "KTM"
                    },
                    new BrandDTO
                    {
                        IdBrand = 10,
                        Description = "Aprilia"
                    },
                    new BrandDTO
                    {
                        IdBrand = 11,
                        Description = "Moto Guzzi"
                    },
                    new BrandDTO
                    {
                        IdBrand = 12,
                        Description = "Victory Motorcycles"
                    },
                    new BrandDTO
                    {
                        IdBrand = 13,
                        Description = "Indian Motorcycle"
                    },
                    new BrandDTO
                    {
                        IdBrand = 14,
                        Description = "Piaggio"
                    },
                    new BrandDTO
                    {
                        IdBrand = 15,
                        Description = "Bajaj Auto"
                    },
                    new BrandDTO
                    {
                        IdBrand = 16,
                        Description = "Royal Enfield"
                    },
                    new BrandDTO
                    {
                        IdBrand = 17,
                        Description = "Hero MotoCorp"
                    },
                    new BrandDTO
                    {
                        IdBrand = 18,
                        Description = "TVS Motor Company"
                    },
                    new BrandDTO
                    {
                        IdBrand = 19,
                        Description = "CFMoto"
                    },
                    new BrandDTO
                    {
                        IdBrand = 20,
                        Description = "Husqvarna Motorcycles"
                    }

                }
            };
        }
    }
}
