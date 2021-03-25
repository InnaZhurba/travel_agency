using DAL_Order.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Order.Interfaces
{
   public interface IUnitOfWorkOrder : IDisposable
    {
        IRepository<Order> Orders { get; }
        void Save();
        void Dispose();
    }
}
