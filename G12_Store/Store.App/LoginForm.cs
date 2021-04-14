﻿using System;
using System.Windows.Forms;
using Store.Repository;

namespace Store.App
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LocalStorage.LoggedUserID = _userRepository.Login(txtUsername.Text, txtPassword.Text, out string message);
            if (LocalStorage.LoggedUserID != -1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
