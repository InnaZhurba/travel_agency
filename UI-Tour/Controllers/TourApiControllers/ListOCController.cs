using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI_Tour.Models;

namespace UI_Tour.Controllers
{
    //[RoutePrefix("api/ListOC")]
    public class ListOCController : ApiController
    {
        private IListOCService service;
        public ListOCController(IListOCService serv)
        {
            service = serv;
        }
        // GET: api/ListOC
        public IHttpActionResult Get()
        {
            return Ok(service.GetListOC());
        }

        // GET: api/ListOC/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(service.GetListOC(id));
        }
        [HttpGet]
        [Route("api/ListOC/{id}/TourId")]
        public IHttpActionResult GetByIdName(string id)
        {
            return Ok(service.GetListOC(id));
        }

        // POST: api/ListOC
        public void Post([FromBody]ListOfCountry value)
        {
            if(value!=null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
                service.MakeList(mapper.Map<ListOfCountry, ListOfCountryDTO>(value));
            }
        }

        // PUT: api/ListOC/5
        public void Put(int id, [FromBody]ListOfCountry value)
        {
            if (value != null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
                value.Id = id;
                service.EditListOC(mapper.Map<ListOfCountry, ListOfCountryDTO>(value));
            }
        }

        // DELETE: api/ListOC/5
        public void Delete(int id)
        {
        }
    }
}
