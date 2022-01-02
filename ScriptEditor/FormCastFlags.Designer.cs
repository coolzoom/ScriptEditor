namespace ScriptEditor
{
    partial class FormCastFlags
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
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.chkCastFlag256 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag128 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag64 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag32 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag16 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag8 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag4 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag2 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag1 = new System.Windows.Forms.CheckBox();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.txtTargetParam1 = new System.Windows.Forms.TextBox();
            this.txtTargetParam2 = new System.Windows.Forms.TextBox();
            this.lblTargetParam1 = new System.Windows.Forms.Label();
            this.lblTargetParam2 = new System.Windows.Forms.Label();
            this.grpTargetParams = new System.Windows.Forms.GroupBox();
            this.btnTargetParam1 = new System.Windows.Forms.Button();
            this.grpFlags.SuspendLayout();
            this.grpTargetParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.chkCastFlag256);
            this.grpFlags.Controls.Add(this.chkCastFlag128);
            this.grpFlags.Controls.Add(this.chkCastFlag64);
            this.grpFlags.Controls.Add(this.chkCastFlag32);
            this.grpFlags.Controls.Add(this.chkCastFlag16);
            this.grpFlags.Controls.Add(this.chkCastFlag8);
            this.grpFlags.Controls.Add(this.chkCastFlag4);
            this.grpFlags.Controls.Add(this.chkCastFlag2);
            this.grpFlags.Controls.Add(this.chkCastFlag1);
            this.grpFlags.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlags.Location = new System.Drawing.Point(19, 64);
            this.grpFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFlags.Size = new System.Drawing.Size(357, 168);
            this.grpFlags.TabIndex = 0;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Cast Flags";
            // 
            // chkCastFlag256
            // 
            this.chkCastFlag256.AutoSize = true;
            this.chkCastFlag256.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag256.Location = new System.Drawing.Point(8, 138);
            this.chkCastFlag256.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag256.Name = "chkCastFlag256";
            this.chkCastFlag256.Size = new System.Drawing.Size(115, 22);
            this.chkCastFlag256.TabIndex = 8;
            this.chkCastFlag256.Text = "Target Casting";
            this.chkCastFlag256.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag128
            // 
            this.chkCastFlag128.AutoSize = true;
            this.chkCastFlag128.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag128.Location = new System.Drawing.Point(205, 112);
            this.chkCastFlag128.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag128.Name = "chkCastFlag128";
            this.chkCastFlag128.Size = new System.Drawing.Size(111, 22);
            this.chkCastFlag128.TabIndex = 7;
            this.chkCastFlag128.Text = "Not In Melee";
            this.chkCastFlag128.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag64
            // 
            this.chkCastFlag64.AutoSize = true;
            this.chkCastFlag64.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag64.Location = new System.Drawing.Point(8, 112);
            this.chkCastFlag64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag64.Name = "chkCastFlag64";
            this.chkCastFlag64.Size = new System.Drawing.Size(117, 22);
            this.chkCastFlag64.TabIndex = 6;
            this.chkCastFlag64.Text = "Only In Melee";
            this.chkCastFlag64.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag32
            // 
            this.chkCastFlag32.AutoSize = true;
            this.chkCastFlag32.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag32.Location = new System.Drawing.Point(205, 85);
            this.chkCastFlag32.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag32.Name = "chkCastFlag32";
            this.chkCastFlag32.Size = new System.Drawing.Size(136, 22);
            this.chkCastFlag32.TabIndex = 5;
            this.chkCastFlag32.Text = "Aura Not Present";
            this.chkCastFlag32.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag16
            // 
            this.chkCastFlag16.AutoSize = true;
            this.chkCastFlag16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag16.Location = new System.Drawing.Point(8, 85);
            this.chkCastFlag16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag16.Name = "chkCastFlag16";
            this.chkCastFlag16.Size = new System.Drawing.Size(149, 22);
            this.chkCastFlag16.TabIndex = 4;
            this.chkCastFlag16.Text = "Target Unreachable";
            this.chkCastFlag16.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag8
            // 
            this.chkCastFlag8.AutoSize = true;
            this.chkCastFlag8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag8.Location = new System.Drawing.Point(8, 59);
            this.chkCastFlag8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag8.Name = "chkCastFlag8";
            this.chkCastFlag8.Size = new System.Drawing.Size(144, 22);
            this.chkCastFlag8.TabIndex = 3;
            this.chkCastFlag8.Text = "Main Ranged Spell";
            this.chkCastFlag8.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag4
            // 
            this.chkCastFlag4.AutoSize = true;
            this.chkCastFlag4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag4.Location = new System.Drawing.Point(205, 59);
            this.chkCastFlag4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag4.Name = "chkCastFlag4";
            this.chkCastFlag4.Size = new System.Drawing.Size(93, 22);
            this.chkCastFlag4.TabIndex = 2;
            this.chkCastFlag4.Text = "Force Cast";
            this.chkCastFlag4.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag2
            // 
            this.chkCastFlag2.AutoSize = true;
            this.chkCastFlag2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag2.Location = new System.Drawing.Point(205, 32);
            this.chkCastFlag2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag2.Name = "chkCastFlag2";
            this.chkCastFlag2.Size = new System.Drawing.Size(88, 22);
            this.chkCastFlag2.TabIndex = 1;
            this.chkCastFlag2.Text = "Triggered";
            this.chkCastFlag2.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag1
            // 
            this.chkCastFlag1.AutoSize = true;
            this.chkCastFlag1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCastFlag1.Location = new System.Drawing.Point(8, 32);
            this.chkCastFlag1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCastFlag1.Name = "chkCastFlag1";
            this.chkCastFlag1.Size = new System.Drawing.Size(143, 22);
            this.chkCastFlag1.TabIndex = 0;
            this.chkCastFlag1.Text = "Interrupt Previous";
            this.chkCastFlag1.UseVisualStyleBackColor = true;
            // 
            // txtScriptId
            // 
            this.txtScriptId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptId.Location = new System.Drawing.Point(96, 320);
            this.txtScriptId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtScriptId.MinimumSize = new System.Drawing.Size(4, 23);
            this.txtScriptId.Name = "txtScriptId";
            this.txtScriptId.Size = new System.Drawing.Size(180, 26);
            this.txtScriptId.TabIndex = 1;
            // 
            // btnEditScript
            // 
            this.btnEditScript.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditScript.Location = new System.Drawing.Point(286, 320);
            this.btnEditScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(91, 27);
            this.btnEditScript.TabIndex = 2;
            this.btnEditScript.Text = "Edit";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScriptId.Location = new System.Drawing.Point(26, 324);
            this.lblScriptId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(62, 18);
            this.lblScriptId.TabIndex = 3;
            this.lblScriptId.Text = "Script Id:";
            // 
            // txtTargetParam1
            // 
            this.txtTargetParam1.Enabled = false;
            this.txtTargetParam1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetParam1.Location = new System.Drawing.Point(21, 36);
            this.txtTargetParam1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTargetParam1.Name = "txtTargetParam1";
            this.txtTargetParam1.Size = new System.Drawing.Size(145, 26);
            this.txtTargetParam1.TabIndex = 4;
            // 
            // txtTargetParam2
            // 
            this.txtTargetParam2.Enabled = false;
            this.txtTargetParam2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetParam2.Location = new System.Drawing.Point(191, 36);
            this.txtTargetParam2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTargetParam2.Name = "txtTargetParam2";
            this.txtTargetParam2.Size = new System.Drawing.Size(145, 26);
            this.txtTargetParam2.TabIndex = 5;
            // 
            // lblTargetParam1
            // 
            this.lblTargetParam1.AutoSize = true;
            this.lblTargetParam1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetParam1.Location = new System.Drawing.Point(17, 16);
            this.lblTargetParam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetParam1.Name = "lblTargetParam1";
            this.lblTargetParam1.Size = new System.Drawing.Size(36, 18);
            this.lblTargetParam1.TabIndex = 6;
            this.lblTargetParam1.Text = "N/A:";
            // 
            // lblTargetParam2
            // 
            this.lblTargetParam2.AutoSize = true;
            this.lblTargetParam2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetParam2.Location = new System.Drawing.Point(187, 17);
            this.lblTargetParam2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetParam2.Name = "lblTargetParam2";
            this.lblTargetParam2.Size = new System.Drawing.Size(36, 18);
            this.lblTargetParam2.TabIndex = 7;
            this.lblTargetParam2.Text = "N/A:";
            // 
            // grpTargetParams
            // 
            this.grpTargetParams.Controls.Add(this.btnTargetParam1);
            this.grpTargetParams.Controls.Add(this.txtTargetParam1);
            this.grpTargetParams.Controls.Add(this.lblTargetParam2);
            this.grpTargetParams.Controls.Add(this.lblTargetParam1);
            this.grpTargetParams.Controls.Add(this.txtTargetParam2);
            this.grpTargetParams.Enabled = false;
            this.grpTargetParams.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTargetParams.Location = new System.Drawing.Point(19, 239);
            this.grpTargetParams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTargetParams.Name = "grpTargetParams";
            this.grpTargetParams.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTargetParams.Size = new System.Drawing.Size(357, 69);
            this.grpTargetParams.TabIndex = 8;
            this.grpTargetParams.TabStop = false;
            // 
            // btnTargetParam1
            // 
            this.btnTargetParam1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTargetParam1.Location = new System.Drawing.Point(21, 36);
            this.btnTargetParam1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTargetParam1.Name = "btnTargetParam1";
            this.btnTargetParam1.Size = new System.Drawing.Size(147, 23);
            this.btnTargetParam1.TabIndex = 8;
            this.btnTargetParam1.Text = "-NONE-";
            this.btnTargetParam1.UseVisualStyleBackColor = true;
            this.btnTargetParam1.Visible = false;
            this.btnTargetParam1.Click += new System.EventHandler(this.btnSelectFlags_Click);
            // 
            // FormCastFlags
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.grpTargetParams);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.grpFlags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormCastFlags";
            this.Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional Settings";
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.grpTargetParams.ResumeLayout(false);
            this.grpTargetParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.CheckBox chkCastFlag32;
        private System.Windows.Forms.CheckBox chkCastFlag16;
        private System.Windows.Forms.CheckBox chkCastFlag8;
        private System.Windows.Forms.CheckBox chkCastFlag4;
        private System.Windows.Forms.CheckBox chkCastFlag2;
        private System.Windows.Forms.CheckBox chkCastFlag1;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.Button btnEditScript;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.TextBox txtTargetParam1;
        private System.Windows.Forms.TextBox txtTargetParam2;
        private System.Windows.Forms.Label lblTargetParam1;
        private System.Windows.Forms.Label lblTargetParam2;
        private System.Windows.Forms.GroupBox grpTargetParams;
        private System.Windows.Forms.CheckBox chkCastFlag128;
        private System.Windows.Forms.CheckBox chkCastFlag64;
        private System.Windows.Forms.CheckBox chkCastFlag256;
        private System.Windows.Forms.Button btnTargetParam1;
    }
}