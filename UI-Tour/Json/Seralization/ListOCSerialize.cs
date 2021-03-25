using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;
using UI_Tour.Models;
using UI_Tour.Json.Interfaces;

namespace UI_Tour.Json.Seralization
{
    public class ListOCSerialize : ISeralization<ListOfCountry>
    {
        public string[] serializeList(IEnumerable<ListOfCountry> data)
        {
            string[] json;
            int i = data.Count();
            json = new string[i];
            int j = 0;
            foreach (ListOfCountry c in data)
            {
                json[j] = JsonSerializer.Serialize(c);
                j++;
            }
            return json;
        }
        public string serializeVary(ListOfCountry data)
        {
            string json;
            json = JsonSerializer.Serialize(data);
            return json;
        }
    }
}
