using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Headquarters;
using ProyectoFinal.Core.Interfaces.IBLL.Headquarter;
using ProyectoFinal.ErrorResponse.Doc.Headquarters;
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
    public class HeadquartersController : ControllerBase
    {
        private readonly IHeadquarterBLL _headquarters;

        public HeadquartersController(IHeadquarterBLL headquarters)
        {
            _headquarters = headquarters;
        }
        /// <summary>
        /// Retrieves headquarters information.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves headquarters information associated with the current company.
        /// It requires authorization to determine the company associated with the retrieval operation.
        /// </remarks>
        /// <returns>A response containing headquarters information.</returns>
        [HttpGet("/Headquarters")]
        [SwaggerResponseExample(200, (typeof(GetHeadquartersDoc)))]
        public async Task<IActionResult> GetHeadquarters()
        {
            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            var response = await _headquarters.GetHeadquaters(companyId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Creates a new headquarters.
        /// </summary>
        /// <param name="create">
        /// - `description`: The description of the new headquarters.
        /// - `idCompany`: The identifier of the company associated with the headquarters.
        /// - `idCity`: The identifier of the city where the headquarters is located.
        /// - `idUser`: The identifier of the user creating the headquarters.
        /// </param>
        /// <remarks>
        /// This endpoint creates a new headquarters with the provided data. 
        /// It requires authorization to determine the user and company associated with the creation operation.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>

        [HttpPost("/Headquarters")]
        [SwaggerResponseExample(200, (typeof(CreateHeadquartersDoc)))]
        public async Task<IActionResult> CreateHeadquarters(CreateHeadquartersDTO create)
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int userId = int.Parse(userIdClaim.Value);

            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            create.idCompany = companyId;
            create.idUser = userId;

            var response = await _headquarters.CreateHeadquaters(create);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }



        /// <summary>
        /// Updates headquarters information.
        /// </summary>
        /// <param name="update">
        /// - `idHeadquarter`: The identifier of the headquarters.
        /// - `Description`: The description of the headquarters.
        /// - `idCompany`: The identifier of the company associated with the headquarters.
        /// - `idCity`: The identifier of the city where the headquarters is located.
        /// - `idUser`: The identifier of the user updating the headquarters.
        /// </param>
        /// <remarks>
        /// This endpoint updates headquarters information based on the provided data.
        /// It requires authorization to determine the user and company associated with the update operation.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the update operation.</returns>
        [HttpPut("/Headquarters")]
        [SwaggerResponseExample(200, (typeof(UpdateHeadquartersDoc)))]
        public async Task<IActionResult> UpdateHeadquarters(UpdateHeadquarters update)
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int userId = int.Parse(userIdClaim.Value);

            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            update.idCompany = companyId;
            update.idUser = userId;

            var response = await _headquarters.UpdateHeadquaters(update);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
