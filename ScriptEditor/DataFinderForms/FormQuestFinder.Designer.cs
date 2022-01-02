﻿namespace ScriptEditor
{
    partial class FormQuestFinder
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
            this.columnMinLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMinLevel,
            this.columnQuestLevel,
            this.columnTitle});
            this.lstData.Location = new System.Drawing.Point(7, 111);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 78);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(666, 469);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 56);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(774, 469);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(540, 469);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(399, 469);
            // 
            // columnMinLevel
            // 
            this.columnMinLevel.Text = "Minimum Level";
            this.columnMinLevel.Width = 90;
            // 
            // columnQuestLevel
            // 
            this.columnQuestLevel.Text = "Quest Level";
            this.columnQuestLevel.Width = 90;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 415;
            // 
            // FormQuestFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormQuestFinder";
            this.Text = "Quest Finder";
            this.ResizeEnd += new System.EventHandler(this.FormQuestFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnMinLevel;
        private System.Windows.Forms.ColumnHeader columnQuestLevel;
        private System.Windows.Forms.ColumnHeader columnTitle;
    }
}
