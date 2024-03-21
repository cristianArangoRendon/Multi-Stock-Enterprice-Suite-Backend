using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.ProductsDoc
{
    public class CreateProductDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "Product Create successfully",
                Data = null
            };
        }
    }
}
