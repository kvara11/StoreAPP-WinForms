using System;

namespace Store.Domain
{
    public class ProductPriceModifier
    {
        public int ID { get; set; }
        public string ModifierName { get; set; }
        public string ModifierTypes { get; set; }
        public int ModifierRate { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
    }
}
