using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
