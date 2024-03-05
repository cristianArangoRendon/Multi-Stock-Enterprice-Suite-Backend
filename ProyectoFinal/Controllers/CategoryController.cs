using ActiveDirectoryBack.SwaggerExamples.ErrorResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/Category")]
    [ApiController]
    [Authorize]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL _CategoryBll;

        public CategoryController(ICategoryBLL categoryBLL) => _CategoryBll = categoryBLL;


        [HttpGet("/Categories")]
        public async Task<ResponseDTO> GetCategory( ) => await _CategoryBll.GetCategoryBLL();
        

        [HttpPost("/Category")]
        public async Task<ResponseDTO>  CreateCategory(string categori) =>  await _CategoryBll.CreateCategoryBLL(categori);
        

        [HttpDelete("/Category")]
        public async Task<ResponseDTO> DeleteCategory(int idCategory) =>  await _CategoryBll.DeleteCategoryBLL(idCategory);
        

        [HttpGet("/Category/By/Id")]
        public async Task<ResponseDTO> GetCategoryById(int idCategory) => await _CategoryBll.GetCategoryByIdBLL(idCategory);
        


        [HttpPut("/Category")]
        public async Task<ResponseDTO> UpdateCategory(categoryDTO category) => await _CategoryBll.UpdateCategoryBLL(category);
        


    }
}
