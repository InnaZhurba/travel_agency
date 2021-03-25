using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL_Users.UserEntities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Users.EF
{
    public class DBContext : DbContext
    {
        public DBContext()
              : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfoes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
