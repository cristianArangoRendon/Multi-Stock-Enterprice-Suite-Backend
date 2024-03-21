using ProyectoFinal.Core.DTOs.Company;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.ErrorResponse.Doc.Headquarters
{
    public class GetHeadquartersDoc : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO()
            {
                IsSuccess = true,
                Message = "Successfull Operation.",
                Data = new List<HeadquartersDTO>
                {
                        new HeadquartersDTO
                        {
                            idheadquarter = 1,
                            Description = "Sede Principal",
                            idCompany = 1,
                            idCity = 1
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 2,
                            Description = "Sede Central",
                            idCompany = 1,
                            idCity = 2
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 3,
                            Description = "Sede Principal",
                            idCompany = 2,
                            idCity = 3
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 4,
                            Description = "Sede Central",
                            idCompany = 2,
                            idCity = 4
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 5,
                            Description = "Sede Principal",
                            idCompany = 3,
                            idCity = 5
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 6,
                            Description = "Sede Central",
                            idCompany = 3,
                            idCity = 6
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 7,
                            Description = "Sede Principal",
                            idCompany = 4,
                            idCity = 7
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 8,
                            Description = "Sede Central",
                            idCompany = 4,
                            idCity = 8
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 9,
                            Description = "Sede Principal",
                            idCompany = 5,
                            idCity = 9
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 10,
                            Description = "Sede Central",
                            idCompany = 5,
                            idCity = 10
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 11,
                            Description = "Sede Principal",
                            idCompany = 6,
                            idCity = 11
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 12,
                            Description = "Sede Central",
                            idCompany = 6,
                            idCity = 12
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 13,
                            Description = "Sede Principal",
                            idCompany = 7,
                            idCity = 13
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 14,
                            Description = "Sede Central",
                            idCompany = 7,
                            idCity = 14
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 15,
                            Description = "Sede Principal",
                            idCompany = 8,
                            idCity = 15
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 16,
                            Description = "Sede Central",
                            idCompany = 8,
                            idCity = 16
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 17,
                            Description = "Sede Principal",
                            idCompany = 9,
                            idCity = 17
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 18,
                            Description = "Sede Central",
                            idCompany = 9,
                            idCity = 18
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 19,
                            Description = "Sede Principal",
                            idCompany = 10,
                            idCity = 19
                        },
                        new HeadquartersDTO
                        {
                            idheadquarter = 20,
                            Description = "Sede Central",
                            idCompany = 10,
                            idCity = 20
                        }

                }
            };
        }
    }
}
