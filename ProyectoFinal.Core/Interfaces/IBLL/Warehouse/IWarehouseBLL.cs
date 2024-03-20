using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Warehouse
{
    public interface IWarehouseBLL
    {
        public Task<ResponseDTO> GetWarehouse(int idHeadquaters, int idCompany);
        public Task<ResponseDTO> CreateWarehouse(int idHeadquaters, string Description, int idUser, int idCompany);
        public Task<ResponseDTO> DeleteWarehouse(int idWarehouse,int idCompany, int idUser, int idRol);
        public Task<ResponseDTO> UpdateWarehouse(int idWarehouse);
    }
}
