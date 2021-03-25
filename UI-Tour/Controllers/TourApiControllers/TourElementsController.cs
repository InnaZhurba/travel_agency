using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI_Tour.Control;
using UI_Tour.Models;
using System.Threading.Tasks;

namespace UI_Tour.Controllers
{
    public class TourElementsController : ApiController
    {
        private readonly ITourService service;
        //Helper helper;
        public TourElementsController(ITourService serve)
        {
            service = serve;
           // helper = new Helper(service);
        }
        // GET: api/TourElements
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();
            //TourAndDetails container = new TourAndDetails();
            //container.Tours = helper.AllTours();
            IEnumerable<Tour> tours = mapper.Map<IEnumerable<TourDTO>, List<Tour>>(service.GetTours());
            return tours;//helper.GetAllInfo(container);//helper.GetAllInfo(container).Tours;
        }

        // GET: api/TourElements/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (id > 0)
            {
                if (service.GetTours().Where(p => p.Id == id)!=null)
                    return Ok(service.GetTour(id));
                else
                    return BadRequest("null");
            }                
            else
                return BadRequest("id was wrong<=0");
        }

        // POST: api/TourElements
        [HttpPost]
        public void Post([FromBody]Tour value)
        {
            if(value!=null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tour, TourDTO>()).CreateMapper();
                service.MakeTour(mapper.Map<Tour,TourDTO>(value));
            }
        }

        // PUT: api/TourElements/5
        [HttpPut]
        public void Put(int id, [FromBody]Tour value)
        {
            if(id>0 && value!=null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tour, TourDTO>()).CreateMapper();
                value.Id = id;
                service.EditTour(mapper.Map<Tour, TourDTO>(value));
            }
        }

        // DELETE: api/TourElements/5
        public void Delete(int id)
        {
        }
    }
}
