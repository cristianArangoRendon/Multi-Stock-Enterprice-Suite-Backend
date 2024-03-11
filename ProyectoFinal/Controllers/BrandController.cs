using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BrandController : ControllerBase
    {


        private readonly IBrandBLL _BrandBLL;
     
        public BrandController(IBrandBLL brandBLL) => _BrandBLL = brandBLL;



        /// <summary>
        /// Creates a new brand.
        /// </summary>
        /// <param name="Description">
        ///     Required: 
        /// - `Description`: This endpoint creates a new brand with the provided description..
        /// </param>
        [HttpPost("/Brand")]
        public async Task<ResponseDTO> CreateBrand(string Description) => await _BrandBLL.CreateBrandBLL(Description);


        /// <summary>
        /// Retrieves all brands.
        /// </summary>
        /// <remarks>
        /// This endPoint does not require parameters.
        /// </remarks>
        [HttpGet("/Brands")]
        public async Task<ResponseDTO> GetBrand() => await _BrandBLL.GetBrandsBLL();





        /// <summary>
        /// Retrieves a brand by its ID.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a brand based on the provided brand ID.
        /// </remarks>
        /// <param name="IdBrand">
        ///       Required: 
        ///   - `IdBrand`:   The ID of the brand to retrieve.
        /// </param>
        [HttpGet("/Brand/By/Id")]
        public async Task<ResponseDTO> GetBrandById(int IdBrand) => await _BrandBLL.GetBrandByIdBLL(IdBrand);




        /// <summary>
        /// Deletes a brand by its ID.
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a brand based on the provided brand ID.
        /// </remarks>
        /// <param name="IdBrand">
        ///        Required:
        ///   - `IdBrand`:   The ID of the brand to retrieve.
        /// </param>
        [HttpDelete("/Brand")]
        public async Task<ResponseDTO> DeleteBrand(int IdBrand) => await _BrandBLL.DeleteBrandBLL(IdBrand);




        /// <summary>
        /// Updates a brand.
        /// </summary>
        /// <remarks>
        /// This endpoint updates a brand with the provided brand data.
        /// </remarks>
        /// <param name="brandDTO">
        ///         Required: 
        ///   - `IdBrand`:   The ID of the brand to retrieve.
        ///   - `Description`:   The description of the brand.
        /// </param>
        [HttpPut("/Brand")]
        public async Task<ResponseDTO> UpdateBrand(BrandDTO brandDTO) => await _BrandBLL.UpdateBrandBLL(brandDTO);

    }
}
