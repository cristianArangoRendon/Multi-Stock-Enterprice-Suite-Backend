using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;

namespace ProyectoFinal.Core.Interfaces.IBLL.Users
{
    public interface IUserBLL
    {
        Task<ResponseDTO> CreateUser(CreateUserDTO userDTO);
        Task<ResponseDTO> DeleteUser(int id);
        Task<ResponseDTO> UpdateUser(UsersDTO userDTO);
        Task<ResponseDTO> GetUser(int idUsers);
        Task<ResponseDTO> IGetUserById(int id);
        Task<ResponseDTO> Auth(string user, string password);
    }
}
