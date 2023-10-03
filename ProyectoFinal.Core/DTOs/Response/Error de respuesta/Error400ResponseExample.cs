using Swashbuckle.AspNetCore.Filters;

namespace ActiveDirectoryBack.SwaggerExamples.ErrorResponse
{
    public class Error400ResponseExample : IExamplesProvider<object>
    {
        public object GetExamples()
        {
            return new
            {
                IsSuccess = false,
                Message = "Bad request, se envían parámetros incorrecto"
            };
        }
    }
}
