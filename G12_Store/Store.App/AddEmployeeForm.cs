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
    public partial class AddEmployeeForm : Form
    {
        private readonly int _id;
        private readonly EmployeeRepository _employeeRepository;
        private Employee _employee;

        public bool IsEditMode => _id != 0;

        public AddEmployeeForm(int id = 0)
        {
            InitializeComponent();
            _id = id;
            _employeeRepository = new();

            if (IsEditMode)
            {
                btnOk.Text = "Update";
                LoadData();
            }
            else
            {
                _employee = new();
            }
        }

        private void LoadData()
        {
            _employee = _employeeRepository.Get(_id);
            //wamovigot bazidan info da gamovitanot vizualur komponentebshi
        }

        private void SaveData()
        {
            _employee.FirstName = txtNewEmployeeFirstName.Text;
            _employee.LastName = txtNewEmployeeLastName.Text;
            _employee.BirthDate = dateTimePicker.Value;
            _employee.Phone = txtNewEmployeePhone.Text;
            _employee.Phone2 = txtNewEmployeePhone2.Text;
            _employee.CurrentAddress = txtNewEmployeeCurrentAddress.Text;
            _employee.LegalAddress = txtNewEmployeeLegalAddress.Text;
            _employee.PostalCode = txtNewEmployeePostalCode.Text;
            _employee.Email = txtNewEmployeeEmail.Text;
            _employee.IdNumber = txtNewEmployeeIDnumber.Text;
            _employee.IdCardNumber = txtNewEmployeeIDserialnumber.Text;
            _employee.DateRegister = new DateTime(1999, 11, 11);
            _employee.Gender = comboxNewEmployeeGender.Text.Contains("Male") ? "Male" : "Female";

            if (!IsEditMode)
            {
               _employeeRepository.Add(_employee);
            }
            else
            {
               _employeeRepository.Edit(_employee);
            }
        }

        private bool ValidateData()
        {
            //gadaamowmet sheyvanili info martebulobaze
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveData();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
