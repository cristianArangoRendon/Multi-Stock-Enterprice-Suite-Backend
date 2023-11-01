using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Brand
{
    public interface IBrandRepository
    {
        Task<ResponseDTO> GetBrandsRepository();
        Task<ResponseDTO> GetBrandByIdRepository(int IdBrand);
        Task<ResponseDTO> CreateBrandRepository(string Description);
        Task<ResponseDTO> DeleteBrandRepository(int IdBrand);
        Task<ResponseDTO> UpdateBrandRepository(BrandDTO brandDTO);
    }
}
