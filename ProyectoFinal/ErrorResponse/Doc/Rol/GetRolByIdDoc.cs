using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Rol
{
    public class GetRolByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new RolDTO
                {
                    IdRol = 2,
                    Description = "Supervisor"
                }
            };
        }
    }
}
