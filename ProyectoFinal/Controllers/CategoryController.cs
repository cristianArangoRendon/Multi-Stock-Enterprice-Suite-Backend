using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.category;
using ProyectoFinal.Core.Interfaces.IBLL.Category;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/Category")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBLL _categoryBll;

        public CategoryController(ICategoryBLL categoryBLL) => _categoryBll = categoryBLL;

        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <remarks>This endpoint retrieves all categories available in the system.</remarks>
        [HttpGet("/Categories")]
        public async Task<IActionResult> GetCategory()
        {
            var response = await _categoryBll.GetCategoryBLL();
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Creates a new category.
        /// </summary>
        /// <param name="category">
        /// - `category`:The name of the category to create.</param>
        /// <remarks>This endpoint creates a new category with the provided name.</remarks>
        [HttpPost("/Category")]
        public async Task<IActionResult> CreateCategory(string category)
        {
            var response = await _categoryBll.CreateCategoryBLL(category);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Deletes a category by its ID.
        /// </summary>
        /// <param name="idCategory">
        /// - `idCategory`:The ID of the category to delete.</param>
        /// <remarks>This endpoint deletes a category based on the provided category ID.</remarks>
        [HttpDelete("/Category")]
        public async Task<IActionResult> DeleteCategory(int idCategory)
        {
            var response = await _categoryBll.DeleteCategoryBLL(idCategory);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Retrieves a category by its ID.
        /// </summary>
        /// <param name="idCategory">
        /// - `idCategory`:The ID of the category to retrieve.
        ///</param>
        /// <remarks>This endpoint retrieves a category based on the provided category ID.</remarks>
        [HttpGet("/Category/By/Id")]
        public async Task<IActionResult> GetCategoryById(int idCategory)
        {
            var response = await _categoryBll.GetCategoryByIdBLL(idCategory);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Updates a category.
        /// </summary>
        /// <param name="category">
        /// - `idCategory`: Represents the identifier of the category.
        /// - `Description`: Represents the description of the category.
        /// </param>
        /// <remarks>This endpoint updates a category with the provided category data.</remarks>
        [HttpPut("/Category")]
        public async Task<IActionResult> UpdateCategory(categoryDTO category)
        {
            var response = await _categoryBll.UpdateCategoryBLL(category);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }
    }
}
