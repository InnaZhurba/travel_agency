using DAL_Order;
using DAL_Order.EF;
using DAL_Order.Entities;
using DAL_Order.Interfaces;
using DAL_Order.Repositories;
using System;

namespace DAL_Order.UoW
{
    public class UnitOfWorkOrder : IUnitOfWorkOrder
    {
        private DBContext db; //= new DBContext();
        private OrderRepository orderRepository;

        public UnitOfWorkOrder()
        {
            db = new DBContext();
        }
        
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }
       
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
