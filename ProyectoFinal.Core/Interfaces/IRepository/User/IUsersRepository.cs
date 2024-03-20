using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.DTOs.Users;

namespace ProyectoFinal.Core.Interfaces.IRepository.Users
{
    public interface IUsersRepository
    {
        Task<ResponseDTO> CreateUsersRepository(CreateUserDTO userDTO);
        Task<ResponseDTO> DeleteUserRepository(int id);
        Task<ResponseDTO> UpdateUserRepository(UpdateUserDTO updateUser);
        Task<ResponseDTO> GetUsersRepository(int idRol);
        Task<ResponseDTO> GetUserByIdRepository(int idUser, int idCompany);
        Task<ResponseDTO> Auth(string User, string password);

        Task<UsersDTO> GetUserByEmail(string user);

    }
}
