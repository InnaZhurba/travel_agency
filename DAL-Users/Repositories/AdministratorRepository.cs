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
    public class AdministratorRepository : IRepository<Administrator>
    {
        private DBContext db;

        public AdministratorRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Administrator> GetAll()
        {
            return db.Administrators;
        }

        public Administrator Get(int id)
        {
            return db.Administrators.Find(id);
        }

        public void Create(Administrator list)
        {
            db.Administrators.Add(list);
        }

        public void Update(Administrator list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Administrator> Find(Func<Administrator, Boolean> predicate)
        {
            return db.Administrators.Include(o => o.Login).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Administrator list = db.Administrators.Find(id);
            if (list != null)
                db.Administrators.Remove(list);
        }
    }
}
