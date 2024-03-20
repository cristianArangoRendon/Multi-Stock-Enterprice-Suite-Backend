using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.City
{
    public interface ICitiesRepository
    {
        public Task<ResponseDTO> GetCities();
        public Task<ResponseDTO> CityById(int idCity);
        public Task<ResponseDTO> DeleteCity(int idCity);
        public Task<ResponseDTO> UpdateCity(int idCity, string Description);
        public Task<ResponseDTO> CreateCity(string Description);

    }
}
