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
        


        [HttpGet("/Rol")]
        public async Task<ResponseDTO> GetRoles() => await _RolBll.GetRolesBLL();
        


        [HttpGet("/Rol/By/Id")]
        public async Task<ResponseDTO> GetRoles(int idRol) =>  await _RolBll.GetRolByIdBLL(idRol);

        

        [HttpPut("/Rol")]
        public async Task<ResponseDTO> UpdateRol(RolDTO rol) => await _RolBll.UpdateRolBLL(rol);

        

        [HttpPost("/Rol")]
        public async Task<ResponseDTO> CreateRol(string Description) =>  await _RolBll.CreateRolBLL(Description);

        
    }
}
