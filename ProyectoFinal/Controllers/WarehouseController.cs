using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.Interfaces.IBLL.Warehouse;
using ProyectoFinal.ErrorResponse.Doc.Warehouse;
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
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseBLL _warehouseBLL;

        public WarehouseController(IWarehouseBLL warehouseBLL)
        {
            _warehouseBLL = warehouseBLL;
        }

        /// <summary>
        /// Retrieves warehouse information by headquarters ID.
        /// </summary>
        /// <param name="idHeadquarter">
        /// - `idHeadquarter`:The identifier of the headquarters to retrieve warehouse information for.</param>
        /// <remarks>
        /// This endpoint retrieves warehouse information based on the provided headquarters ID and company ID.
        /// It requires authorization to ensure that only authorized users can access warehouse information.
        /// </remarks>
        /// <returns>A response containing warehouse information for the specified headquarters.</returns>

        [HttpGet("/Warehouse")]
        [SwaggerResponseExample(200, (typeof(GetWarehouseDoc)))]
        public async Task<IActionResult> GetWarehouse(int idHeadquarter)
        {
            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            var response = await _warehouseBLL.GetWarehouse(idHeadquarter, companyId);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        /// <summary>
        /// Creates a new warehouse.
        /// </summary>
        /// <param name="idHeadquarter">
        /// - `idHeadquarter`:The identifier of the headquarters where the warehouse will be created.</param>
        /// <param name="description">
        /// - `description`:The description of the new warehouse.</param>
        /// <remarks>
        /// This endpoint creates a new warehouse at the specified headquarters with the provided description.
        /// It requires authorization to ensure that only authorized users can create warehouses.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the creation operation.</returns>

        [HttpPost("/Warehouse")]
        [SwaggerResponseExample(200, (typeof(CreateWarehouseDoc)))]
        public async Task<IActionResult> PostWarehouse(int idHeadquarter, string description)
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int userId = int.Parse(userIdClaim.Value);

            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            var response = await _warehouseBLL.CreateWarehouse(idHeadquarter, description, userId, companyId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Deletes a warehouse.
        /// </summary>
        /// <param name="idWarehouse">
        /// - `idWarehouse`:The identifier of the warehouse to delete.</param>
        /// <remarks>
        /// This endpoint deletes the warehouse with the specified identifier. 
        /// It requires authorization to ensure that only authorized users can delete warehouses.
        /// </remarks>
        /// <returns>A response indicating the success or failure of the deletion operation.</returns>

        [HttpDelete("/Warehouse")]
        [SwaggerResponseExample(200, (typeof(DeleteWarehouseDoc)))]
        public async Task<IActionResult> DeleteWarehouse(int idWarehouse)
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            int userId = int.Parse(userIdClaim.Value);

            var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int companyId = int.Parse(companyIdClaim.Value);

            var rolIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idRol");
            int rolId = int.Parse(rolIdClaim.Value);

            var response = await _warehouseBLL.DeleteWarehouse(idWarehouse, companyId, userId, rolId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
