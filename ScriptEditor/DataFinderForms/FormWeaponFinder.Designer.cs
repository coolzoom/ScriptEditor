namespace ScriptEditor
{
    partial class FormWeaponFinder
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
            this.columnInventoryType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDisplayId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnInventoryType,
            this.columnDisplayId,
            this.columnName});
            this.lstData.Location = new System.Drawing.Point(7, 103);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 73);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 70);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(666, 461);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 48);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(774, 461);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(540, 461);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(399, 461);
            // 
            // columnInventoryType
            // 
            this.columnInventoryType.Text = "Type";
            this.columnInventoryType.Width = 90;
            // 
            // columnDisplayId
            // 
            this.columnDisplayId.Text = "Display Id";
            this.columnDisplayId.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 415;
            // 
            // FormWeaponFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormWeaponFinder";
            this.Text = "Weapon Finder";
            this.ResizeEnd += new System.EventHandler(this.FormWeaponFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnInventoryType;
        private System.Windows.Forms.ColumnHeader columnDisplayId;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}
