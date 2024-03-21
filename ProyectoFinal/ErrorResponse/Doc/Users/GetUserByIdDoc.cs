using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Users
{
    public class GetUserByIdDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new UsersDTO
                {
                    idUser = 2,
                    Names = "Usuario",
                    lastNames = "Uno",
                    Email = "usuario1@example.com",
                    password = "password123",
                    idCompany = 1,
                    lastLoginDate = DateTime.Today,
                    gender = 'M',
                    image = "https://example.com/user1.jpg",
                    idRol = 2
                }
            };
        }
    }
}
