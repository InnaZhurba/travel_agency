using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.DTO;
using System.Text.Json;

namespace BLL.Json.Deserialize
{
    //public class TourDeserialize : IDeserialize<TourDTO>
    //{
    //    public IEnumerable<TourDTO> deserializeList(string[] data)
    //    {
    //        IEnumerable<TourDTO> list;
    //        TourDTO[] c = new TourDTO[data.Length];

    //        for (int i = 0; i < data.Length; i++)
    //        {
    //            c[i] = JsonSerializer.Deserialize<TourDTO>(data[i]);
    //        }
    //        list = c;
    //        return list;
    //    }
    //    public TourDTO deserializeVary(string data)
    //    {
    //        TourDTO json;
    //        json = JsonSerializer.Deserialize<TourDTO>(data);

    //        return json;
    //    }
    //}
}
