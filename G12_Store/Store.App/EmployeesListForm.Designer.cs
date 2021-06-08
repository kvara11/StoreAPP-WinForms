
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
            this.components = new System.ComponentModel.Container();
            this.grdListEmployees = new System.Windows.Forms.DataGridView();
            this.cntxMenuEmpl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployees)).BeginInit();
            this.cntxMenuEmpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdListEmployees
            // 
            this.grdListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListEmployees.ContextMenuStrip = this.cntxMenuEmpl;
            this.grdListEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListEmployees.Location = new System.Drawing.Point(0, 0);
            this.grdListEmployees.MultiSelect = false;
            this.grdListEmployees.Name = "grdListEmployees";
            this.grdListEmployees.ReadOnly = true;
            this.grdListEmployees.RowHeadersWidth = 51;
            this.grdListEmployees.RowTemplate.Height = 25;
            this.grdListEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListEmployees.Size = new System.Drawing.Size(642, 354);
            this.grdListEmployees.TabIndex = 0;
            this.grdListEmployees.DoubleClick += new System.EventHandler(this.editToolStripMenuItem_Click);
            this.grdListEmployees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdListEmployees_MouseClick);
            this.grdListEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdListEmployees_MouseDown);
            // 
            // cntxMenuEmpl
            // 
            this.cntxMenuEmpl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxMenuEmpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cntxMenuEmpl.Name = "cntxMenu";
            this.cntxMenuEmpl.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 354);
            this.ContextMenuStrip = this.cntxMenuEmpl;
            this.Controls.Add(this.grdListEmployees);
            this.Name = "EmployeesListForm";
            this.Text = "EmployeesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployees)).EndInit();
            this.cntxMenuEmpl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListEmployees;
        private System.Windows.Forms.ContextMenuStrip cntxMenuEmpl;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}