using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Tour.Json.Interfaces;
using BLL.DTO;
using System.Text.Json;
using UI_Tour.Models;

namespace UI_Tour.Json.Deseralization
{
    public class TourDeserialize : IDeseralization<TourDTO>
    {
        public IEnumerable<TourDTO> deserializeList(string[] data)
        {
            IEnumerable<TourDTO> list;
            TourDTO[] c = new TourDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<TourDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public TourDTO deseriallizeVary(string data)
        {
            TourDTO json;
            json = JsonSerializer.Deserialize<TourDTO>(data);

            return json;
        }
    }
}
