using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.ErrorResponse.Doc.Rol;
using ProyectoFinal.ErrorResponse.Doc.Users;
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

public class UsersController : ControllerBase
{
    private readonly IUserBLL _userBLL;

    public UsersController(IUserBLL userBLL)
    {
        _userBLL = userBLL;
    }

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="userDTO">
    /// - `Names`: The first names of the user.
    /// - `lastNames`: The last names of the user.
    /// - `Email`: The email address of the user.
    /// - `password`: The password for the user account.
    /// - `IdCompany`: The identifier of the company associated with the user.
    /// - `IdRol`: The identifier of the role assigned to the user.
    /// - `Gender`: The gender of the user (e.g., 'M' for male, 'F' for female).
    /// - `Image`: The image URL or path associated with the user (optional).
    /// </param>
    /// <remarks>
    /// This endpoint creates a new user with the provided information, including the user's names, email, password, company affiliation, role assignment, gender, and optionally an image.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the user creation operation.</returns>
    [HttpPost("/User")]
    [SwaggerResponseExample(200, (typeof(CreateUserDoc)))]
    public async Task<IActionResult> CreateUser(CreateUserDTO userDTO)
    {
        var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int companyId = int.Parse(companyIdClaim.Value);
        userDTO.IdCompany = companyId;

        var response = await _userBLL.CreateUser(userDTO);
        if (!response.IsSuccess)
            return BadRequest(response);

        return Ok(response);
    }

    /// <summary>
    /// Deletes a user by its ID.
    /// </summary>
    /// <param name="idUser">
    /// - `idUser`:The ID of the user to delete.</param>
    /// <remarks>This endpoint deletes a user based on the provided user ID.</remarks>
    [HttpDelete("/User")]
    [SwaggerResponseExample(200, (typeof(DeleteUserDoc)))]
    public async Task<IActionResult> DeleteUser(int idUser)
    {
        var response = await _userBLL.DeleteUser(idUser);
        if (!response.IsSuccess)
            return BadRequest(response);

        return Ok(response);
    }

    /// <summary>
    /// Retrieves a list of users belonging to the current company.
    /// </summary>
    /// <remarks>
    /// This endpoint retrieves a list of users associated with the current company based on the company identifier extracted from the user's claims.
    /// </remarks>
    /// <returns>A response containing the list of users belonging to the current company, or an error response if the operation fails.</returns>

    [HttpGet("/Users")]
    [SwaggerResponseExample(200, (typeof(GetUsersDoc)))]
    public async Task<IActionResult> GetUsers()
    {
        var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int companyId = int.Parse(companyIdClaim.Value);

        var response = await _userBLL.GetUser(companyId);
        if (!response.IsSuccess)
            return BadRequest(response);

        return Ok(response);
    }

    /// <summary>
    /// Updates user information by their ID.
    /// </summary>
    /// <param name="userDTO">
    /// - `idUser`: The identifier of the user to update.
    /// - `Names`: The updated names of the user.
    /// - `lastNames`: The updated last names of the user.
    /// - `Email`: The updated email address of the user.
    /// - `password`: The updated password of the user.
    /// - `idRol`: The updated role identifier of the user.
    /// - `IdCompany`: The identifier of the company to which the user belongs.
    /// </param>
    /// <remarks>
    /// This endpoint updates user information based on the provided data, including the user's names, last names, email, password, role, and associated company.
    /// It requires authorization to ensure that only authorized users can update user information.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the update operation.</returns>

    [HttpPut("/User")]
    [SwaggerResponseExample(200, (typeof(UpdateUserDoc)))]
    public async Task<IActionResult> UpdateUserById(UpdateUserDTO userDTO)
    {
        var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int companyId = int.Parse(companyIdClaim.Value);
        userDTO.IdCompany = companyId;

        var response = await _userBLL.UpdateUser(userDTO);
        if (!response.IsSuccess)
            return BadRequest(response);

        return Ok(response);
    }

    /// <summary>
    /// Retrieves a user by its ID.
    /// </summary>
    /// <param name="idUser">
    /// - `idUser`:The ID of the user to retrieve.</param>
    /// <remarks>This endpoint retrieves a user based on the provided user ID.</remarks>
    [HttpGet("/User/By/Id")]
    [SwaggerResponseExample(200, (typeof(GetRolByIdDoc)))]
    public async Task<IActionResult> GetUserById(int idUser)
    {
        var companyIdClaim = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int companyId = int.Parse(companyIdClaim.Value);

        var response = await _userBLL.GetUserById(idUser, companyId);
        if (!response.IsSuccess)
            return BadRequest(response);

        return Ok(response);
    }
}
