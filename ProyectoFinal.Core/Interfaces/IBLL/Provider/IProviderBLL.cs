using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Provider
{
    public interface IProviderBLL
    {
        Task<ResponseDTO> GetProviderBLL( );
        Task<ResponseDTO> CreateProviderBLL(string Description, int idCompany);
        Task<ResponseDTO> UpdateProviderBLL(ProviderDTO providerDTO );
        Task<ResponseDTO> DeleteProviderBLL(int idProvider);
        Task<ResponseDTO> GetProviderByIdBLL(int idProvider);
    }
}
