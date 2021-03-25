using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   public interface IUnitOfWork : IDisposable
    {
        IRepository<ListOfCountry> ListOfCountries { get; }
        IRepository<Region> Regions { get; }
        IRepository<TourType> TourTypes { get; }
        IRepository<Country> Countries { get; }
        IRepository<TourInfo> TourInfos { get; }
        IRepository<Tour> Tours { get; }
        void Save();
        void Dispose();
    }
}
