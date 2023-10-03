using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Provider
{
    public interface IProviderRepository
    {
        Task<ResponseDTO> GetProviderRepository();
        Task<ResponseDTO> CreateProviderRepository(string Description);
        Task<ResponseDTO> UpdateProviderRepository(ProviderDTO providerDTO);
        Task<ResponseDTO> DeleteProviderRepository(int idProvider);
        Task<ResponseDTO> GetProviderByIdRepository(int provider);
    }
}
