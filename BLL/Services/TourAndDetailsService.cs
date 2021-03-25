using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TourAndDetailsService: ITourAndDetailsService
    {
        IUnitOfWork Database { get; set; }
        ITourService tour;
        ITourTypeService type;
        ITourInfoService info;
        IListOCService list;
        ICountryService country;
        IRegionService region;
        public TourAndDetailsService(IUnitOfWork data)
        {
            Database = data;
            tour = new TourService(data);
            type = new TourTypeService(data);
            info = new TourInfoService(data);
            list = new ListOfCountryService(data);
            country = new CountryService(data);
            region = new RegionService(data);
        }
        public IEnumerable<TourAndDetailsDTO> Get()
        {
            List<TourAndDetailsDTO> data = new List<TourAndDetailsDTO>();
            var tours = tour.GetTours();

            foreach(TourDTO t in tours)
            {
                var listOC = list.GetListOC(t.Id.ToString());
                var count = country.GetCountry(listOC.CountryId);
                data.Add(new TourAndDetailsDTO()
                {
                    Tours = t,
                    Types = type.GetTourType(t.TourTypeId),
                    Infos = info.GetTourInfo(t.InfoId),
                    ListOfCountries = listOC,
                    Countries = count,
                    Regions = region.GetRegion(count.RegionId),
                });
            }
            return data;
        }
        public TourAndDetailsDTO GetId(int? id)
        {
            TourAndDetailsDTO data;
            var tours = tour.GetTour(id);
            var listOC = list.GetListOC(tours.Id.ToString());
            var count = country.GetCountry(listOC.CountryId);
            data = new TourAndDetailsDTO()
            {
                Tours = tours,
                Types = type.GetTourType(tours.TourTypeId),
                Infos = info.GetTourInfo(tours.InfoId),
                ListOfCountries = listOC,
                Countries = count,
                Regions = region.GetRegion(count.RegionId),
            };

            return data;
        }
    }
}
