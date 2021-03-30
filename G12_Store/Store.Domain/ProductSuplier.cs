using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class ProductSuplier
    {
        public int ID { get; set; }
        public string SuplierName { get; set; }
        public int SuplierGroupID { get; set; }
        public string VatID { get; set; }
        public string LegalAddress { get; set; }
        public string TransportationAddress { get; set; }
        public string PostalCode { get; set; }
        public string BankName { get; set; }
        public string IBAN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
