using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Brand;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Brand
{
    public  class BrandRepository : IBrandRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureService;
        public BrandRepository(IExecuteStoredProcedureServiceService Service)
        {

            _executeStoredProcedureService = Service;
        }

        public async Task<ResponseDTO> CreateBrandRepository( string Description)
        {
            var parameters = new
            {
                Description = Description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.CreateBrand", parameters);
        }

        public async Task<ResponseDTO> DeleteBrandRepository(int IdBrand)
        {
            var parameters = new
            {
                idBrand = IdBrand
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.DeleteBrand", parameters);
        }

        public async Task<ResponseDTO> GetBrandByIdRepository( int IdBrand)
        {
            var parameters = new
            {
                IdBrand = IdBrand
            };

            return await _executeStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetBrandById", parameters, MapToObjHelper.MapToObj<BrandDTO>);
        }

        public async Task<ResponseDTO> GetBrandsRepository()
        {
            return await _executeStoredProcedureService.ExecuteData("dbo.GetBrands", MapToListHelper.MapToList<BrandDTO>);
        }

        public async Task<ResponseDTO> UpdateBrandRepository(BrandDTO brandDTO)
        {
            var parameters = new
            {
                IdBrand = brandDTO.IdBrand,
                Description = brandDTO.Description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateBrand",parameters);
        }
    }
}
