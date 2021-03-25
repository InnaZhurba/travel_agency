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
    public class RegionController : ApiController
    {
        private IRegionService service;
        public RegionController(IRegionService serv)
        {
            service = serv;
        }
        // GET: api/Region
        public IHttpActionResult Get()
        {
            return Ok(service.GetRegions());
        }

        // GET: api/Region/5
        public IHttpActionResult Get(int id)
        {
            return Ok(service.GetRegion(id));
        }

        // POST: api/Region
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Region/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Region/5
        public void Delete(int id)
        {
        }
    }
}
