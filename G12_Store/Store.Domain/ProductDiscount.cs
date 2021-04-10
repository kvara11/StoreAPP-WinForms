using System;

namespace Store.Domain
{
    public class ProductDiscount
    {
        public int ProductID { get; set; }
        public int PriceModifierID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
