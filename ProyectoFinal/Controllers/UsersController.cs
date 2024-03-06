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


        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="UserDTO">- `User`: The data of the user to create.</param>
        /// <remarks>This endpoint creates a new user with the provided data.</remarks>
        [HttpPost("/User")]
        public async Task<ResponseDTO> CreateUser(CreateUserDTO UserDTO)
        {
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());
            UserDTO.idCompany = IdCompany;  
            return await _usersBLL.CreateUser(UserDTO);
        }

        /// <summary>
        /// Deletes a user by its ID.
        /// </summary>
        /// <param name="id">- `id`: The ID of the user to delete.</param>
        /// <remarks>This endpoint deletes a user based on the provided user ID.</remarks>
        [HttpDelete("/User")]
        public async Task<ResponseDTO> DeleteUsuario(int id)
        {
            return await _usersBLL.DeleteUser(id);
        }

        /// <summary>
        /// Retrieves users.
        /// </summary>
 
        [HttpGet("/Users")]
        public async Task<ResponseDTO> GetUsers()
        {
            var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
            int IdCompany = int.Parse(Company.Value.ToString());

            return await _usersBLL.GetUser(IdCompany);
        }

        /// <summary>
        /// Updates a user by its ID.
        /// </summary>
        /// <param name="userDTO">- `userDTO`: The data of the user to be updated.</param>
        /// <remarks>This endpoint updates a user with the provided user data.</remarks>
        [HttpPut("/User")]
        public async Task<ResponseDTO> UpdateUsersById(UsersDTO userDTO)
        {
            return await _usersBLL.UpdateUser(userDTO);
        }

        /// <summary>
        /// Retrieves a user by its ID.
        /// </summary>
        /// <param name="idUser">- `idUser`: The ID of the user to retrieve.</param>
        /// <remarks>This endpoint retrieves a user based on the provided user ID.</remarks>
        [HttpGet("/User/By/Id")]
        public async Task<ResponseDTO> GetUsersById(int idUser)
        {
            return await _usersBLL.IGetUserById(idUser);
        }



    }
}

