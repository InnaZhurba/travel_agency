using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UI_Tour.Controllers
{
    public class TourTypeController : ApiController
    {
        IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourTypeDTO, TourType>()).CreateMapper();
        private ITourTypeService service;
        public TourTypeController(ITourTypeService serv)
        {
            service = serv;
        }
        // GET: api/TourType
        public IHttpActionResult Get()
        {
            return Ok(mapper.Map<IEnumerable<TourTypeDTO>, List<TourType>>(service.GetTourTypes()));
        }

        // GET: api/TourType/5
        public IHttpActionResult Get(int id)
        {
            return Ok(mapper.Map<TourTypeDTO, TourType>(service.GetTourType(id)));
        }

        // POST: api/TourType
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TourType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TourType/5
        public void Delete(int id)
        {
        }
    }
}
