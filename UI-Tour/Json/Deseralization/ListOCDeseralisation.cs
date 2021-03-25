using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;
using UI_Tour.Models;
using UI_Tour.Json.Interfaces;

namespace UI_Tour.Json.Deseralization
{
    public class ListOCDeseralisation : IDeseralization<ListOfCountryDTO>
    {
        public IEnumerable<ListOfCountryDTO> deserializeList(string[] data)
        {
            IEnumerable<ListOfCountryDTO> list;
            ListOfCountryDTO[] c = new ListOfCountryDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<ListOfCountryDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public ListOfCountryDTO deseriallizeVary(string data)
        {
            ListOfCountryDTO json;
            json = JsonSerializer.Deserialize<ListOfCountryDTO>(data);

            return json;
        }
    }
}
