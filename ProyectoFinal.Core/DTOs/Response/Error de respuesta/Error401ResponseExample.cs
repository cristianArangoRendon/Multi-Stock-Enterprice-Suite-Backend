using Swashbuckle.AspNetCore.Filters;

namespace ActiveDirectoryBack.SwaggerExamples.ErrorResponse
{
    public class Error401ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "No autorizado: Credenciales inválidas o acceso denegado."
            };
        }
    }
}
