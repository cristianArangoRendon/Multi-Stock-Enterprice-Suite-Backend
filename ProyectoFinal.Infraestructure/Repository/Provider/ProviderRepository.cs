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


        public async Task<ResponseDTO> CreateProviderRepository(string Description, int idCompany)
        {
            var parameters = new
            {
                Description = Description,
                IdCompany = idCompany
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.CreateProvider", parameters);
        }

        public async Task<ResponseDTO> DeleteProviderRepository(int idProvider, int idCompany)
        {

            var parameters = new
            {
                idProvider = idProvider,
                idCompany = idCompany
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.DeleteProvider", parameters);
        }

        public async Task<ResponseDTO> GetProviderByIdRepository(int idProvider, int idCompany)
        {

            var parameters = new
            {
                idProvider = idProvider,
                idCompany = idCompany
            };

            return await _ExecuteStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetProviderById", parameters, MapToObjHelper.MapToObj<ProviderDTO>);
        }



        public async Task<ResponseDTO> GetProviderRepository(int idCompany)
        {
            var parameters = new
            {
                idCompany = idCompany
            };

            return await _ExecuteStoredProcedureService.ExecuteDataStoredProcedure("dbo.GetProvider", parameters,MapToListHelper.MapToList<ProviderDTO>);
        }
            
       
        




        public async Task<ResponseDTO> UpdateProviderRepository(ProviderUpdateDTO providerDTO)
        {
            var parameters = new
            {
                idProvider = providerDTO.idProvider,
                Description = providerDTO.Description,
                idCompany = providerDTO.idCompany,
            };

            return await _ExecuteStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateProvider", parameters);
        }
    }
}
