using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.App
{
    static class PermissionHelper
    {
        public static void RenderByPermissions(this Control.ControlCollection controls)
        {
            short[] GetControlPermissions(Control control)
            {
                string[] permissionsStr = control.Tag.ToString().Split(',');
                short[] permissions = new short[permissionsStr.Length];
                for (int i = 0; i < permissionsStr.Length; i++)
                {
                    permissions[i] = short.Parse(permissionsStr[i]);
                }
                return permissions;
            }

            foreach (Control control in controls)
            {
                if (string.IsNullOrEmpty(control.Tag?.ToString()))
                    continue;
                short[] controlPermissions = GetControlPermissions(control);

                if (LocalStorage.PermissionCodes.Intersect(controlPermissions).Count() == 0)
                {
                    control.Visible = false;
                }
            }
        }
    }
}
