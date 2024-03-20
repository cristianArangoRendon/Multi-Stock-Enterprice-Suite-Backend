using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Category
{
    public class GetCategoriesDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<categoryDTO>
                {
                    new categoryDTO
                    {
                      IdCategory = 1,
                      Description = "Accesorios"
                    },

                    new categoryDTO
                    {
                      IdCategory = 2,
                      Description = "Repuestos"
                    },

                    new categoryDTO
                    {
                      IdCategory = 3,
                      Description = "Colección"
                    },
                }
            };
        }
    }
}
