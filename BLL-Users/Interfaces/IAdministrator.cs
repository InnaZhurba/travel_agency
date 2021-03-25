using BLL_Users.DTO;

namespace BLL_Users.Interfaces
{
    public interface IAdministratorService
    {
        AdministratorDTO FindAdmin(string login);
        void Dispose();
    }
}
