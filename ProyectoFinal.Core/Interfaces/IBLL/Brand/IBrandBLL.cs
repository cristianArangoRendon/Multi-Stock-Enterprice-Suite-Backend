using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Brand
{
    public interface IBrandBLL
    {
        Task<ResponseDTO> GetBrandsBLL();
        Task<ResponseDTO> GetBrandByIdBLL(int IdBrand);
        Task<ResponseDTO> CreateBrandBLL(string Description);
        Task<ResponseDTO> DeleteBrandBLL(int IdBrand);
        Task<ResponseDTO> UpdateBrandBLL( BrandDTO brandDTO  );

    }
}
