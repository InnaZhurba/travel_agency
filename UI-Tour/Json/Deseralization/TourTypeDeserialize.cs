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
    public class TourTypeDeserialize : IDeseralization<TourTypeDTO>
    {
        public IEnumerable<TourTypeDTO> deserializeList(string[] data)
        {
            IEnumerable<TourTypeDTO> list;
            TourTypeDTO[] c = new TourTypeDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<TourTypeDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public TourTypeDTO deseriallizeVary(string data)
        {
            TourTypeDTO json;
            json = JsonSerializer.Deserialize<TourTypeDTO>(data);

            return json;
        }
    }
}
