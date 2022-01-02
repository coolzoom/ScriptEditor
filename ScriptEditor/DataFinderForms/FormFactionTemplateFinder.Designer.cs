﻿namespace ScriptEditor
{
    partial class FormFactionTemplateFinder
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
            this.columnFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFactionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFactionId,
            this.columnFlags,
            this.columnName,
            this.columnDescription});
            this.lstData.Location = new System.Drawing.Point(7, 119);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 86);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(666, 477);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 64);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(774, 477);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(540, 477);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(399, 477);
            // 
            // columnFlags
            // 
            this.columnFlags.Text = "Flags";
            this.columnFlags.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 265;
            // 
            // columnFactionId
            // 
            this.columnFactionId.Text = "Faction ID";
            this.columnFactionId.Width = 90;
            // 
            // FormFactionTemplateFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormFactionTemplateFinder";
            this.Text = "Faction Template Finder";
            this.ResizeEnd += new System.EventHandler(this.FormFactionTemplateFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnFlags;
        private System.Windows.Forms.ColumnHeader columnFactionId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
    }
}
