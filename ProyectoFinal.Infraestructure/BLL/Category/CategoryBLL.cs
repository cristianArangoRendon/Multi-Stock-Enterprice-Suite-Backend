using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
using ProyectoFinal.Infraestructure.Helpers;
using ProyectoFinal.Infraestructure.Services.LogService;

namespace ProyectoFinal.Infraestructure.BLL.Category
{
    public class CategoryBLL : ICategoryBLL
    {
        private readonly ICategoryRepository _CategoryRepository;
        private readonly ILogService _LogService;

        public CategoryBLL(ICategoryRepository categoryRepository,ILogService logService)
        {
            _CategoryRepository = categoryRepository;
            _LogService = logService;
        }

        public async Task<ResponseDTO> CreateCategoryBLL(string description)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _CategoryRepository.CreateCategoryRepository(description); 
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> DeleteCategoryBLL(int idCategory)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _CategoryRepository.DeleteCategoryRepository(idCategory); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetCategoryBLL()
        { 
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _CategoryRepository.GetCategoryRepository(); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> GetCategoryByIdBLL(int idCategory)
        {
            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _CategoryRepository.GetCategoryByIdRepository(idCategory); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public async Task<ResponseDTO> UpdateCategoryBLL(categoryDTO Category)
        {

            ResponseDTO respuesta = new ResponseDTO();
            respuesta.IsSuccess = false;

            try
            {
                return await _CategoryRepository.UpdateCategoryRepository(Category); ;
            }
            catch (Exception ex)
            {
                return ExceptionHelper.HandleException(_LogService, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }
}
