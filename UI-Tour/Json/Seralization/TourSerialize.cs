using System;
using UI_Tour.Json.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;
using UI_Tour.Models;

namespace UI_Tour.Json.Seralization
{
    public class TourSerialize : ISeralization<Tour>
    {
        public string[] serializeList(IEnumerable<Tour> data)
        {
            string[] json;
            int i = data.Count();
            json = new string[i];
            int j = 0;
            foreach (Tour c in data)
            {
                json[j] = JsonSerializer.Serialize(c);
                j++;
            }
            return json;
        }
        public string serializeVary(Tour data)
        {
            string json;
            json = JsonSerializer.Serialize(data);
            return json;
        }
    }
}
