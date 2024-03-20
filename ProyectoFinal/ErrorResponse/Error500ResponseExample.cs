using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.SwaggerExample.ErrorResponse
{
    public class Error500ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "Internal server error: An unexpected error occurred."
            };
        }
    }
}
