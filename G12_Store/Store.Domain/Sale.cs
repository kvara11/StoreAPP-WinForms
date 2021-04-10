using System;

namespace Store.Domain
{
    public class Sale
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime SaleDate { get; set; }
        public int SalesPersonID { get; set; }
        public bool Cancelled { get; set; }
    }
}
