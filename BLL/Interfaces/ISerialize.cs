using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISerialize<T> where T:class
    {
        string[] serializeList(IEnumerable<T> data);
        string serializeVary(T data);
    }
}
