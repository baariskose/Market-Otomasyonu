using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketData
{
    public class ProductSell
    {
        [Key]
        public int OrderId { get; set; }
        public string Products { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string UnderCity { get; set; }
        public string Hood { get; set; }
        public string Street { get; set; }
        public string UnderStreet { get; set; }
        public string House { get; set; }
        public string HouseNo { get; set; }
        public string PostCode { get; set; }
        public string CardName { get; set; }
        public string CardNo { get; set; }
        public string Date { get; set; }
        public string SecurityCode { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalCostPrice { get; set; }

    }
}
