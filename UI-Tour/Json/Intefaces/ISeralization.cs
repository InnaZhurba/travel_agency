using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_Tour.Json.Interfaces
{
    public interface ISeralization<T> where T:class
    {
        string[] serializeList(IEnumerable<T> data);
        string serializeVary(T data);
    }
}