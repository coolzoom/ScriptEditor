namespace ScriptEditor
{
    partial class FormSpellFinder
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
            this.columnEffect1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEffect2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEffect3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEffect1,
            this.columnEffect2,
            this.columnEffect3,
            this.columnName,
            this.columnDescription});
            this.lstData.Location = new System.Drawing.Point(7, 105);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 72);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(666, 463);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 50);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(774, 463);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(540, 463);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(399, 463);
            // 
            // columnEffect1
            // 
            this.columnEffect1.Text = "Effect 1";
            this.columnEffect1.Width = 90;
            // 
            // columnEffect2
            // 
            this.columnEffect2.Text = "Effect 2";
            this.columnEffect2.Width = 90;
            // 
            // columnEffect3
            // 
            this.columnEffect3.Text = "Effect 3";
            this.columnEffect3.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 175;
            // 
            // FormSpellFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormSpellFinder";
            this.Text = "Spell Finder";
            this.ResizeEnd += new System.EventHandler(this.FormSpellFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnEffect1;
        private System.Windows.Forms.ColumnHeader columnEffect2;
        private System.Windows.Forms.ColumnHeader columnEffect3;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
    }
}
