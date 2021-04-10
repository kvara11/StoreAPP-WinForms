using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int ProductDetailsID { get; set; }
        public int ProductCategoyID { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal StockPrice { get; set; }
        public decimal Price { get; set; }
        public int PriceModifierID { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
