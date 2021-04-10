using System;

namespace Store.Domain
{
    public class Stock
    {
        public int ProductID { get; set; }
        public DateTime StockDate { get; set; }
        public int MeasurementID { get; set; }
        public decimal Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public bool Damaged { get; set; }
        public bool ForSale { get; set; }
    }
}
