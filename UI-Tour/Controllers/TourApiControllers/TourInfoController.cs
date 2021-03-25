using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UI_Tour.Controllers
{
    public class TourInfoController : ApiController
    {
        private ITourInfoService service;
        IMapper mapperInfo = new MapperConfiguration(cfg => cfg.CreateMap<TourInfoDTO, TourInfo>()).CreateMapper();
        public TourInfoController(ITourInfoService serv)
        {
            service = serv;
        }
        // GET: api/TourInfo
        public IHttpActionResult Get()
        {
            return Ok(mapperInfo.Map<IEnumerable<TourInfoDTO>,List<TourInfo>>(service.GetTourInfos()));
        }

        // GET: api/TourInfo/5
        public IHttpActionResult Get(int id)
        {
            return Ok(mapperInfo.Map<TourInfoDTO, TourInfo>(service.GetTourInfo(id)));
        }

        // POST: api/TourInfo
        public void Post([FromBody]TourInfo value)
        {
            if(value!=null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfo, TourInfoDTO>()).CreateMapper();
                service.MakeInfo(mapper.Map<TourInfo, TourInfoDTO>(value));
            }
        }

        // PUT: api/TourInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TourInfo/5
        public void Delete(int id)
        {
        }
    }
}
