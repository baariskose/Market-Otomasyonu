using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class CategoryDal
    {
        public List<Category> GetAll()
        {
            using (MarketContext context = new MarketContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
