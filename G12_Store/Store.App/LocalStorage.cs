using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App
{
   public static class LocalStorage
    {
        public static int LoggedUserID { get; set; }
        public static string UserFullName { get; set; }
        public static IEnumerable<short> PermissionCodes { get; set; } = new List<short>();
    }
}
