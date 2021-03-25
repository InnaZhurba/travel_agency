using AutoMapper;
using BLL_Order.DTO;
using BLL_Order.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI.Models;

namespace UI_Tour.Controllers
{
    public class OrderController : ApiController
    {
        private IOrderService service;
        public OrderController(IOrderService serv)
        {
            service = serv;
        }
        // GET: api/Order
        public IHttpActionResult Get()
        {
            return Ok(service.GetOrders());
        }

        // GET: api/Order/5
        public IHttpActionResult Get(int id)
        {
            return Ok(service.GetOrder(id));
        }

        // POST: api/Order
        public void Post([FromBody]Order value)
        {
            if(value!=null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
                service.MakeOrder(mapper.Map<Order,OrderDTO>(value));
            }
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]Order value)
        {
            if (value != null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
                service.MakeOrder(mapper.Map<Order, OrderDTO>(value));
            }
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
