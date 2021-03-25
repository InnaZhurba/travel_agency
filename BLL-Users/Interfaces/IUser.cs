using BLL_Users.DTO;

namespace BLL_Users.Interfaces
{
    public interface IUserService
    {
        UserDTO FindUser(string login);
        void MakeUser(UserDTO userDTO);
        void DeleteUser(int? id);
        void Dispose();
    }
}
