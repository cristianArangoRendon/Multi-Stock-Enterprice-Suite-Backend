using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Provider;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Provider
{
    public class ProviderRepository : IProviderRepository
    {

        private readonly IExecuteStoredProcedureServiceService _ExecuteStoredProcedureService;

        public ProviderRepository(IExecuteStoredProcedureServiceService execute) => _ExecuteStoredProcedureService = execute;


        public async Task<ResponseDTO> CreateProviderRepository(string Description)
        {
            var parameters = new
            {
                Description = Description
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.CreateProvider", parameters);
        }

        public async Task<ResponseDTO> DeleteProviderRepository(int idProvider)
        {

            var parameters = new
            {
                idProvider = idProvider
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.DeleteProvider", parameters);
        }

        public async Task<ResponseDTO> GetProviderByIdRepository(int idProvider)
        {

            var parameters = new
            {
                idProvider = idProvider
            };

            return await _ExecuteStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetProviderById", parameters, MapToObjHelper.MapToObj<ProviderDTO>);
        }



        public async Task<ResponseDTO> GetProviderRepository()
        {
           return await _ExecuteStoredProcedureService.ExecuteData("dbo.GetProvider", MapToListHelper.MapToList<ProviderDTO>);
        }
            
       
        




        public async Task<ResponseDTO> UpdateProviderRepository(ProviderDTO providerDTO)
        {
            var parameters = new
            {
                idProvider = providerDTO.idProvider,
                Description = providerDTO.Description
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateProvider", parameters);
        }
    }
}
