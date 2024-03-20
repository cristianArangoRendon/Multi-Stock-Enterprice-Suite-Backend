using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.SwaggerExample.ErrorResponse
{
    public class Error400ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "Bad request, incorrect parameters sent"
            };
        }
    }
}
