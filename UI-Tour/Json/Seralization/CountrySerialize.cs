using BLL.DTO;
using System;
using BLL.Interfaces;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UI.Models;

namespace UI_Tour.Json.Seralization
{
    public class CountrySerialize : ISerialize<Country>
    {
        public string[] serializeList(IEnumerable<Country> data)
        {
            string[] json;
            int i = data.Count();
            json = new string[i];
            int j = 0;
            foreach (Country c in data)
            {
                json[j] = JsonSerializer.Serialize(c);
                j++;
            }
            return json;
        }
        public string serializeVary(Country data)
        {
            string json;
            json = JsonSerializer.Serialize(data);
            return json;
        }
    }
}
