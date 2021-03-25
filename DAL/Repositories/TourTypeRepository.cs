using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
     public class TourTypeRepository : Interfaces.IRepository<Entities.TourType>
    {
        private DBContext db;

        public TourTypeRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.TourType> GetAll()
        {
            return db.TourTypes;
        }

        public Entities.TourType Get(int id)
        {
            return db.TourTypes.Find(id);
        }
        public IEnumerable<Entities.TourType> GetName(string name)
        {
            return db.TourTypes.Where(p => p.Type == name);
        }
        public void Create(Entities.TourType list)
        {
            db.TourTypes.Add(list);
        }

        public void Update(Entities.TourType list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Entities.TourType> Find(Func<Entities.TourType, Boolean> predicate)
        {
            return db.TourTypes.Include(o => o.Type).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.TourType list = db.TourTypes.Find(id);
            if (list != null)
                db.TourTypes.Remove(list);
        }
    }
}
