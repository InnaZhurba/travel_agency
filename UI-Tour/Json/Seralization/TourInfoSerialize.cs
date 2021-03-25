using System;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;
using UI_Tour.Models;

namespace UI_Tour.Json.Seralization
{
    public class TourInfoSerialize : ISerialize<TourInfo>
    {
        public string[] serializeList(IEnumerable<TourInfo> data)
        {
            string[] json;
            int i = data.Count();
            json = new string[i];
            int j = 0;
            foreach (TourInfo c in data)
            {
                json[j] = JsonSerializer.Serialize(c);
                j++;
            }
            return json;
        }
        public string serializeVary(TourInfo data)
        {
            string json;
            json = JsonSerializer.Serialize(data);
            return json;
        }
    }
}
