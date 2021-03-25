using BLL.DTO;
using System;
using System.Collections.Generic;
using BLL.Interfaces;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL.Json.Deserialize
{
    //public class CountryDeserialize : IDeserialize<CountryDTO>
    //{
    //    public IEnumerable<CountryDTO> deserializeList(string[] data)
    //    {
    //        IEnumerable<CountryDTO> list;
    //        CountryDTO[] c = new CountryDTO[data.Length];

    //        for (int i=0;i < data.Length;i++)
    //        {
    //           c[i] = JsonSerializer.Deserialize<CountryDTO>(data[i]);
    //        }
    //        list = c;
    //        return list;
    //    }
    //    public CountryDTO deserializeVary(string data)
    //    {
    //        CountryDTO json;
    //        json = JsonSerializer.Deserialize<CountryDTO>(data);

    //        return json;
    //    }
    //}
}
