using BLL_Users.DTO;

namespace BLL.Interfaces
{
    public interface IUserInfoService
    {
        void MakeUserInfo(UserInfoDTO userinfoDTO);
        void DeleteUserInfo(int? id);
        UserInfoDTO GetUserInfo(int? id);
        UserInfoDTO FindUserInfo(string login);
        void Dispose();
    }
}
