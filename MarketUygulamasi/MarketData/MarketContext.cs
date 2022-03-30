using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class MarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductSell> ProductSells { get; set; }

    }
}
