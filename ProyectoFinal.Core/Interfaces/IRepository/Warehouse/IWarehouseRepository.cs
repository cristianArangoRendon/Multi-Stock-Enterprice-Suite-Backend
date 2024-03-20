using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Warehouse;

namespace ProyectoFinal.Core.Interfaces.IRepository.Warehouse
{
    public interface IWarehouseRepository
    {
        public Task<ResponseDTO> GetWarehouse(int idHeadquaters, int idCompany);
        public Task<ResponseDTO> CreateWarehouse(int idHeadquaters, string Description, int idUser, int idCompany);
        public Task<ResponseDTO> DeleteWarehouse(int idWarehouse, int idCompany, int idUser);
        public Task<ResponseDTO> UpdateWarehouse(int idWarehouse);
    }
}
