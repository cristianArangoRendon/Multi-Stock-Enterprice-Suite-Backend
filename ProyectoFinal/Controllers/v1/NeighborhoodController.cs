using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.Interfaces.IBLL.Neighborhood;
using ProyectoFinal.ErrorResponse.Doc.Neighborhood;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]
    public class NeighborhoodController : ControllerBase
    {
        private readonly INeighborhoodBLL _neighborhood;

        public NeighborhoodController(INeighborhoodBLL neighborhood)
        {
            _neighborhood = neighborhood;
        }

        /// <summary>
        /// Retrieves neighborhoods based on the identifier of the city.
        /// </summary>
        /// <param name="idCity">
        /// - `idCity`:The identifier of the city for which neighborhoods are to be retrieved.</param>
        /// <remarks>
        /// This endpoint retrieves neighborhoods associated with the specified city.
        /// </remarks>
        /// <returns>A response containing the list of neighborhoods.</returns>
        [HttpGet("/Neighborhood")]
        [SwaggerResponseExample(200, (typeof(GetNeighborhoodDoc)))]
        public async Task<IActionResult> GetNeighborhood(int idCity)
        {
            var response = await _neighborhood.GetNeighborhood(idCity);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Creates a new neighborhood.
        /// </summary>
        /// <param name="Description">
        /// - `Description`:The description of the new neighborhood to create.</param>
        /// <param name="idCity">
        /// - `idCity`:The identifier of the city to which the new neighborhood belongs.</param>
        /// <remarks>
        /// This endpoint creates a new neighborhood in the system with the provided description and associates it with the specified city.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>
        [HttpPost("/Neighborhood")]
        [SwaggerResponseExample(200, (typeof(CreateNeighborhoodDoc)))]
        public async Task<IActionResult> CreateNeighborhood(string Description, int idCity)
        {
            var response = await _neighborhood.CreateNeighborhood(Description, idCity);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Deletes a neighborhood by its identifier.
        /// </summary>
        /// <param name="idNeighborhood">
        /// - `idNeighborhood`:The identifier of the neighborhood to delete.</param>
        /// <remarks>
        /// This endpoint deletes a neighborhood from the system based on its unique identifier.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the deletion operation.</returns>

        [HttpDelete("/Neighborhood")]
        [SwaggerResponseExample(200, (typeof(DeleteNeighborhoodDoc)))]
        public async Task<IActionResult> DeleteNeighborhood(int idNeighborhood)
        {
            var response = await _neighborhood.DeleteNeighborhood(idNeighborhood);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Retrieves a neighborhood by its identifier and city.
        /// </summary>
        /// <param name="IdNeighborhood">
        /// - `idNeighborhood`:The identifier of the neighborhood to retrieve.</param>
        /// <param name="idCity">
        /// - `idCity`:The identifier of the city to which the neighborhood belongs.</param>
        /// <remarks>
        /// This endpoint retrieves a neighborhood based on its unique identifier and the specified city.
        /// </remarks>
        /// <returns>A response containing the neighborhood information.</returns>
        [HttpGet("/Neighborhood/ById")]
        [SwaggerResponseExample(200, (typeof(GetNeighborhoodByIdDoc)))]
        public async Task<IActionResult> GetNeighborhoodById(int IdNeighborhood, int idCity)
        {
            var response = await _neighborhood.GetNeighborhoodById(IdNeighborhood, idCity);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Updates a neighborhood by its identifier.
        /// </summary>
        /// <param name="IdNeighborhood">
        ///  - `IdNeighborhood`:The identifier of the neighborhood to update.</param>
        /// <param name="Description">
        ///   - `Description`:The new description for the neighborhood.</param>
        /// <param name="idCity">
        /// - `idCity`:The identifier of the city to which the neighborhood belongs.</param>
        /// <remarks>
        /// This endpoint updates a neighborhood in the system based on its unique identifier and the provided description.
        /// It also associates the neighborhood with the specified city.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the update operation.</returns>
        [HttpPut("/Neighborhood")]
        [SwaggerResponseExample(200, (typeof(UpdateNeighborhoodDoc)))]
        public async Task<IActionResult> UpdateNeighborhoodById(int IdNeighborhood, string Description, int idCity)
        {
            var response = await _neighborhood.UpdateNeighborhoodById(IdNeighborhood, Description, idCity);
            if (response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
