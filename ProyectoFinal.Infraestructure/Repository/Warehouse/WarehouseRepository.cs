using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Warehouse;
using ProyectoFinal.Core.Interfaces.IRepository.Warehouse;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Warehouse
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoreService;
        public WarehouseRepository(IExecuteStoredProcedureServiceService executeStoreService)
        {
            _executeStoreService = executeStoreService;
        }

        public async Task<ResponseDTO> CreateWarehouse(int idHeadquaters, string Description, int idUser, int idCompany)
        {
            var parameters = new
            {
                idHeadquarter = idHeadquaters,
                Description = Description,
                idUser = idUser,
                idCompany = idCompany
            };

            return await _executeStoreService.ExecuteStoredProcedure("dbo.CreateWarehouse", parameters);
        }

        public async Task<ResponseDTO> DeleteWarehouse(int idWarehouse, int idCompany, int idUser)
        {
            var parameters = new
            {
                idWarehouse = idWarehouse,
                idCompany = idCompany,
                idUser = idUser
            };

            return await _executeStoreService.ExecuteStoredProcedure("dbo.DeleteWarehouse", parameters);
        }

        public async Task<ResponseDTO> GetWarehouse(int idHeadquaters, int idCompany)
        {
            var parameters = new
            {
                idHeadquarter = idHeadquaters,
                idCompany = idCompany
            };

            return await _executeStoreService.ExecuteDataStoredProcedure("dbo.GetWarehouse", parameters, MapToListHelper.MapToList<WarehouseDTO>);
        }

        public Task<ResponseDTO> UpdateWarehouse(int idWarehouse)
        {
            throw new NotImplementedException();
        }
    }
}
