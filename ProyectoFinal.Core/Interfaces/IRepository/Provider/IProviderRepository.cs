using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Provider
{
    public interface IProviderRepository
    {
        Task<ResponseDTO> GetProviderRepository( int idCompany);
        Task<ResponseDTO> CreateProviderRepository(string Description, int idCompany);
        Task<ResponseDTO> UpdateProviderRepository(ProviderUpdateDTO providerDTO);
        Task<ResponseDTO> DeleteProviderRepository(int idProvider, int idCompany);
        Task<ResponseDTO> GetProviderByIdRepository(int provider, int idCompany);
    }
}
