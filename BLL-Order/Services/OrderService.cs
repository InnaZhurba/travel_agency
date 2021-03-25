using System.Collections.Generic;
using AutoMapper;
using BLL_Order.DTO;
using BLL_Order.Infostructure;
using BLL_Order.Interfaces;
using BLL_Order.Json.Deserialize;
using BLL_Order.Json.Serialize;
using DAL_Order.Entities;
using DAL_Order.Interfaces;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWorkOrder Database { get; set; }

        public OrderService(IUnitOfWorkOrder data)
        {
            Database = data;
        }
        public void MakeOrder(OrderDTO orderDTO)
        {
            //IDeserialize<OrderDTO>deserialize = new OrderDeserialize();
            //OrderDTO orderDTO = deserialize.deserializeVary(orderVal);

            Order order = new Order
            {
                Id = orderDTO.Id,
                TourId = orderDTO.TourId,
                HotelId = orderDTO.HotelId,
                TransportId = orderDTO.TransportId,

            };
            Database.Orders.Create(order);
            Database.Save();
        }

        public string[] GetOrders()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
            ISerialize<OrderDTO> serialize = new OrderSerialize();

            IEnumerable<OrderDTO> i = mapper.Map<IEnumerable<Order>, List<OrderDTO>>(Database.Orders.GetAll());
            string[] n = serialize.serializeList(i);
            return n;
        }

        public OrderDTO GetOrder(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - region id", "");
            var region = Database.Orders.Get(id.Value);
            if (region == null)
                throw new ValidationException("Region is not found", "");

            //ISerialize<OrderDTO> serialize = new OrderSerialize();
            //string data = serialize.serializeVary(new OrderDTO {Id = region.Id, TourId = region.TourId, HotelId = region.HotelId, TransportId=region.TransportId });

            return new OrderDTO { Id = region.Id, TourId = region.TourId, HotelId = region.HotelId, TransportId = region.TransportId };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
