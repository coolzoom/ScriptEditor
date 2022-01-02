namespace ScriptEditor
{
    partial class FormClassMask
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
            this.lblTooltip = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkClass1 = new System.Windows.Forms.CheckBox();
            this.chkClass2 = new System.Windows.Forms.CheckBox();
            this.chkClass4 = new System.Windows.Forms.CheckBox();
            this.chkClass8 = new System.Windows.Forms.CheckBox();
            this.chkClass256 = new System.Windows.Forms.CheckBox();
            this.chkClass128 = new System.Windows.Forms.CheckBox();
            this.chkClass64 = new System.Windows.Forms.CheckBox();
            this.chkClass16 = new System.Windows.Forms.CheckBox();
            this.chkClass1024 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTooltip
            // 
            this.lblTooltip.AutoSize = true;
            this.lblTooltip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooltip.Location = new System.Drawing.Point(16, 10);
            this.lblTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(353, 18);
            this.lblTooltip.TabIndex = 10;
            this.lblTooltip.Text = "Select the classes you would like to include in the mask.";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(91, 195);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 27);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(199, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkClass1
            // 
            this.chkClass1.AutoSize = true;
            this.chkClass1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass1.Location = new System.Drawing.Point(20, 44);
            this.chkClass1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass1.Name = "chkClass1";
            this.chkClass1.Size = new System.Drawing.Size(76, 22);
            this.chkClass1.TabIndex = 13;
            this.chkClass1.Text = "Warrior";
            this.chkClass1.UseVisualStyleBackColor = true;
            this.chkClass1.CheckedChanged += new System.EventHandler(this.chkClass1_CheckedChanged);
            // 
            // chkClass2
            // 
            this.chkClass2.AutoSize = true;
            this.chkClass2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass2.Location = new System.Drawing.Point(108, 44);
            this.chkClass2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass2.Name = "chkClass2";
            this.chkClass2.Size = new System.Drawing.Size(76, 22);
            this.chkClass2.TabIndex = 14;
            this.chkClass2.Text = "Paladin";
            this.chkClass2.UseVisualStyleBackColor = true;
            this.chkClass2.CheckedChanged += new System.EventHandler(this.chkClass2_CheckedChanged);
            // 
            // chkClass4
            // 
            this.chkClass4.AutoSize = true;
            this.chkClass4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass4.Location = new System.Drawing.Point(196, 44);
            this.chkClass4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass4.Name = "chkClass4";
            this.chkClass4.Size = new System.Drawing.Size(73, 22);
            this.chkClass4.TabIndex = 15;
            this.chkClass4.Text = "Hunter";
            this.chkClass4.UseVisualStyleBackColor = true;
            this.chkClass4.CheckedChanged += new System.EventHandler(this.chkClass4_CheckedChanged);
            // 
            // chkClass8
            // 
            this.chkClass8.AutoSize = true;
            this.chkClass8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass8.Location = new System.Drawing.Point(284, 44);
            this.chkClass8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass8.Name = "chkClass8";
            this.chkClass8.Size = new System.Drawing.Size(69, 22);
            this.chkClass8.TabIndex = 16;
            this.chkClass8.Text = "Rogue";
            this.chkClass8.UseVisualStyleBackColor = true;
            this.chkClass8.CheckedChanged += new System.EventHandler(this.chkClass8_CheckedChanged);
            // 
            // chkClass256
            // 
            this.chkClass256.AutoSize = true;
            this.chkClass256.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass256.Location = new System.Drawing.Point(284, 84);
            this.chkClass256.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass256.Name = "chkClass256";
            this.chkClass256.Size = new System.Drawing.Size(79, 22);
            this.chkClass256.TabIndex = 20;
            this.chkClass256.Text = "Warlock";
            this.chkClass256.UseVisualStyleBackColor = true;
            this.chkClass256.CheckedChanged += new System.EventHandler(this.chkClass256_CheckedChanged);
            // 
            // chkClass128
            // 
            this.chkClass128.AutoSize = true;
            this.chkClass128.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass128.Location = new System.Drawing.Point(196, 84);
            this.chkClass128.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass128.Name = "chkClass128";
            this.chkClass128.Size = new System.Drawing.Size(64, 22);
            this.chkClass128.TabIndex = 19;
            this.chkClass128.Text = "Mage";
            this.chkClass128.UseVisualStyleBackColor = true;
            this.chkClass128.CheckedChanged += new System.EventHandler(this.chkClass128_CheckedChanged);
            // 
            // chkClass64
            // 
            this.chkClass64.AutoSize = true;
            this.chkClass64.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass64.Location = new System.Drawing.Point(108, 84);
            this.chkClass64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass64.Name = "chkClass64";
            this.chkClass64.Size = new System.Drawing.Size(79, 22);
            this.chkClass64.TabIndex = 18;
            this.chkClass64.Text = "Shaman";
            this.chkClass64.UseVisualStyleBackColor = true;
            this.chkClass64.CheckedChanged += new System.EventHandler(this.chkClass64_CheckedChanged);
            // 
            // chkClass16
            // 
            this.chkClass16.AutoSize = true;
            this.chkClass16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass16.Location = new System.Drawing.Point(20, 84);
            this.chkClass16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass16.Name = "chkClass16";
            this.chkClass16.Size = new System.Drawing.Size(66, 22);
            this.chkClass16.TabIndex = 17;
            this.chkClass16.Text = "Priest";
            this.chkClass16.UseVisualStyleBackColor = true;
            this.chkClass16.CheckedChanged += new System.EventHandler(this.chkClass16_CheckedChanged);
            // 
            // chkClass1024
            // 
            this.chkClass1024.AutoSize = true;
            this.chkClass1024.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClass1024.Location = new System.Drawing.Point(156, 125);
            this.chkClass1024.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClass1024.Name = "chkClass1024";
            this.chkClass1024.Size = new System.Drawing.Size(64, 22);
            this.chkClass1024.TabIndex = 21;
            this.chkClass1024.Text = "Druid";
            this.chkClass1024.UseVisualStyleBackColor = true;
            this.chkClass1024.CheckedChanged += new System.EventHandler(this.chkClass1024_CheckedChanged);
            // 
            // FormClassMask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 268);
            this.ControlBox = false;
            this.Controls.Add(this.chkClass1024);
            this.Controls.Add(this.chkClass256);
            this.Controls.Add(this.chkClass128);
            this.Controls.Add(this.chkClass64);
            this.Controls.Add(this.chkClass16);
            this.Controls.Add(this.chkClass8);
            this.Controls.Add(this.chkClass4);
            this.Controls.Add(this.chkClass2);
            this.Controls.Add(this.chkClass1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClassMask";
            this.Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            this.Text = "Class Mask Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTooltip;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkClass1;
        private System.Windows.Forms.CheckBox chkClass2;
        private System.Windows.Forms.CheckBox chkClass4;
        private System.Windows.Forms.CheckBox chkClass8;
        private System.Windows.Forms.CheckBox chkClass256;
        private System.Windows.Forms.CheckBox chkClass128;
        private System.Windows.Forms.CheckBox chkClass64;
        private System.Windows.Forms.CheckBox chkClass16;
        private System.Windows.Forms.CheckBox chkClass1024;
    }
}