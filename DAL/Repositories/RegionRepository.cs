using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RegionRepository : Interfaces.IRepository<Entities.Region>
    {
        private DBContext db;

        public RegionRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.Region> GetAll()
        {
            return db.Regions;
        }
        public IEnumerable<Entities.Region> GetName(string name)
        {
            return db.Regions.Where(p => p.Name == name);
        }
        public Entities.Region Get(int id)
        {
            return db.Regions.Find(id);
        }

        public void Create(Entities.Region list)
        {
            db.Regions.Add(list);
        }

        public void Update(Entities.Region list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Entities.Region> Find(Func<Entities.Region, Boolean> predicate)
        {
            return db.Regions.Include(o => o.Name).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.Region list = db.Regions.Find(id);
            if (list != null)
                db.Regions.Remove(list);
        }
    
    }
}
