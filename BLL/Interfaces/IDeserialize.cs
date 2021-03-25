using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDeserialize<T> where T:class
    {
        IEnumerable<T> deserializeList(string[] data);
        T deserializeVary(string data);
    }
}
