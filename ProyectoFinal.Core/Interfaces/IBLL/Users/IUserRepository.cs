using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;

namespace ProyectoFinal.Core.Interfaces.IBLL.Users
{
    public interface IUserBLL
    {
        Task<ResponseDTO> CreateUser(CreateUserDTO userDTO);
        Task<ResponseDTO> DeleteUser(int id);
        Task<ResponseDTO> UpdateUser(UpdateUserDTO update);
        Task<ResponseDTO> GetUser(int idUsers);
        Task<ResponseDTO> GetUserById(int idUser, int idCompany);
        Task<ResponseDTO> Auth(string user, string password);
    }
}
