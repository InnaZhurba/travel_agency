using System;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;

namespace BLL.Json.Serialize
{
    //public class RegionSerialize : ISerialize<RegionDTO>
    //{
    //    public string[] serializeList(IEnumerable<RegionDTO> data)
    //    {
    //        string[] json;
    //        int i = data.Count();
    //        json = new string[i];
    //        int j = 0;
    //        foreach (RegionDTO c in data)
    //        {
    //            json[j] = JsonSerializer.Serialize(c);
    //            j++;
    //        }
    //        return json;
    //    }
    //    public string serializeVary(RegionDTO data)
    //    {
    //        string json;
    //        json = JsonSerializer.Serialize(data);
    //        return json;
    //    }
    //}
}
