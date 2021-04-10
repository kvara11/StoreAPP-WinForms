using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class StockImport
    {
        public int ID { get; set; }
        public DateTime ImportDate { get; set; }
        public int ProductID { get; set; }
        public int MeasurementID { get; set; }
        public int Quantity { get; set; }
        public int WharehousID { get; set; }
        public int SupervisorID { get; set; }
        public decimal StockPrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
