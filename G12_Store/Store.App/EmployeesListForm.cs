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
			grdListEmployees.Columns[0].Visible = false;
			grdListEmployees.Columns[0].Frozen = true;
			grdListEmployees.Columns[1].Frozen = true;
			grdListEmployees.Columns[2].Frozen = true;
			grdListEmployees.Columns[grdListEmployees.Columns.Count - 1].Visible = false;
		}

		private int SelectedID => (int)grdListEmployees.SelectedRows[0].Cells[0].Value;

		public void Add()
		{
			var employeeForm = new AddEmployeeForm();
			employeeForm.ShowDialog();
		}

		public void Edit()
		{
			int id = SelectedID;
			var employeeForm = new AddEmployeeForm(id);
			employeeForm.ShowDialog();
		}

		public void Delete()
		{

		}

        private void grdListEmployees_MouseClick(object sender, MouseEventArgs e)
        {
			//int position = grdListEmployees.HitTest(e.X, e.Y).RowIndex;

			//if (e.Button == MouseButtons.Left && position >= 0)
			//{
			//	cntxMenuEmpl.Show(grdListEmployees, new Point(e.X, e.Y));
   //         }
   //         else
   //         {
			//	cntxMenuEmpl.Hide();
   //         }
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Edit();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Delete();
		}
	}
}
