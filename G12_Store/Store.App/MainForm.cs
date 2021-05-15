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
            Controls.RenderByPermissions();
        }

        private void mnuEmployeesList_Click(object sender, System.EventArgs e)
        {
            CreateMdiForm<EmployeesListForm>();
        }

        private void CreateMdiForm<T>() where T: Form, new()
        {
            var form = new T();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuCascade_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); 
        }

        private void mnuHorizontal_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCloseAll_Click(object sender, System.EventArgs e)
        {
            while (MdiChildren.Length > 0)
            {
                MdiChildren[0].Close();
            }
        }
    }
}
