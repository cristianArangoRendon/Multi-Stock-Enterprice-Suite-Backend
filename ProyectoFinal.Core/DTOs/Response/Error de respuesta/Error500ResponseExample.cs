using Swashbuckle.AspNetCore.Filters;
namespace ActiveDirectoryBack.SwaggerExamples.ErrorResponse
{
    public class Error500ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "Error interno del servidor: Ocurrió un error inesperado."
            };
        }
    }
}
