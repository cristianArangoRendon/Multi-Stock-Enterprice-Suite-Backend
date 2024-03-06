using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;
using ProyectoFinal.Core.Interfaces.IBLL.Rol;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolController : ControllerBase
    {
        private readonly IRolBLL _RolBll;
        public RolController(IRolBLL rolBll)  =>   _RolBll = rolBll;


        /// <summary>
        /// Retrieves all roles.
        /// </summary>
        /// <remarks>This endpoint retrieves all roles available in the system.</remarks>
        [HttpGet("/Rol")]
        public async Task<ResponseDTO> GetRoles() => await _RolBll.GetRolesBLL();

        /// <summary>
        /// Retrieves a role by its ID.
        /// </summary>
        /// <param name="idRol">- `idRol`: The ID of the role to retrieve.</param>
        /// <remarks>This endpoint retrieves a role based on the provided role ID.</remarks>
        [HttpGet("/Rol/By/Id")]
        public async Task<ResponseDTO> GetRoles(int idRol) => await _RolBll.GetRolByIdBLL(idRol);

        /// <summary>
        /// Updates a role.
        /// </summary>
        /// <param name="rol">
        /// - `rol`: The data of the role to be updated.
        /// - `Description`: The description of the Description.
        /// </param>
        /// <remarks>This endpoint updates a role with the provided role data.</remarks>
        [HttpPut("/Rol")]
        public async Task<ResponseDTO> UpdateRol(RolDTO rol) => await _RolBll.UpdateRolBLL(rol);

        /// <summary>
        /// Creates a new role.
        /// </summary>
        /// <param name="Description">- `Description`: The description of the role.</param>
        /// <remarks>This endpoint creates a new role with the provided description.</remarks>
        [HttpPost("/Rol")]
        public async Task<ResponseDTO> CreateRol(string Description) => await _RolBll.CreateRolBLL(Description);



    }
}
