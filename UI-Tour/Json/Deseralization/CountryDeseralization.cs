using System;
using UI.Models;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;
using UI_Tour.Json.Interfaces;

namespace UI_Tour.Json.Deseralization
{
    public class CountryDeserialize : IDeseralization<CountryDTO>
    {
        public IEnumerable<CountryDTO> deserializeList(string[] data)
        {
            
            CountryDTO[] c = new CountryDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<CountryDTO>(data[i]);
            }
            IEnumerable<CountryDTO> list = c;
            return list;
        }
        public CountryDTO deseriallizeVary(string data)
        {
            CountryDTO json;
            json = JsonSerializer.Deserialize<CountryDTO>(data);

            return json;
        }
    }
}