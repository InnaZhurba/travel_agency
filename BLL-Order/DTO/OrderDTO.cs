using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Order.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int HotelId { get; set; }
        public int TransportId { get; set; }
    }
}
