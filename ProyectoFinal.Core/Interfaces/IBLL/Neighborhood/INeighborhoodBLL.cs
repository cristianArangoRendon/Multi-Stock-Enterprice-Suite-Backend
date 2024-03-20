using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Neighborhood
{
    public interface INeighborhoodBLL
    {
        public Task<ResponseDTO> GetNeighborhood(int idCity);
        public Task<ResponseDTO> CreateNeighborhood(string Description, int idCity);
        public Task<ResponseDTO> DeleteNeighborhood(int idNeighborhood);
        public Task<ResponseDTO> GetNeighborhoodById(int idNeighborhood, int idCity);
        public Task<ResponseDTO> UpdateNeighborhoodById(int idNeighborhood, string Description, int idCity);
    }
}
