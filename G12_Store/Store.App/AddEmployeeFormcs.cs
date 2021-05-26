using Store.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Repository;

namespace Store.App
{
    public partial class AddEmployeeFormcs : Form
    {
        public AddEmployeeFormcs()
        {
            InitializeComponent();
        }

        private void btnNewEmployeeSubmit_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employee();

            newEmployee.FirstName = txtNewEmployeeFirstName.Text;
            newEmployee.LastName = txtNewEmployeeLastName.Text;
            newEmployee.BirthDate = new DateTime(Convert.ToInt32(txtNewEmployeeYear.Text), Convert.ToInt32(txtNewEmployeeMonth.Text), Convert.ToInt32(txtNewEmployeeDay.Text));
            newEmployee.Phone = txtNewEmployeePhone.Text;
            newEmployee.Phone2 = txtNewEmployeePhone2.Text;
            newEmployee.CurrentAddress = txtNewEmployeeCurrentAddress.Text;
            newEmployee.LegalAddress = txtNewEmployeeLegalAddress.Text;
            newEmployee.PostalCode = txtNewEmployeePostalCode.Text;
            newEmployee.Email = txtNewEmployeeEmail.Text;
            newEmployee.IdNumber = txtNewEmployeeIDnumber.Text;
            newEmployee.IdCardNumber = txtNewEmployeeIDserialnumber.Text;
            newEmployee.DateRegister = new DateTime(1999, 11, 11);
            newEmployee.Gender = comboxNewEmployeeGender.Text.Contains("Male") ? "Male" : "Female";

            var empRep = new EmployeeRepository();
            empRep.Add(newEmployee);

        }

        private void btnNewEmployeeCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
