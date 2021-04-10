using System;

namespace Store.Domain
{
    public class PermissionGroups
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatorID { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
