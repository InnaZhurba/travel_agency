using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext db; //= new DBContext();
        private Repositories.ListOCRepository listOCRepository;
        private Repositories.RegionRepository regionRepository;
        private Repositories.CountryRepository countryRepository;
        private Repositories.TourTypeRepository tourTypeRepository;
        private Repositories.TourInfoRepository tourInfoRepository;
        private Repositories.TourRepository tourRepository;

        public UnitOfWork()
        {
            db = new DBContext();
        }
        
        public IRepository<ListOfCountry> ListOfCountries
        {
            get
            {
                if (listOCRepository == null)
                    listOCRepository = new Repositories.ListOCRepository(db);
                return listOCRepository;
            }
        }
        public IRepository<Region> Regions
        {
            get
            {
                if (regionRepository == null)
                    regionRepository = new Repositories.RegionRepository(db);
                return regionRepository;
            }
        }
        public IRepository<Country> Countries
        {
            get
            {
                if (countryRepository == null)
                    countryRepository = new Repositories.CountryRepository(db);
                return countryRepository;
            }
        }
        public IRepository<TourType> TourTypes
        {
            get
            {
                if (tourTypeRepository == null)
                    tourTypeRepository = new Repositories.TourTypeRepository(db);
                return tourTypeRepository;
            }
        }
        public IRepository<TourInfo> TourInfos
        {
            get
            {
                if (tourInfoRepository == null)
                    tourInfoRepository = new Repositories.TourInfoRepository(db);
                return tourInfoRepository;
            }
        }
        public IRepository<Tour> Tours
        {
            get
            {
                if (tourRepository == null)
                    tourRepository = new Repositories.TourRepository(db);
                return tourRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
            //bool saveFailed;
            //do
            //{
            //    saveFailed = false;

            //    try
            //    {
            //        db.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        saveFailed = true;

            //        // Update the values of the entity that failed to save from the store
            //        ex.Data.Single().Reload();
            //    }

            //} while (saveFailed);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
