using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;

namespace ProyectoFinal.Core.Interfaces.IBLL.Users
{
    public interface IUserBLL
    {
        Task<ResponseDTO> CreateUsuario(CreateUserDTO userDTO);
        Task<ResponseDTO> DeleteUser(int id);
        Task<ResponseDTO> UpdateUser(UsersDTO userDTO);
        Task<ResponseDTO> GetUser(int idUsers);
        Task<ResponseDTO> IGetUserById(int id);
        Task<ResponseDTO> Auth(string User, string password);




    }
}
