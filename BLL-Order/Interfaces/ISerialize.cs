using System.Collections.Generic;

namespace BLL_Order.Interfaces
{
    public interface ISerialize<T> where T:class
    {
        string[] serializeList(IEnumerable<T> data);
        string serializeVary(T data);
    }
}
