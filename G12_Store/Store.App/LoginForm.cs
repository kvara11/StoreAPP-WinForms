using Store.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Store.App
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new();
            _userRepository.UserLogin += id =>
            {
                LocalStorage.PermissionCodes = _userRepository.GetPermissions(id).ToList();
            };
#if DEBUG
            txtUsername.Text = "Malgusss";
            txtPassword.Text = "123";
#endif

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LocalStorage.LoggedUserID = _userRepository.Login(txtUsername.Text, txtPassword.Text, out string fullName, out string message);
            if (LocalStorage.LoggedUserID != -1)
            {
                LocalStorage.UserFullName = fullName;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
