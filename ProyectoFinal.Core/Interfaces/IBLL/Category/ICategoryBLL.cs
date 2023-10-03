using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;

namespace ProyectoFinal.Core.Interfaces.IBLL.Category
{
    public interface ICategoryBLL
    {
        Task<ResponseDTO> GetCategoryBLL();
        Task<ResponseDTO> GetCategoryByIdBLL(int id);
        Task<ResponseDTO> DeleteCategoryBLL(int idCategory);
        Task<ResponseDTO> UpdateCategoryBLL(categoryDTO category);
        Task<ResponseDTO> CreateCategoryBLL(string categori);
    }
}
