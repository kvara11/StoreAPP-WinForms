using System;
using System.Windows.Forms;

namespace Store.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm();
            var result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
