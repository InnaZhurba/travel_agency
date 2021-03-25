using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TourInfoRepository : Interfaces.IRepository<Entities.TourInfo>
    {
        private DBContext db;

        public TourInfoRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.TourInfo> GetAll()
        {
            return db.TourInfos;
        }
        public IEnumerable<Entities.TourInfo> GetName(string name)
        {
            return db.TourInfos.Where(p => p.Info == name);
        }
        public Entities.TourInfo Get(int id)
        {
            return db.TourInfos.Find(id);
        }

        public void Create(Entities.TourInfo list)
        {
            db.TourInfos.Add(list);
        }

        public void Update(Entities.TourInfo list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Entities.TourInfo> Find(Func<Entities.TourInfo, Boolean> predicate)
        {
            return db.TourInfos.Include(o => o.Info).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.TourInfo list = db.TourInfos.Find(id);
            if (list != null)
                db.TourInfos.Remove(list);
        }
    }
}
