using DAL_Users.EF;
using DAL_Users.Interfaces;
using DAL_Users.Repositories;
using DAL_Users.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Users.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext db; //= new DBContext();
        private ManagerRepository managerRepository;
        private AdministratorRepository administratorRepository;
        private UserRepository userRepository;
        private UserInfoRepository infoRepository;

        public UnitOfWork()
        {
            db = new DBContext();
        }

        public IRepository<Manager> Managers
        {
            get
            {
                if (managerRepository == null)
                    managerRepository = new ManagerRepository(db);
                return managerRepository;
            }
        }
        public IRepository<Administrator> Administrators
        {
            get
            {
                if (administratorRepository == null)
                    administratorRepository = new AdministratorRepository(db);
                return administratorRepository;
            }
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public IRepository<UserInfo> UserInfoes
        {
            get
            {
                if (infoRepository == null)
                    infoRepository = new UserInfoRepository(db);
                return infoRepository;
            }
        }
       
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
