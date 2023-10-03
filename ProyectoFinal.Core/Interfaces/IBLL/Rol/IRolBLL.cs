using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;

namespace ProyectoFinal.Core.Interfaces.IBLL.Rol
{
    public interface IRolBLL
    {

        Task<ResponseDTO> GetRolesBLL();
        Task<ResponseDTO> GetRolByIdBLL(int RolId);
        Task<ResponseDTO> CreateRolBLL(string description);
        Task<ResponseDTO> UpdateRolBLL(RolDTO rol);
    }
}
