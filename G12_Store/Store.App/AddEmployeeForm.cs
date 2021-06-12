using Store.Domain;
using Store.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Store.App
{
    public partial class AddEmployeeForm : Form
    {
        private readonly int _id;
        private readonly EmployeeRepository _employeeRepository;
        private Employee _employee;

        public bool IsEditMode => _id != 0;

        public AddEmployeeForm()
        {
            InitializeComponent();

            _employeeRepository = new();
            _employee = new();
        }

        public AddEmployeeForm(int id) : this()
        {
            _id = id;

            if (IsEditMode)
            {
                btnOk.Text = "Update";
                LoadData();
            }
        }

        private void LoadData()
        {
            _employee = _employeeRepository.Get(_id);
            txtNewEmployeeFirstName.Text = _employee.FirstName;
            txtNewEmployeeLastName.Text = _employee.LastName;
            dateTimePicker.Value = _employee.BirthDate == DateTime.MinValue ? new DateTime(1999, 11, 11) : _employee.BirthDate;
            txtNewEmployeePhone.Text = _employee.Phone;
            txtNewEmployeePhone2.Text = _employee.Phone2;
            txtNewEmployeeCurrentAddress.Text = _employee.CurrentAddress;
            txtNewEmployeeLegalAddress.Text = _employee.LegalAddress;
            txtNewEmployeePostalCode.Text = _employee.PostalCode;
            txtNewEmployeeEmail.Text = _employee.Email;
            txtNewEmployeeIDnumber.Text = _employee.IdNumber;
            txtNewEmployeeIDserialnumber.Text = _employee.IdCardNumber;
            comboxNewEmployeeGender.Text = _employee.Gender;
        }

        private void SaveData()
        {
            FetchEmployee();

            if (!IsEditMode)
            {
                _employeeRepository.Add(_employee);
            }
            else
            {
                _employeeRepository.Edit(_employee);
            }
        }
        private void FetchEmployee()
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
            _employee.Gender = comboxNewEmployeeGender.Text;
        }

        private bool ValidateData()
        {
            FetchEmployee();
            ValidationContext context = new ValidationContext(_employee, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(_employee, context, errors, true))
            {
                string errorMessages = "";
                foreach (var item in errors)
                {
                    errorMessages += item.ErrorMessage + Environment.NewLine;
                }
                MessageBox.Show(errorMessages, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
