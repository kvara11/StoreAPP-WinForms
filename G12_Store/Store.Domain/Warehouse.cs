using System;

namespace Store.Domain
{
    public class Warehouse
    {
        public int ID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }
        public int Active { get; set; }
        public int IsDeleted { get; set; }
    }
}
