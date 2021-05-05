using Store.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text += $" ({LocalStorage.UserFullName})";

            //salesBtn.Tag = "0,1,9";
            RenderByPermissions();
        }

        private void RenderByPermissions()
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

            foreach (Control control in this.Controls)
            {
                if (control.Tag == null)
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
