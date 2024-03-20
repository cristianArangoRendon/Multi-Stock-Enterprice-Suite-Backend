using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(typeof(Error401ResponseExample), StatusCodes.Status401Unauthorized)]
    [SwaggerResponseExample(401, typeof(Error401ResponseExample))]
    [SwaggerResponseExample(200, typeof(Response200Example))]
    [ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
    [SwaggerResponseExample(500, typeof(Error500ResponseExample))]
    [ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
    [SwaggerResponseExample(400, typeof(Error400ResponseExample))]

    public class AuthController : ControllerBase
    {
        private readonly IUserBLL _usersBLL;

        public AuthController(IUserBLL usersBLL) => _usersBLL = usersBLL;

        /// <summary>
        /// Generates a token for authentication.
        /// </summary>
        /// <param name="auth">
        ///      Required:
        /// - `Email`: The authentication data containing email.
        /// - `password`: The authentication data containing password.
        /// </param>
        /// <remarks>This endpoint generates a token for authentication based on the provided email and password.</remarks>
        [HttpPost("/Generate/Token")]
        public async Task<IActionResult> GenerateToken(AuthDTO auth)
        {
            var response = await _usersBLL.Auth(auth.Email, auth.Password);
            if (!response.IsSuccess)
                return BadRequest(response);
            return Ok(response);
        }
    }
}
