using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Users
{
    public class GetUsersDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<UsersDTO>
                {
                    new UsersDTO
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
                    },
                    new UsersDTO
                    {
                        idUser = 3,
                        Names = "Usuario",
                        lastNames = "Dos",
                        Email = "usuario2@example.com",
                        password = "password456",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/user2.jpg",
                        idRol = 2
                    },
                    new UsersDTO
                    {
                        idUser = 4,
                        Names = "Gerente",
                        lastNames = "Uno",
                        Email = "gerente1@example.com",
                        password = "password789",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/gerente1.jpg",
                        idRol = 3
                    },
                    new UsersDTO
                    {
                        idUser = 5,
                        Names = "Gerente",
                        lastNames = "Dos",
                        Email = "gerente2@example.com",
                        password = "passwordabc",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/gerente2.jpg",
                        idRol = 3
                    },
                    new UsersDTO
                    {
                        idUser = 6,
                        Names = "Supervisor",
                        lastNames = "Uno",
                        Email = "supervisor1@example.com",
                        password = "passwordxyz",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/supervisor1.jpg",
                        idRol = 4
                    },
                    new UsersDTO
                    {
                        idUser = 7,
                        Names = "Supervisor",
                        lastNames = "Dos",
                        Email = "supervisor2@example.com",
                        password = "passworddef",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/supervisor2.jpg",
                        idRol = 4
                    },
                    new UsersDTO
                    {
                        idUser = 8,
                        Names = "Técnico",
                        lastNames = "Uno",
                        Email = "tecnico1@example.com",
                        password = "passwordghi",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/tecnico1.jpg",
                        idRol = 5
                    },
                    new UsersDTO
                    {
                        idUser = 9,
                        Names = "Técnico",
                        lastNames = "Dos",
                        Email = "tecnico2@example.com",
                        password = "passwordjkl",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/tecnico2.jpg",
                        idRol = 5
                    },
                    new UsersDTO
                    {
                        idUser = 10,
                        Names = "Contador",
                        lastNames = "Uno",
                        Email = "contador1@example.com",
                        password = "passwordmno",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/contador1.jpg",
                        idRol = 6
                    },
                    new UsersDTO
                    {
                        idUser = 11,
                        Names = "Contador",
                        lastNames = "Dos",
                        Email = "contador2@example.com",
                        password = "passwordpqr",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/contador2.jpg",
                        idRol = 6
                    },
                    new UsersDTO
                    {
                        idUser = 12,
                        Names = "Vendedor",
                        lastNames = "Uno",
                        Email = "vendedor1@example.com",
                        password = "passwordstu",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/vendedor1.jpg",
                        idRol = 7
                    },
                    new UsersDTO
                    {
                        idUser = 13,
                        Names = "Vendedor",
                        lastNames = "Dos",
                        Email = "vendedor2@example.com",
                        password = "passwordvwx",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/vendedor2.jpg",
                        idRol = 7
                    },
                    new UsersDTO
                    {
                        idUser = 14,
                        Names = "Recepcionista",
                        lastNames = "Uno",
                        Email = "recepcionista1@example.com",
                        password = "passwordyz",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/recepcionista1.jpg",
                        idRol = 8
                    },
                    new UsersDTO
                    {
                        idUser = 15,
                        Names = "Recepcionista",
                        lastNames = "Dos",
                        Email = "recepcionista2@example.com",
                        password = "password123abc",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'F',
                        image = "https://example.com/recepcionista2.jpg",
                        idRol = 8
                    },
                    new UsersDTO
                    {
                        idUser = 16,
                        Names = "Analista",
                        lastNames = "Uno",
                        Email = "analista1@example.com",
                        password = "passworddefghi",
                        idCompany = 1,
                        lastLoginDate = DateTime.Today,
                        gender = 'M',
                        image = "https://example.com/analista1"
                    }
                }
            };
        }
    }
}
