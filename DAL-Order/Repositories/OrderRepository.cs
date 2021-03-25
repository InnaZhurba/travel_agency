using DAL_Order.EF;
using DAL_Order.Entities;
using DAL_Order.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Order.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private DBContext db;

        public OrderRepository(DBContext DB)
        {
            this.db = DB;
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders;
        }

        public IEnumerable<Order> GetTour(int id)
        {
            return db.Orders.Where(p => p.TourId==id);
        }
        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public void Create(Order list)
        {
            db.Orders.Add(list);
        }

        public void Update(Order list)
        {
            db.Entry(list).State = EntityState.Modified;
        }

        public IEnumerable<Order> Find(Func<Order, Boolean> predicate)
        {
            return db.Orders.Include(o => o.TourId).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Order list = db.Orders.Find(id);
            if (list != null)
                db.Orders.Remove(list);
        }
    }
}
