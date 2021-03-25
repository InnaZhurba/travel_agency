using DAL_Order.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Order.EF
{
    public class DBContext: DbContext
    {
        public DBContext()
              : base("DbConnection")
        { }

        public DbSet<Order> Orders { get; set; }
    }
}
