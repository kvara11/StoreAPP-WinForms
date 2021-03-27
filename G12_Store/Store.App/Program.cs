using Store.Domain;
using Store.Repository;
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
            //Application.Run(new Form1());


            var userRep = new UserRepository();
            var user1 = new User() { ID = 2, Username = "Malgusss", Password = "123", PermissionGroupID = 1 };
            //userRep.Add(user1);
            //userRep.Edit(user1);
            //userRep.Delete(user1);
            //var userID = userRep.Login(user1.Username, user1.Password, out string message);
        }
    }
}
