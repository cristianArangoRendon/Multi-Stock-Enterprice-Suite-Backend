using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;
using ProyectoFinal.ErrorResponse.Doc.Bill;
using ProyectoFinal.ErrorResponse.Doc.Brand;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]
    public class BrandController : ControllerBase
    {
        private readonly IBrandBLL _BrandBLL;

        public BrandController(IBrandBLL brandBLL)
        {
            _BrandBLL = brandBLL;
        }

        /// <summary>
        /// Creates a new brand.
        /// </summary>
        /// <param name="Description">
        ///      Required:
        ///  - `Description`: The description of the brand to create.
        /// </param>
        /// <remarks>This endpoint creates a new brand with the provided description.</remarks>
        [HttpPost("/Brand")]
        [SwaggerResponseExample(200, (typeof(CreateBrandDoc)))]
        public async Task<IActionResult> CreateBrand(string Description)
        {
            var response = await _BrandBLL.CreateBrandBLL(Description);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }
    
        /// <summary>
        /// Retrieves all brands.
        /// </summary>
        /// <remarks>This endpoint retrieves all brands.</remarks>
        [HttpGet("/Brands")]
        [SwaggerResponseExample(200, (typeof(GetBrandDoc)))]
        public async Task<IActionResult> GetBrand()
        {
            var response = await _BrandBLL.GetBrandsBLL();
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Retrieves a brand by its ID.
        /// </summary>
        /// <param name="IdBrand">
        /// - `IdBrand`:The ID of the brand to retrieve.
        /// </param>
        /// <remarks>This endpoint retrieves a brand based on the provided ID.</remarks>
        [HttpGet("/Brand/By/Id")]
        [SwaggerResponseExample(200, (typeof(GetBrandByIdDoc)))]
        public async Task<IActionResult> GetBrandById(int IdBrand)
        {
            var response = await _BrandBLL.GetBrandByIdBLL(IdBrand);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Deletes a brand by its ID.
        /// </summary>
        /// <param name="IdBrand">
        /// - `IdBrand`:The ID of the brand to delete.</param>
        /// <remarks>This endpoint deletes a brand based on the provided ID.</remarks>
        [HttpDelete("/Brand")]
        [SwaggerResponseExample(200, (typeof(DeleteBrandDoc)))]
        public async Task<IActionResult> DeleteBrand(int IdBrand)
        {
            var response = await _BrandBLL.DeleteBrandBLL(IdBrand);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }

        /// <summary>
        /// Updates a brand.
        /// </summary>
        /// <param name="brandDTO">
        /// - `IdBrand`: Represents the identifier of the brand.
        /// - `Description`: Represents the description of the brand.
        /// </param>
        /// <remarks>This endpoint updates a brand with the provided data.</remarks>
        [HttpPut("/Brand")]
        [SwaggerResponseExample(200, (typeof(UpdateBrandDoc)))]
        public async Task<IActionResult> UpdateBrand(BrandDTO brandDTO)
        {
            var response = await _BrandBLL.UpdateBrandBLL(brandDTO);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }
    }
}
