using BLL_Users.DTO;

namespace BLL.Interfaces
{
    public interface IManagerService
    {
        void MakeManager(ManagerDTO managerDTO);
        void DeleteManager(int? id);
        ManagerDTO FindManager(string login);
        void Dispose();
    }
}
