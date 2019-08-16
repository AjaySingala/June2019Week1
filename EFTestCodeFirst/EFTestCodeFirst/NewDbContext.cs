using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestCodeFirst
{
    public class NewDbContext : DbContext
    {
        public NewDbContext()
        {
            //this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
