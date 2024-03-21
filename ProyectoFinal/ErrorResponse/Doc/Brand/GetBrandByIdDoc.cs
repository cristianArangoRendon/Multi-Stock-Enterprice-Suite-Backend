using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Brand
{
    public class GetBrandByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new BrandDTO
                {
                    IdBrand = 1,
                    Description = "Yamaha"
                }
            };
        }
    }
}
