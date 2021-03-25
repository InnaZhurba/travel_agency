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
    //public class TourInfoDeserialize : IDeserialize<TourInfoDTO>
    //{
    //    public IEnumerable<TourInfoDTO> deserializeList(string[] data)
    //    {
    //        IEnumerable<TourInfoDTO> list;
    //        TourInfoDTO[] c = new TourInfoDTO[data.Length];

    //        for (int i = 0; i < data.Length; i++)
    //        {
    //            c[i] = JsonSerializer.Deserialize<TourInfoDTO>(data[i]);
    //        }
    //        list = c;
    //        return list;
    //    }
    //    public TourInfoDTO deserializeVary(string data)
    //    {
    //        TourInfoDTO json;
    //        json = JsonSerializer.Deserialize<TourInfoDTO>(data);

    //        return json;
    //    }
    //}
}
