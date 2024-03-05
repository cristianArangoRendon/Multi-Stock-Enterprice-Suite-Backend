using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly IUserBLL _usersBLL;

        public Auth(IUserBLL usersBLL) =>  _usersBLL = usersBLL;
        

        [HttpPost("/Generate/Token")]

        public async Task<ResponseDTO> generateToken(AuthDTO auth) => await _usersBLL.Auth(auth.Email, auth.Password);
    }
}
