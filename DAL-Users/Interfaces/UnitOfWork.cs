using System;
using DAL_Users.UserEntities;
namespace DAL_Users.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Manager> Managers { get; }
        IRepository<Administrator> Administrators { get; }
        IRepository<User> Users { get; }
        IRepository<UserInfo> UserInfoes { get; }
        void Save();
        void Dispose();
    }
}
