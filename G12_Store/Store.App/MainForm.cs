using Store.App.Interfaces;
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

        private void CreateMdiForm<T>() where T : Form, new()
        {
            var form = new T();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuEmployeesList_Click(object sender, System.EventArgs e)
        {
            CreateMdiForm<EmployeesListForm>();
        }

        private void mnuProductsList_Click(object sender, System.EventArgs e)
        {
            CreateMdiForm<ProductListForm>();
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

        private void newToolStripButton_Click(object sender, System.EventArgs e)
        {
            (ActiveMdiChild as IListForm)?.Add();
        }

        private void ShowAddForm<TForm, TList>()
            where TForm : Form, new()
            where TList : Form, IListForm
        {
            if (new TForm().ShowDialog() == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                {
                    //TODO: movifiqrot rogorme darefreshdes mxolod is forma romelic sachiroa.
                    (form as TList)?.RefreshData();
                }
            }
        }

        private void mnuAddEmploye_Click(object sender, System.EventArgs e) => ShowAddForm<AddEmployeeForm, EmployeesListForm>();
        
    }
}
