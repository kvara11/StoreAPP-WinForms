﻿
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
            this.grdListEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdListEmployees.Name = "grdListEmployees";
            this.grdListEmployees.ReadOnly = true;
            this.grdListEmployees.RowHeadersWidth = 51;
            this.grdListEmployees.RowTemplate.Height = 25;
            this.grdListEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListEmployees.Size = new System.Drawing.Size(734, 472);
            this.grdListEmployees.TabIndex = 0;
            this.grdListEmployees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdListEmployees_MouseClick);
            // 
            // cntxMenuEmpl
            // 
            this.cntxMenuEmpl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxMenuEmpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cntxMenuEmpl.Name = "cntxMenu";
            this.cntxMenuEmpl.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 472);
            this.ContextMenuStrip = this.cntxMenuEmpl;
            this.Controls.Add(this.grdListEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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