using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Headquarter;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.Helpers;

namespace ProyectoFinal.Infraestructure.Repository.Headquarters
{
    public class HeadquartersRepository : IHeadquarterRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureService;
        public HeadquartersRepository(IExecuteStoredProcedureServiceService executeStoredProcedureService)
        {
            _executeStoredProcedureService = executeStoredProcedureService;
        }
        public async Task<ResponseDTO> CreateHeadquaters(CreateHeadquartersDTO create)
        {
            object obj = create.ToObject<CreateHeadquartersDTO>();
            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.CreateHeadquaters", obj);
        }

        public async Task<ResponseDTO> GetHeadquaters( int idCompany)
        {
            var parameters = new
            {
                idCompany = idCompany
            };

            return await _executeStoredProcedureService.ExecuteDataStoredProcedure("GetHeadquarters", parameters, MapToListHelper.MapToList<HeadquartersDTO>);
        }

        public async Task<ResponseDTO> UpdateHeadquaters(UpdateHeadquarters updateHeadquarters)
        {
            object obj = updateHeadquarters.ToObject<UpdateHeadquarters>();
            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateHeadquarters", obj);
        }
    }
}
