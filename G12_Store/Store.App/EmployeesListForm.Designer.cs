
namespace Store.App
{
    partial class EmployeesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdListEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListEmployees
            // 
            this.grdListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListEmployees.Location = new System.Drawing.Point(0, 0);
            this.grdListEmployees.Name = "grdListEmployees";
            this.grdListEmployees.RowTemplate.Height = 25;
            this.grdListEmployees.Size = new System.Drawing.Size(642, 354);
            this.grdListEmployees.TabIndex = 0;
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 354);
            this.Controls.Add(this.grdListEmployees);
            this.Name = "EmployeesListForm";
            this.Text = "EmployeesListForm";
            this.Load += new System.EventHandler(this.EmployeesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListEmployees;
    }
}