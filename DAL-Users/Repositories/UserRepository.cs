using System;
using DAL_Users.Interfaces;
using DAL_Users.UserEntities;
using DAL_Users.EF;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL_Users.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private DBContext db;

        public UserRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User list)
        {
            db.Users.Add(list);
        }

        public void Update(User list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<User> Find(Func<User, Boolean> predicate)
        {
            return db.Users.Include(o => o.Login).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            User list = db.Users.Find(id);
            if (list != null)
                db.Users.Remove(list);
        }
    }
}
