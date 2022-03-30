using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class ProductDal
    {
        public List<Product> GetAll() {
            using (MarketContext context = new MarketContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetProductsByBarkod(int barkod)
        {
            using (MarketContext context = new MarketContext())
            {
                return context.Products.Where(p => p.BarkodNo == barkod).ToList();
            }
        }
        public List<Product> GetAllById(int id )
        {
            using (MarketContext context = new MarketContext())
            {
                return context.Products.Where(p=> p.CategoryId == id).ToList() ;
            }
        }
        public List<Product> GetAllByName(string key)
        {
            using (MarketContext context = new MarketContext())
            {
                return context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }

        public void Add(Product product)
        {
            using (MarketContext context = new MarketContext())
            {
                var addedProduct = context.Entry(product);
                addedProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (MarketContext context = new MarketContext())
            {
                var updatedProduct = context.Entry(product);
                updatedProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (MarketContext context = new MarketContext())
            {
                var deletedProduct = context.Entry(product);
                deletedProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
                
        }

        
    }

}
