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
    public class UserInfoRepository : IRepository<UserInfo>
    {
        private DBContext db;

        public UserInfoRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<UserInfo> GetAll()
        {
            return db.UserInfoes;
        }

        public UserInfo Get(int id)
        {
            return db.UserInfoes.Find(id);
        }

        public void Create(UserInfo list)
        {
            db.UserInfoes.Add(list);
        }

        public void Update(UserInfo list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<UserInfo> Find(Func<UserInfo, Boolean> predicate)
        {
            return db.UserInfoes.Include(o => o.Name).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            UserInfo list = db.UserInfoes.Find(id);
            if (list != null)
                db.UserInfoes.Remove(list);
        }
    }
}
