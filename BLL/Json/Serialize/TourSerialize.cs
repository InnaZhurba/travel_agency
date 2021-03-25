using BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using BLL.DTO;
using System.Text.Json;

namespace BLL.Json.Serialize
{
    //public class TourSerialize : ISerialize<TourDTO>
    //{
    //    public string[] serializeList(IEnumerable<TourDTO> data)
    //    {
    //        string[] json;
    //        int i = data.Count();
    //        json = new string[i];
    //        int j = 0;
    //        foreach (TourDTO c in data)
    //        {
    //            json[j] = JsonSerializer.Serialize(c);
    //            j++;
    //        }
    //        return json;
    //    }
    //    public string serializeVary(TourDTO data)
    //    {
    //        string json;
    //        json = JsonSerializer.Serialize(data);
    //        return json;
    //    }
    //}
}
