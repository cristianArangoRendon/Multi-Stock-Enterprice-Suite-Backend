using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;
using ProyectoFinal.Core.Interfaces.IBLL.Users;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBLL _usersBLL;
        public UsersController(IUserBLL users) =>_usersBLL = users;
        


        
        [HttpPost("Create/Users")]  
        public async Task<ResponseDTO> CreateUser(UsersDTO User)
        {
            return await _usersBLL.CreateUsuario(User);
        }


        [HttpDelete("/Delete/User")]
        public async Task<ResponseDTO> DeleteUsuario(int id)
        {
            return await _usersBLL.DeleteUser(id);

        }


        [HttpGet("/Get/Users")]
        public async Task<ResponseDTO> GetUsers(int idRol)
        {
            return await _usersBLL.GetUser(idRol);
        }



        [HttpPut("/Update/Users")]
        public async Task<ResponseDTO> UpdateUsersById(UsersDTO userDTO )
        {
            return await _usersBLL.UpdateUser(userDTO);
        }


        [HttpGet("/Get/Users/By/Id")]
        public async Task<ResponseDTO> GetUsersById(int idUser)
        {
            return await _usersBLL.IGetUserById(idUser);
        }


    }
}

