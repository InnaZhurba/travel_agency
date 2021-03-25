using BLL.DTO;
using System;
using BLL.Interfaces;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace BLL.Json.Serialize
{
    //public class CountrySerialize : ISerialize<CountryDTO>
    //{
    //    public string[] serializeList(IEnumerable<CountryDTO> data)
    //    {
    //        string[] json;
    //        int i = data.Count();
    //        json = new string[i];
    //        int j = 0;
    //        foreach (CountryDTO c in data)
    //        {
    //            json[j] = JsonSerializer.Serialize(c);
    //            j++;
    //        }
    //        return json;
    //    }
    //    public string serializeVary(CountryDTO data)
    //    {
    //        string json;
    //        json = JsonSerializer.Serialize(data);
    //        return json;
    //    }
    //}
}
