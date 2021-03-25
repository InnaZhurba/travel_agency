using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Order.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); // get all objects
        T Get(int id); // get one obgects by id
        IEnumerable<T> GetTour(int name);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item); // create object
        void Update(T item); // update object
        void Delete(int id); // delete object by id
    }
    
}
