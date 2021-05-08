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
    }
}
