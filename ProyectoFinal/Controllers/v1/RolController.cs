using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Rol;
using ProyectoFinal.Core.Interfaces.IBLL.Rol;
using ProyectoFinal.ErrorResponse.Doc.Rol;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize]
[SwaggerResponseExample(401, typeof(Error401ResponseExample))]
[ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
[ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
[SwaggerResponseExample(500, typeof(Error500ResponseExample))]
[ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
[SwaggerResponseExample(400, typeof(Error400ResponseExample))]
public class RolController : ControllerBase
{
    private readonly IRolBLL _rolBll;

    public RolController(IRolBLL rolBll)
    {
        _rolBll = rolBll;
    }

    /// <summary>
    /// Retrieves roles.
    /// </summary>
    /// <remarks>
    /// This endpoint retrieves information about roles.
    /// </remarks>
    /// <returns>A response containing information about roles.</returns>

    [HttpGet("/Rol")]
    [SwaggerResponseExample(200, (typeof(GetRolesDoc)))]
    public async Task<IActionResult> GetRoles()
    {
        var response = await _rolBll.GetRolesBLL();
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Retrieves role by its identifier.
    /// </summary>
    /// <param name="idRol">
    /// - `idRol`:The identifier of the role to retrieve.</param>
    /// <remarks>
    /// This endpoint retrieves information about a specific role based on its unique identifier.
    /// </remarks>
    /// <returns>A response containing information about the specified role.</returns>

    [HttpGet("/Rol/By/Id")]
    [SwaggerResponseExample(200, (typeof(GetRolByIdDoc)))]
    public async Task<IActionResult> GetRoleById(int idRol)
    {
        var response = await _rolBll.GetRolByIdBLL(idRol);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Updates role information.
    /// </summary>
    /// <param name="rol">
    /// - `rol`: The data required to update the role.
    /// - `Description`: The updated description of the role.
    /// </param>
    /// <remarks>
    /// This endpoint updates role information based on the provided data, including the updated role description.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the update operation.</returns>
    [HttpPut("/Rol")]
    [SwaggerResponseExample(200, (typeof(UpdateRolDoc)))]
    public async Task<IActionResult> UpdateRol(RolDTO rol)
    {
        var response = await _rolBll.UpdateRolBLL(rol);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Creates a new role.
    /// </summary>
    /// <param name="Description">
    /// - `Description`:The description of the role.</param>
    /// <remarks>This endpoint creates a new role with the provided description.</remarks>
    [HttpPost("/Rol")]
    [SwaggerResponseExample(200, (typeof(CreateRolDoc)))]
    public async Task<IActionResult> CreateRol(string Description)
    {
        var response = await _rolBll.CreateRolBLL(Description);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
}
