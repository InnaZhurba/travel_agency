using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CountryRepository : Interfaces.IRepository<Entities.Country>
    {
        private DBContext db;

        public CountryRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.Country> GetAll()
        {
            return db.Countries.Include(p => p.Region);
        }

        public IEnumerable<Entities.Country> GetName(string name)
        {
            return db.Countries.Where(p => p.Name == name);
        }
        public Entities.Country Get(int id)
        {
            return db.Countries.Find(id);
        }

        public void Create(Entities.Country list)
        {
            db.Countries.Add(list);
        }

        public void Update(Entities.Country list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Entities.Country> Find(Func<Entities.Country, Boolean> predicate)
        {
            return db.Countries.Include(o => o.Name).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.Country list = db.Countries.Find(id);
            if (list != null)
                db.Countries.Remove(list);
        }
    }
}
