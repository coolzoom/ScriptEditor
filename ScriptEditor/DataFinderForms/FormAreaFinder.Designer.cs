namespace ScriptEditor
{
    partial class FormAreaFinder
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
            this.columnMap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMap,
            this.columnZone,
            this.columnName});
            this.lstData.Location = new System.Drawing.Point(7, 129);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 99);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 96);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(666, 487);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 74);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(774, 487);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(540, 487);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(399, 487);
            // 
            // columnMap
            // 
            this.columnMap.Text = "Map";
            this.columnMap.Width = 90;
            // 
            // columnZone
            // 
            this.columnZone.Text = "Zone";
            this.columnZone.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 415;
            // 
            // FormAreaFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormAreaFinder";
            this.Text = "Area Finder";
            this.ResizeEnd += new System.EventHandler(this.FormAreaFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnMap;
        private System.Windows.Forms.ColumnHeader columnZone;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}
