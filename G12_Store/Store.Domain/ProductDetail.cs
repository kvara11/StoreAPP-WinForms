using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class ProductDetail
    {
        public int ID { get; set; }
        public int ProducerCountryID { get; set; }
        public string Description { get; set; }
        public int SupplierID { get; set; }
        public int MeasurementID { get; set; }
    }
}
