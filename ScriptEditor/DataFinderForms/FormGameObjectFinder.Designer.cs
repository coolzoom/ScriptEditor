namespace ScriptEditor.DataFinderForms
{
    partial class FormGameObjectFinder
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
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDisplayId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnDisplayId,
            this.columnName});
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
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.Text = "Enter name or Id to search for:";
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
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 90;
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
            // FormGameObjectFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormGameObjectFinder";
            this.ResizeEnd += new System.EventHandler(this.FormGameObjectFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDisplayId;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}
