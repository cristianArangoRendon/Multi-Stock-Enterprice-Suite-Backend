using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Category
{
    public class GetCategoryById : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new categoryDTO
                {
                    IdCategory = 1,
                    Description = "Neumáticos y Ruedas"
                }
            };
        }
    }
}
