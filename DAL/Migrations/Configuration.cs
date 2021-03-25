namespace DAL.Migrations
{
    using DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.DBContext context)
        {
            var tourtypes = new List<TourType>
            { 
                new TourType{Type = "Escorted",},
                new TourType{Type = "Guided",},
                new TourType{Type = "Independent Vacation",},
                new TourType{Type = "Rail",},
                new TourType{Type = "River Cruise",},
                new TourType{Type = "Dark",},
                new TourType{Type = "Disaster",},
                new TourType{Type = "Virtual",},
                new TourType{Type = "Cultural",},
                new TourType{Type = "Archaeologic",},
                new TourType{Type = "Adventure",},
                new TourType{Type = "Educational",},
                new TourType{Type = "Extreme",},
                new TourType{Type = "Garden",},
                new TourType{Type = "Hobby",}
            };
            tourtypes.ForEach(s => context.TourTypes.AddOrUpdate(p => p.Type, s));
            context.SaveChanges();

            var regions = new List<Region>
            {
                new Region {Name = "North Africa",},
                new Region {Name = "Central Africa",},
                new Region {Name = "East Africa",},
                new Region {Name = "Southern Africa",},
                new Region {Name = "West Africa",},
                new Region {Name = "Hong Kong",},
                new Region {Name = "Macau",},
                new Region {Name = "Beijing",},
                new Region {Name = "Bengbu",},
                new Region {Name = "Shanghai",},
                new Region {Name = "Bozhou",},
                new Region {Name = "Chaohu",},
                new Region {Name = "Hefei",},
                new Region {Name = "Sacramento",},
                new Region {Name = "Portland",},
                new Region {Name = "Seattle",},
                new Region {Name = "Fresno",},
                new Region {Name = "San Diego",},
                new Region {Name = "Mesa",}
            };
            regions.ForEach(s => context.Regions.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var countries = new List<Country>
            {
                new Country {Name = "Africa", RegionId = regions.Single(s=>s.Name=="North Africa").Id,},
                new Country {Name = "Africa", RegionId = regions.Single(s=>s.Name=="Central Africa").Id,},
                new Country {Name = "Africa", RegionId = regions.Single(s=>s.Name=="East Africa").Id,},
                new Country {Name = "Africa", RegionId = regions.Single(s=>s.Name=="Southern Africa").Id,},
                new Country {Name = "Africa", RegionId = regions.Single(s=>s.Name=="West Africa").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Hong Kong").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Macau").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Beijing").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Bengbu").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Shanghai").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Bozhou").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Chaohu").Id,},
                new Country {Name = "China", RegionId = regions.Single(s=>s.Name=="Hefei").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="Sacramento").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="Portland").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="Seattle").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="Fresno").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="San Diego").Id,},
                new Country {Name = "USA", RegionId = regions.Single(s=>s.Name=="Mesa").Id,}
            };
            foreach (Country e in countries)
            {
                var countryInDataBase = context.Countries.Where(
                    s =>
                         s.Name == e.Name &&
                         s.Region.Id == e.RegionId).SingleOrDefault();
                if (countryInDataBase == null)
                {
                    context.Countries.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}
