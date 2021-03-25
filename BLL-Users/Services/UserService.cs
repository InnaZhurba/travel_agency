using BLL_Users.DTO;
using BLL_Users.Interfaces;
using DAL_Users.Interfaces;
using System.Collections.Generic;

namespace BLL_Users.Services
{
    public class ListOfCountryService : IUserService
    {
        IUnitOfWork Database { get; set; }
        public ListOfCountryService(IUnitOfWork data)
        {
            Database = data;
        }
        public UserDTO FindUser(string login)
        {
            return new UserDTO();
        }
        public void MakeUser(UserDTO userDTO)
        {

        }
        public void DeleteUser(int? id)
        {

        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
