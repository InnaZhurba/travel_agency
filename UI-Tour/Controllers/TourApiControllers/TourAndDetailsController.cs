using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
//using BLL.Json.Serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI.Models;
using UI_Tour.Models;

namespace UI_Tour.Controllers
{
    public class TourAndDetailsController : ApiController
    {
        private ITourAndDetailsService service;
        IMapper mapperTour = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();
        IMapper mapperType = new MapperConfiguration(cfg => cfg.CreateMap<TourTypeDTO, TourType>()).CreateMapper();
        IMapper mapperInfo = new MapperConfiguration(cfg => cfg.CreateMap<TourInfoDTO, TourInfo>()).CreateMapper();
        IMapper mapperList = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountryDTO, ListOfCountry>()).CreateMapper();
        IMapper mapperCountry = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, Country>()).CreateMapper();
        IMapper mapperRegion = new MapperConfiguration(cfg => cfg.CreateMap<RegionDTO, Region>()).CreateMapper();
        public TourAndDetailsController(ITourAndDetailsService serv)
        {
            service = serv;
        }
        // GET: api/TourAndDetails
        public IEnumerable<TourAndDetails> Get()
        {
            IEnumerable<TourAndDetailsDTO> example = service.Get();
            List<TourAndDetails> data = new List<TourAndDetails>();
            foreach (TourAndDetailsDTO c in example)
            {
                data.Add(new TourAndDetails()
                {
                    Tours = mapperTour.Map<TourDTO, Tour>(c.Tours),
                    Types = mapperType.Map<TourTypeDTO, TourType>(c.Types),
                    Infos = mapperInfo.Map<TourInfoDTO, TourInfo>(c.Infos),
                    ListOfCountries=  mapperList.Map<ListOfCountryDTO, ListOfCountry>(c.ListOfCountries),
                    Countries = mapperCountry.Map<CountryDTO, Country>(c.Countries),
                    Regions = mapperRegion.Map<RegionDTO, Region>(c.Regions),
                });
            }
            return data;
        }

        // GET: api/TourAndDetails/5
        public IHttpActionResult Get(int id)
        {
            if((id<service.Get().Count() && id>0) || service.Get().Where(p=>p.Tours.Id==id)!=null)
            {
                TourAndDetailsDTO example = service.GetId(id);
                TourAndDetails data;

                data = new TourAndDetails()
                {
                    Tours = mapperTour.Map<TourDTO, Tour>(example.Tours),
                    Types = mapperType.Map<TourTypeDTO, TourType>(example.Types),
                    Infos = mapperInfo.Map<TourInfoDTO, TourInfo>(example.Infos),
                    ListOfCountries = mapperList.Map<ListOfCountryDTO, ListOfCountry>(example.ListOfCountries),
                    Countries = mapperCountry.Map<CountryDTO, Country>(example.Countries),
                    Regions = mapperRegion.Map<RegionDTO, Region>(example.Regions),
                };
                return Ok(data);
            }
            else
                return BadRequest("id was wrong<=0");
           
        }

        // POST: api/TourAndDetails
        public void Post([FromBody]TourAndDetails value)
        {
        }

        // PUT: api/TourAndDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TourAndDetails/5
        public void Delete(int id)
        {
        }
    }
}
