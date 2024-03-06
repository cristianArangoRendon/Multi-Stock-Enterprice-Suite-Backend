using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Category;

namespace ProyectoFinal.Controllers
{
    [Route("api/Category")]
    [ApiController]
    [Authorize]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL _CategoryBll;

        public CategoryController(ICategoryBLL categoryBLL) => _CategoryBll = categoryBLL;

        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <remarks>This endpoint retrieves all categories available in the system.</remarks>
        [HttpGet("/Categories")]
        public async Task<ResponseDTO> GetCategory() => await _CategoryBll.GetCategoryBLL();

        /// <summary>
        /// Creates a new category.
        /// </summary>
        /// <param name="category"> - `category`: The name of the category to create.</param>
        /// <remarks>This endpoint creates a new category with the provided name.</remarks>
        [HttpPost("/Category")]
        public async Task<ResponseDTO> CreateCategory(string category) => await _CategoryBll.CreateCategoryBLL(category);

        /// <summary>
        /// Deletes a category by its ID.
        /// </summary>
        /// <param name="idCategory">  - `idCategory`:The ID of the category to delete.</param>
        /// <remarks>This endpoint deletes a category based on the provided category ID.</remarks>
        [HttpDelete("/Category")]
        public async Task<ResponseDTO> DeleteCategory(int idCategory) => await _CategoryBll.DeleteCategoryBLL(idCategory);

        /// <summary>
        /// Retrieves a category by its ID.
        /// </summary>
        /// <param name="idCategory">- `idCategory`: The ID of the category to retrieve.</param>
        /// <remarks>This endpoint retrieves a category based on the provided category ID.</remarks>
        [HttpGet("/Category/By/Id")]
        public async Task<ResponseDTO> GetCategoryById(int idCategory) => await _CategoryBll.GetCategoryByIdBLL(idCategory);

        /// <summary>
        /// Updates a category.
        /// </summary>
        /// <param name="category">
        ///      Required:  
        /// - `IdCategory`: The data of the category to be updated.
        /// - `Description`:  The description of the category.
        /// </param>
        /// <remarks>This endpoint updates a category with the provided category data.</remarks>
        [HttpPut("/Category")]
        public async Task<ResponseDTO> UpdateCategory(categoryDTO category) => await _CategoryBll.UpdateCategoryBLL(category);




    }
}
