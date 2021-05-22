using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository
{
    public class PermissionRepository : BaseRepository<Permission>
    {
        public bool CheckPermission(int userID, int permissionID)
        {
            return (bool)_database.ExecuteScalar($"select dbo.HasUserPermission({userID} ,{permissionID})", System.Data.CommandType.Text);
            
        }

    }
}
