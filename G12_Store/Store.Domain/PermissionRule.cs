using System;

namespace Store.Domain
{
    public class PermissionRule
    {
        public int PermissionGroupID { get; set; }
        public int PermissionID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
