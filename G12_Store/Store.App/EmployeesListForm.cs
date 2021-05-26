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
using Store.Repository;

namespace Store.App
{
    public partial class EmployeesListForm : Form, IListForm
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeesListForm()
        {
            InitializeComponent();
            _employeeRepository = new EmployeeRepository();
            grdListEmployees.DataSource = _employeeRepository.Select().ToList();
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

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
        }
    }
}
