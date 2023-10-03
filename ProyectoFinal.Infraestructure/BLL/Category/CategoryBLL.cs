using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using ProyectoFinal.Core.Interfaces.IRepository.Category;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL CreateCategoryBLL: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL DeleteCategoryRepository: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL GetCategoryBLL: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL GetCategoryByIdBLL: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
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
                _LogService.SaveLogsMessages("Se ha producido un error al ejecutar el BLL UpdateCategoryBLL: " + ex.Message);
                respuesta.Message += ex.ToString();
                return respuesta;
            }
        }
    }
}
