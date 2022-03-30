using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class ProductSellDal
    {
     public void Add(ProductSell productSell)
        {
            using (MarketContext context = new MarketContext())
            {
                var addedProduct = context.Entry(productSell);
                addedProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public List<ProductSell> GetAll()
        {
            using (MarketContext context = new MarketContext())
            {
                return context.ProductSells.ToList();
            }
        }
    }
}
