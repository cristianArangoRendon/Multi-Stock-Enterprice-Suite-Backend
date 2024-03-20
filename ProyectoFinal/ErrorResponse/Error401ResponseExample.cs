using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.SwaggerExample.ErrorResponse
{
    public class Error401ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "Unauthorized: Invalid credentials or access denied."
            };
        }
    }
}
