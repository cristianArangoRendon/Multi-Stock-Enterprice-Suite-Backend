using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Rol
{
    public class GetRolesDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<RolDTO>
                {
                    new RolDTO
                    {
                        IdRol = 2,
                        Description = "Supervisor"
                    },
                    new RolDTO
                    {
                        IdRol = 3,
                        Description = "Técnico"
                    },
                    new RolDTO
                    {
                        IdRol = 4,
                        Description = "Contador"
                    },
                    new RolDTO
                    {
                        IdRol = 5,
                        Description = "Vendedor"
                    },
                    new RolDTO
                    {
                        IdRol = 6,
                        Description = "Recepcionista"
                    },
                    new RolDTO
                    {
                        IdRol = 7,
                        Description = "Analista"
                    },
                    new RolDTO
                    {
                        IdRol = 8,
                        Description = "Consultor"
                    },
                    new RolDTO
                    {
                        IdRol = 9,
                        Description = "Desarrollador"
                    },
                    new RolDTO
                    {
                        IdRol = 10,
                        Description = "Diseñador"
                    },
                    new RolDTO
                    {
                        IdRol = 11,
                        Description = "Ingeniero"
                    },
                    new RolDTO
                    {
                        IdRol = 12,
                        Description = "Asistente"
                    },
                    new RolDTO
                    {
                        IdRol = 13,
                        Description = "Coordinador"
                    },
                    new RolDTO
                    {
                        IdRol = 14,
                        Description = "Operario"
                    },
                    new RolDTO
                    {
                        IdRol = 15,
                        Description = "Jefe de Proyecto"
                    },
                    new RolDTO
                    {
                        IdRol = 16,
                        Description = "Director"
                    },
                    new RolDTO
                    {
                        IdRol = 17,
                        Description = "Entrenador"
                    },
                    new RolDTO
                    {
                        IdRol = 18,
                        Description = "Recursos Humanos"
                    },
                    new RolDTO
                    {
                        IdRol = 19,
                        Description = "Especialista"
                    },
                    new RolDTO
                    {
                        IdRol = 20,
                        Description = "Marketing"
                    }


                }
            };
        }
    }
}
