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
                        Description = "Nike"
                    },
                    new BrandDTO
                    {
                        IdBrand = 2,
                        Description = "Adidas"
                    },
                    new BrandDTO
                    {
                        IdBrand = 3,
                        Description = "Puma"
                    }
                }
            };
        }
    }
}
