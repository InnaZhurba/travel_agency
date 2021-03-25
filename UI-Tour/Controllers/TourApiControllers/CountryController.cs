using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI.Models;

namespace UI_Tour.Controllers
{
    public class CountryController : ApiController
    {
        IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, Country>()).CreateMapper();
        private ICountryService service;
        public CountryController(ICountryService serv)
        {
            service = serv;
        }
        // GET: api/Country
        public IHttpActionResult Get()
        {
            return Ok(mapper.Map<IEnumerable<CountryDTO>, List<Country>>(service.GetCountries()));
        }

        // GET: api/Country/5
        public IHttpActionResult Get(int id)
        {
            int n = 0;
            var i = mapper.Map < IEnumerable<CountryDTO>, List<Country>> (service.GetCountries().Where(p => p.Id == id));
            foreach (Country c in i)
                n = c.Id;
            if (n != 0)
                return Ok(mapper.Map<CountryDTO, Country>(service.GetCountry(id)));
            else
                return BadRequest("Can`t find it!");
        }

        // POST: api/Country
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Country/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Country/5
        public void Delete(int id)
        {
        }
    }
}
