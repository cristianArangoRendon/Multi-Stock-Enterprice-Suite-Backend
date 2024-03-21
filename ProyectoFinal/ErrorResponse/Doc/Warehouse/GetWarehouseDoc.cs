using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Warehouse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Warehouse
{
    public class GetWarehouseDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<WarehouseDTO>
                {
                    new WarehouseDTO
                    {
                        idWarehouse = 4,
                        Description = "Moto tienda Envigado"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 5,
                        Description = "Moto tienda Sabaneta"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 6,
                        Description = "Moto tienda Laureles"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 7,
                        Description = "Moto tienda Belén"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 8,
                        Description = "Moto tienda Robledo"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 9,
                        Description = "Moto tienda Manrique"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 10,
                        Description = "Moto tienda Castilla"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 11,
                        Description = "Moto tienda Buenos Aires"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 12,
                        Description = "Moto tienda Aranjuez"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 13,
                        Description = "Moto tienda Popular"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 14,
                        Description = "Moto tienda Guayabal"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 15,
                        Description = "Moto tienda San Javier"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 16,
                        Description = "Moto tienda El Poblado"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 17,
                        Description = "Moto tienda Envigado"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 18,
                        Description = "Moto tienda Sabaneta"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 19,
                        Description = "Moto tienda Laureles"
                    },
                    new WarehouseDTO
                    {
                        idWarehouse = 20,
                        Description = "Moto tienda Belén"
                    }

                }
            };
        }
    }
}
