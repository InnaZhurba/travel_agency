using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.DTO;
using System.Text.Json;

namespace BLL.Json.Serialize
{
    //public class ListOCSerialize : ISerialize<ListOfCountryDTO>
    //{
    //    public string[] serializeList(IEnumerable<ListOfCountryDTO> data)
    //    {
    //        string[] json;
    //        int i = data.Count();
    //        json = new string[i];
    //        int j = 0;
    //        foreach (ListOfCountryDTO c in data)
    //        {
    //            json[j] = JsonSerializer.Serialize(c);
    //            j++;
    //        }
    //        return json;
    //    }
    //    public string serializeVary(ListOfCountryDTO data)
    //    {
    //        string json;
    //        json = JsonSerializer.Serialize(data);
    //        return json;
    //    }
    //}
}
