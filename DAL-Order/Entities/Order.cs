using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Order.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int HotelId { get; set; }
        public int TransportId { get; set; }
    }
}
