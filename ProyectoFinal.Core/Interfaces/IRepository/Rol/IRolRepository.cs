using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Rol;

namespace ProyectoFinal.Core.Interfaces.IRepository.Rol
{
    public interface IRolRepository
    {

        Task<ResponseDTO> GetRolesRepository();
        Task<ResponseDTO> GetRolByIdRepository(int RolId);
        Task<ResponseDTO> CreateRolRepository(string description);
        Task<ResponseDTO> UpdateRolRepository(RolDTO rol);

    }
}
