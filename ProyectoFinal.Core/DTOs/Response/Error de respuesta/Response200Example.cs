using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;
namespace ActiveDirectoryBack.SwaggerExamples.ErrorResponse
{
    public class Response200Example : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "Estado de operacion",
                Data = "ModelDTO"
            };
        }
    }
}
