using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class CustomerDal
    {

        public List<Customer> GetCustomers()
        {
            using (MarketContext context = new MarketContext())
            {
              return context.Customers.ToList();
            }
        }
        public void Add(Customer customer)
        {
            using (MarketContext context = new MarketContext())
            {
                var addedCustomer = context.Entry(customer);
                addedCustomer.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Customer customer)
        {
            using (MarketContext context = new MarketContext())
            {
                var updatedCustomer = context.Entry(customer);
                updatedCustomer.State = EntityState.Modified;
                context.SaveChanges();
            }
               
        }
    }
}
