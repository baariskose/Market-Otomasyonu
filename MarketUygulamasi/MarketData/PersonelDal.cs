using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class PersonelDal
    {
        public List<Personel> GetAllPersonel()
        {
            using (MarketContext context = new MarketContext())
            {
                return context.Personels.ToList();
            }
        }
    }
}
