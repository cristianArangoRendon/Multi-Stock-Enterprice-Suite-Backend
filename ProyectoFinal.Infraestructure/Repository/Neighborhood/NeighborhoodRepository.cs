using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.DTOs.Neighborhood;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.neighborhood;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.neighborhood
{
    public class NeighborhoodRepository : INeighborhoodRepository
    {

        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureServiceService;
        public NeighborhoodRepository(IExecuteStoredProcedureServiceService service)
        {
            _executeStoredProcedureServiceService = service;
        }

        public async Task<ResponseDTO> CreateNeighborhood(string Description, int idCity)
        {
            var parameters = new
            {
                Description = Description,
                idCity = idCity,
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("CreateNeighborhood", parameters);
        }

        public async Task<ResponseDTO> DeleteNeighborhood(int idNeighborhood)
        {
            var parameters = new
            {
                idNeighborhood = idNeighborhood,
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("DeleteNeighborhood", parameters);
        }

        public async Task<ResponseDTO> GetNeighborhood(int idCity)
        {

            var parameters = new
            {
                idCity = idCity,
            };

            return await _executeStoredProcedureServiceService.ExecuteDataStoredProcedure("GetNeighborhood", parameters, MapToListHelper.MapToList<NeighborhoodDTO>);
        }

        public async Task<ResponseDTO> GetNeighborhoodById(int idNeighborhood, int idCity)
        {
            var parameters = new
            {
                idNeighborhood = idNeighborhood,
                idCity = idCity,
            };

            return await _executeStoredProcedureServiceService.ExecuteDataStoredProcedure("GetNeighborhoodById", parameters, MapToListHelper.MapToList<NeighborhoodDTO>);
        }

        public async Task<ResponseDTO> UpdateNeighborhoodById(int idNeighborhood,string Description, int idCity)
        {
            var parameters = new
            {
                idNeighborhood = idNeighborhood,
                Description = Description,
                idCity = idCity
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("UpdateNeighborhood", parameters);
        }
    }
}
