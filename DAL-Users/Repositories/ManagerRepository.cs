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
   public class ManagerRepository : IRepository<Manager>
    {
        private DBContext db;

        public ManagerRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Manager> GetAll()
        {
            return db.Managers;
        }

        public Manager Get(int id)
        {
            return db.Managers.Find(id);
        }

        public void Create(Manager list)
        {
            db.Managers.Add(list);
        }

        public void Update(Manager list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Manager> Find(Func<Manager, Boolean> predicate)
        {
            return db.Managers.Include(o => o.Login).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
           Manager list = db.Managers.Find(id);
            if (list != null)
                db.Managers.Remove(list);
        }
    }
}
