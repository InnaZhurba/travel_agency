using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TourRepository : Interfaces.IRepository<Entities.Tour>
    {
        private DBContext db;

        public TourRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.Tour> GetAll()
        {
            return db.Tours;
        }
        public IEnumerable<Entities.Tour> GetName(string name)
        {
            return db.Tours.Where(p => p.Name==name);
        }

        public Entities.Tour Get(int id)
        {
            return db.Tours.Find(id);
        }

        public void Create(Entities.Tour list)
        {
            db.Tours.Add(list);
        }

        public void Update(Tour list)
        {
            //var ex = db.Tours.Find(list.Id);
            //ex.InfoId = list.InfoId;
            //ex.TourTypeId = list.TourTypeId;
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Entities.Tour> Find(Func<Entities.Tour, Boolean> predicate)
        {
            return db.Tours.Include(o => o.Name).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.Tour list = db.Tours.Find(id);
            if (list != null)
                db.Tours.Remove(list);
        }
    }
}
