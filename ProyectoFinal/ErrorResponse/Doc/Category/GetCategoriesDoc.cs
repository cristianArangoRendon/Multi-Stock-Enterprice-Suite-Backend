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
                        Description = "Neumáticos y Ruedas"
                    },
                    new categoryDTO
                    {
                        IdCategory = 2,
                        Description = "Frenos y Embragues"
                    },
                    new categoryDTO
                    {
                        IdCategory = 3,
                        Description = "Transmisión y Cadena"
                    },
                    new categoryDTO
                    {
                        IdCategory = 4,
                        Description = "Suspensión y Chasis"
                    },
                    new categoryDTO
                    {
                        IdCategory = 5,
                        Description = "Motor y Componentes"
                    },
                    new categoryDTO
                    {
                        IdCategory = 6,
                        Description = "Escape y Silenciadores"
                    },
                    new categoryDTO
                    {
                        IdCategory = 7,
                        Description = "Luces y Faros"
                    },
                    new categoryDTO
                    {
                        IdCategory = 8,
                        Description = "Electrónica y Sistemas de Encendido"
                    },
                    new categoryDTO
                    {
                        IdCategory = 9,
                        Description = "Carenados y Carrocería"
                    },
                    new categoryDTO
                    {
                        IdCategory = 10,
                        Description = "Accesorios para el Conductor"
                    },
                    new categoryDTO
                    {
                        IdCategory = 11,
                        Description = "Accesorios para el Pasajero"
                    },
                    new categoryDTO
                    {
                        IdCategory = 12,
                        Description = "Equipaje y Almacenamiento"
                    },
                    new categoryDTO
                    {
                        IdCategory = 13,
                        Description = "Instrumentación y Medidores"
                    },
                    new categoryDTO
                    {
                        IdCategory = 14,
                        Description = "Herramientas y Mantenimiento"
                    },
                    new categoryDTO
                    {
                        IdCategory = 15,
                        Description = "Equipamiento de Seguridad"
                    },
                    new categoryDTO
                    {
                        IdCategory = 16,
                        Description = "Estilo y Personalización"
                    },
                    new categoryDTO
                    {
                        IdCategory = 17,
                        Description = "Cuidado y Mantenimiento"
                    },
                    new categoryDTO
                    {
                        IdCategory = 18,
                        Description = "Consumibles y Lubricantes"
                    },
                    new categoryDTO
                    {
                        IdCategory = 19,
                        Description = "Productos para Viajes y Aventuras"
                    },
                    new categoryDTO
                    {
                        IdCategory = 20,
                        Description = "Repuestos y Accesorios Generales"
                    }

                }
            };
        }
    }
}
