using System.Collections.Generic;
using System.Text.Json;
using BLL_Order.DTO;
using BLL_Order.Interfaces;

namespace BLL_Order.Json.Deserialize
{
    public class OrderDeserialize : IDeserialize<OrderDTO>
    {
        public IEnumerable<OrderDTO> deserializeList(string[] data)
        {
            IEnumerable<OrderDTO> list;
            OrderDTO[] c = new OrderDTO[data.Length];

            for (int i=0;i < data.Length;i++)
            {
               c[i] = JsonSerializer.Deserialize<OrderDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public OrderDTO deserializeVary(string data)
        {
            OrderDTO json;
            json = JsonSerializer.Deserialize<OrderDTO>(data);

            return json;
        }
    }
}
