﻿using System;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using System.Text.Json;

namespace BLL.Json.Serialize
{
    //public class TourTypeSerialize : ISerialize<TourTypeDTO>
    //{
    //    public string[] serializeList(IEnumerable<TourTypeDTO> data)
    //    {
    //        string[] json;
    //        int i = data.Count();
    //        json = new string[i];
    //        int j = 0;
    //        foreach (TourTypeDTO c in data)
    //        {
    //            json[j] = JsonSerializer.Serialize(c);
    //            j++;
    //        }
    //        return json;
    //    }
    //    public string serializeVary(TourTypeDTO data)
    //    {
    //        string json;
    //        json = JsonSerializer.Serialize(data);
    //        return json;
    //    }
    //}
}
