using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ListOCRepository : Interfaces.IRepository<Entities.ListOfCountry>
    {
        private DBContext db;

        public ListOCRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Entities.ListOfCountry> GetAll()
        {
            return db.ListOfCountries;
        }

        public Entities.ListOfCountry Get(int id)
        {
            return db.ListOfCountries.Find(id);
        }
        public IEnumerable<Entities.ListOfCountry> GetName(string id)
        {
            return db.ListOfCountries.Where(p => p.TourId.ToString() == id);
        }

        public void Create(Entities.ListOfCountry list)
        {
            db.ListOfCountries.Add(list);
        }

        public void Update(Entities.ListOfCountry list)
        {
            //db.Entry(list).State = EntityState.Modified;
            var ex = db.ListOfCountries.Find(list.Id);
            ex.Id = list.Id;
            ex.CountryId = list.CountryId;
            ex.TourId = list.TourId;
        }
        public IEnumerable<Entities.ListOfCountry> Find(Func<Entities.ListOfCountry, Boolean> predicate)
        {
            return db.ListOfCountries.Include(o => o.TourId).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.ListOfCountry list = db.ListOfCountries.Find(id);
            if (list != null)
                db.ListOfCountries.Remove(list);
        }
    }
}
