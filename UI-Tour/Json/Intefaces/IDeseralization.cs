using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace UI_Tour.Json.Interfaces
{
    public interface IDeseralization<T> where T:class
    {
        IEnumerable<T> deserializeList(string[] data);
        T deseriallizeVary(string data);
    }
}