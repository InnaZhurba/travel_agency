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
    public class TourInfoDeserialise : IDeseralization<TourInfoDTO>
    {
        public IEnumerable<TourInfoDTO> deserializeList(string[] data)
        {
            IEnumerable<TourInfoDTO> list;
            TourInfoDTO[] c = new TourInfoDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<TourInfoDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public TourInfoDTO deseriallizeVary(string data)
        {
            TourInfoDTO json;
            json = JsonSerializer.Deserialize<TourInfoDTO>(data);

            return json;
        }
    }
}
