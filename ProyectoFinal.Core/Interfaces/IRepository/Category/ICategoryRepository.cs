using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IRepository.Category
{
    public interface ICategoryRepository
    {
        Task<ResponseDTO> GetCategoryRepository();
        Task<ResponseDTO> GetCategoryByIdRepository(int id);
        Task<ResponseDTO> DeleteCategoryRepository(int id);
        Task<ResponseDTO> UpdateCategoryRepository(categoryDTO category);
        Task<ResponseDTO> CreateCategoryRepository(string description);
    }
}
