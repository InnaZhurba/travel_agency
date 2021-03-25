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
    //public class ListOCDeserialize : IDeserialize<ListOfCountryDTO>
    //{
    //    public IEnumerable<ListOfCountryDTO> deserializeList(string[] data)
    //    {
    //        IEnumerable<ListOfCountryDTO> list;
    //        ListOfCountryDTO[] c = new ListOfCountryDTO[data.Length];

    //        for (int i = 0; i < data.Length; i++)
    //        {
    //            c[i] = JsonSerializer.Deserialize<ListOfCountryDTO>(data[i]);
    //        }
    //        list = c;
    //        return list;
    //    }
    //    public ListOfCountryDTO deserializeVary(string data)
    //    {
    //        ListOfCountryDTO json;
    //        json = JsonSerializer.Deserialize<ListOfCountryDTO>(data);

    //        return json;
    //    }
    //}
}
