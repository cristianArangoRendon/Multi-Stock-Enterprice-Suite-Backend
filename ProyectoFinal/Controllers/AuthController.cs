using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Users;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserBLL _usersBLL;

        public AuthController(IUserBLL usersBLL) =>  _usersBLL = usersBLL;
        


        [HttpPost("Generate/Token")]

        public async Task<ResponseDTO> generateToken(string User, string password) => await _usersBLL.Auth(User, password);




    }
}
