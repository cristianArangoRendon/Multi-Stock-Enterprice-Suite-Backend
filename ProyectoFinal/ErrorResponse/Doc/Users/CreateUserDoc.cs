using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Users
{
    public class CreateUserDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "User Create successfully",
                Data = null
            };
        }

    }
}
