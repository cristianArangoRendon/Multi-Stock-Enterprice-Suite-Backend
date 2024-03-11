using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Provider
{
    public interface IProviderBLL
    {
        Task<ResponseDTO> GetProviderBLL(int IdCompany);
        Task<ResponseDTO> CreateProviderBLL(string Description, int idCompany);
        Task<ResponseDTO> UpdateProviderBLL(ProviderUpdateDTO providerDTO );
        Task<ResponseDTO> DeleteProviderBLL(int idProvider, int idCompany);
        Task<ResponseDTO> GetProviderByIdBLL(int idProvider, int idCompany);
    }
}
