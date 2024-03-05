using ActiveDirectoryBack.Infrastructure.Helpers;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
using ProyectoFinal.Core.Interfaces.IServices;

namespace ProyectoFinal.Infraestructure.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IExecuteStoredProcedureServiceService _executeStoredProcedureService;
        public CategoryRepository(IExecuteStoredProcedureServiceService executeStoredProcedureService)
        {
            _executeStoredProcedureService = executeStoredProcedureService;
        }

        public async Task<ResponseDTO> CreateCategoryRepository(string description)
        {
            var parameters = new
            {
                Description = description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.CreateCategory", parameters);
        }

        public async Task<ResponseDTO> DeleteCategoryRepository(int idCategory)
        {
            var parameters = new
            {
                idCategory = idCategory
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.DeleteCategory", parameters);
        }

        public async Task<ResponseDTO> GetCategoryByIdRepository(int idCategory)
        {

            var parameters = new
            {
                IdCategory = idCategory
            };

            return await _executeStoredProcedureService.ExecuteSingleObjectStoredProcedure("dbo.GetCategoryById", parameters, MapToObjHelper.MapToObj<categoryDTO>);
        }

        public async Task<ResponseDTO> GetCategoryRepository()
        {
            return await _executeStoredProcedureService.ExecuteData("dbo.GetCategory", MapToListHelper.MapToList<categoryDTO>);
        }

        public async Task<ResponseDTO> UpdateCategoryRepository(categoryDTO idCategory)
        {
            var parameters = new
            {
                idCategory = idCategory.IdCategory,
                Description = idCategory.Description
            };

            return await _executeStoredProcedureService.ExecuteStoredProcedure("dbo.UpdateCategory", parameters);
        }

    }
}

