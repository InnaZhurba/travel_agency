using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using BLL_Order.Interfaces;
using BLL_Order.DTO;

namespace BLL_Order.Json.Serialize
{
    public class OrderSerialize : ISerialize<OrderDTO>
    {
        public string[] serializeList(IEnumerable<OrderDTO> data)
        {
            string[] json;
            int i = data.Count();
            json = new string[i];
            int j = 0;
            foreach (OrderDTO c in data)
            {
                json[j] = JsonSerializer.Serialize(c);
                j++;
            }
            return json;
        }
        public string serializeVary(OrderDTO data)
        {
            string json;
            json = JsonSerializer.Serialize(data);
            return json;
        }
    }
}
