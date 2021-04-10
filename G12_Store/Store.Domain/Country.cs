using System;

namespace Store.Domain
{
    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
