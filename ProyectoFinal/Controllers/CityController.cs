using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.Interfaces.IBLL.City;
using ProyectoFinal.ErrorResponse.Doc.Cities;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [SwaggerResponseExample(401, (typeof(Error401ResponseExample)))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, (typeof(Error500ResponseExample)))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, (typeof(Error400ResponseExample)))]
    public class CityController : ControllerBase
    {
        private readonly ICitiesBLL _CitiesBLL;
        public CityController(ICitiesBLL citiesBLL)
        {
            _CitiesBLL = citiesBLL;
        }

        /// <summary>
        /// Retrieves a list of cities.
        /// </summary>
        /// <remarks>This endpoint retrieves a list of cities available in the system.</remarks>
        /// <returns>A list of cities.</returns>
        [HttpGet("/Cities")]
        [SwaggerResponseExample(200, (typeof(GetCitiesDoc)))]
        public async Task<IActionResult> GetCities()
        {
            var response = await _CitiesBLL.GetCities();
            if (!response.IsSuccess)
            {
                BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Retrieves a city by its identifier.
        /// </summary>
        /// <param name="idCity">
        /// - `idCity`: The unique identifier of the city to retrieve.
        /// </param>
        /// <remarks>This endpoint retrieves a city from the system based on its unique identifier.</remarks>
        /// <returns>The city with the specified identifier.</returns>
        [HttpGet("/City/ById")]
        [SwaggerResponseExample(200, (typeof(GetCityByIdDoc)))]
        public async Task<IActionResult> GetCityById(int idCity)
        {
            var response = await _CitiesBLL.CityById(idCity);
            if (!response.IsSuccess)
            {
                BadRequest(response);
            }
            return Ok(response);
        }



        /// <summary>
        /// Deletes a city by its identifier.
        /// </summary>
        /// <param name="idCity">
        /// - `idCity`: The unique identifier of the city to delete.
        /// </param>
        /// <remarks>This endpoint deletes a city from the system based on its unique identifier.</remarks>
        /// <returns>A response indicating the success or failure of the deletion operation.</returns>
        [HttpDelete("/City")]
        [SwaggerResponseExample(200, (typeof(DeleteCityDoc)))]
        public async Task<IActionResult> DeleteCity(int idCity)
        {
            var response = await _CitiesBLL.DeleteCity(idCity);
            if (!response.IsSuccess)
            {
                BadRequest(response);
            }
            return Ok(response);
        }



        /// <summary>
        /// Updates a city.
        /// </summary>
        /// <param name="idCity">
        /// - `idCity`: The unique identifier of the city to update.
        /// </param>
        /// <param name="Description">
        /// - `Description`: The new description for the city.
        /// </param>
        /// <remarks>This endpoint updates a city in the system based on its unique identifier and the provided description.</remarks>
        /// <returns>A response indicating the success or failure of the update operation.</returns>
        [HttpPut("/City")]
        [SwaggerResponseExample(200, (typeof(UpdateCityDoc)))]
        public async Task<IActionResult> UpdateCity(int idCity, string Description)
        {
            var response = await _CitiesBLL.UpdateCity(idCity, Description);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }



        /// <summary>
        /// Creates a new city.
        /// </summary>
        /// <param name="Description">
        /// - `Description`: The description of the new city to create.
        /// </param>
        /// <remarks>This endpoint creates a new city in the system with the provided description.</remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>
        [HttpPost("/City")]
        [SwaggerResponseExample(200, (typeof(CreateCityDoc)))]
        public async Task<IActionResult> CreateCity(string Description)
        {
            var response = await _CitiesBLL.CreateCity(Description);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
