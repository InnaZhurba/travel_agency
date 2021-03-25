using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBContext: DbContext
    {
        public DBContext()
              : base("DbConnection")
        { }

        public DbSet<Entities.Country> Countries { get; set; }
        public DbSet<Entities.ListOfCountry> ListOfCountries { get; set; }
        public DbSet<Entities.Region> Regions { get; set; }
        public DbSet<Entities.Tour> Tours { get; set; }
        public DbSet<Entities.TourInfo> TourInfos { get; set; }
        public DbSet<Entities.TourType> TourTypes { get; set; }
    }
}
