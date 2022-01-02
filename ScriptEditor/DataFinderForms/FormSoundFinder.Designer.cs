namespace ScriptEditor
{
    partial class FormSoundFinder
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
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.lstData.Location = new System.Drawing.Point(11, 107);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(767, 74);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(670, 465);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 52);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(778, 465);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(544, 465);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(403, 465);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 595;
            // 
            // FormSoundFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 570);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(1213, 570);
            this.Name = "FormSoundFinder";
            this.Text = "Sound Finder";
            this.ResizeEnd += new System.EventHandler(this.FormSoundFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnName;
    }
}
