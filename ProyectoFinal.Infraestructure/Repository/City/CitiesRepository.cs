using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.City;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.City;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.City
{
    public class CitiesRepository : ICitiesRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureServiceService;
        public CitiesRepository(IExecuteStoredProcedureServiceService execute)
        {
            _executeStoredProcedureServiceService = execute;
        }

        public async Task<ResponseDTO> CityById(int idCity)
        {
            var parameters = new
            {
                idCity = idCity
            };
            return await _executeStoredProcedureServiceService.ExecuteSingleObjectStoredProcedure("GetCityById", parameters, MapToObjHelper.MapToObj<CitiesDTO>);
        }

        public async Task<ResponseDTO> CreateCity(string Description)
        {
            var parameters = new
            {
                Description = Description
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.CreateCity", parameters);
        }

        public async Task<ResponseDTO> DeleteCity(int idCity)
        {
            var parameters = new
            {
                idCity = idCity
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.DeleteCity", parameters);
        }

        public async Task<ResponseDTO> GetCities(int idDepartament)
        {
            var parameters = new
            {
                idDepartament = idDepartament
            };

            return await _executeStoredProcedureServiceService.ExecuteDataStoredProcedure("dbo.GetCities", parameters, MapToListHelper.MapToList<CitiesDTO>);
        }

        public async Task<ResponseDTO> UpdateCity(int idCity, string Description)
        {
            var parameters = new
            {
                idCity = idCity,
                Description = Description,
            };

            return await _executeStoredProcedureServiceService.ExecuteStoredProcedure("dbo.UpdateCity", parameters);
        }
    }
}
