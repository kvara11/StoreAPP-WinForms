using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.App.Interfaces;

namespace Store.App
{
    public partial class EmployeesListForm : Form, IListForm
    {
        public EmployeesListForm()
        {
            InitializeComponent();
        }

        public void Add()
        {
            var newEmpForm = new AddEmployeeFormcs();
            newEmpForm.Show();
        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }
    }
}
