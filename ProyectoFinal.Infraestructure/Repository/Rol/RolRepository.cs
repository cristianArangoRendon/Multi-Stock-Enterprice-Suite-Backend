using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using ProyectoFinal.Core.Interfaces.IRepository.Rol;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Rol
{
    public class RolRepository : IRolRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureService;

        public RolRepository( IExecuteStoredProcedureServiceService executeStoredProcedureServiceService)  =>  _executeStoredProcedureService = executeStoredProcedureServiceService;
        

        public  async Task<ResponseDTO> CreateRolRepository(string Description)
        {
            var parameters = new
            {
                Description = Description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.CreateRol", parameters);
        }



        public async Task<ResponseDTO> GetRolByIdRepository(int RolId)
        {
            var parameters = new
            {
                idRol = RolId
            };

            return await _executeStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetRolById", parameters, MapToObjHelper.MapToObj<RolDTO>);
        }

 
        public async Task<ResponseDTO> GetRolesRepository() =>  await _executeStoredProcedureService.ExecuteData("dbo.GetRol", MapToListHelper.MapToList<RolDTO>);
        

        public async Task<ResponseDTO> UpdateRolRepository(RolDTO rol)
        {
            var parameters = new
            {
                idRol = rol.IdRol,
                Description = rol.Description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateRol", parameters);
        }
    }
}
