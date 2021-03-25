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
    public class RegionDeserialize : IDeseralization<RegionDTO>
    {
        public IEnumerable<RegionDTO> deserializeList(string[] data)
        {
            IEnumerable<RegionDTO> list;
            RegionDTO[] c = new RegionDTO[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                c[i] = JsonSerializer.Deserialize<RegionDTO>(data[i]);
            }
            list = c;
            return list;
        }
        public RegionDTO deseriallizeVary(string data)
        {
            RegionDTO json;
            json = JsonSerializer.Deserialize<RegionDTO>(data);

            return json;
        }
    }
}
