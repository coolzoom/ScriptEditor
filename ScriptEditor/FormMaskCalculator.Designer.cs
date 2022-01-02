namespace ScriptEditor
{
    partial class FormMaskCalculator
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
            this.lblPhaseMaskTooltip = new System.Windows.Forms.Label();
            this.txtPhasesList = new System.Windows.Forms.TextBox();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnPhaseAdd = new System.Windows.Forms.Button();
            this.btnPhaseRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhaseMaskTooltip
            // 
            this.lblPhaseMaskTooltip.AutoSize = true;
            this.lblPhaseMaskTooltip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhaseMaskTooltip.Location = new System.Drawing.Point(8, 69);
            this.lblPhaseMaskTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhaseMaskTooltip.Name = "lblPhaseMaskTooltip";
            this.lblPhaseMaskTooltip.Size = new System.Drawing.Size(307, 18);
            this.lblPhaseMaskTooltip.TabIndex = 0;
            this.lblPhaseMaskTooltip.Text = "List of phases in which the event will not trigger:";
            // 
            // txtPhasesList
            // 
            this.txtPhasesList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhasesList.Location = new System.Drawing.Point(11, 87);
            this.txtPhasesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhasesList.Multiline = true;
            this.txtPhasesList.Name = "txtPhasesList";
            this.txtPhasesList.ReadOnly = true;
            this.txtPhasesList.Size = new System.Drawing.Size(402, 148);
            this.txtPhasesList.TabIndex = 1;
            // 
            // txtPhase
            // 
            this.txtPhase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhase.Location = new System.Drawing.Point(67, 243);
            this.txtPhase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.Size = new System.Drawing.Size(96, 26);
            this.txtPhase.TabIndex = 2;
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.Location = new System.Drawing.Point(8, 253);
            this.lblPhase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(49, 18);
            this.lblPhase.TabIndex = 3;
            this.lblPhase.Text = "Phase:";
            // 
            // btnPhaseAdd
            // 
            this.btnPhaseAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhaseAdd.Location = new System.Drawing.Point(178, 241);
            this.btnPhaseAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPhaseAdd.Name = "btnPhaseAdd";
            this.btnPhaseAdd.Size = new System.Drawing.Size(77, 27);
            this.btnPhaseAdd.TabIndex = 4;
            this.btnPhaseAdd.Text = "Add";
            this.btnPhaseAdd.UseVisualStyleBackColor = true;
            this.btnPhaseAdd.Click += new System.EventHandler(this.btnPhaseAdd_Click);
            // 
            // btnPhaseRemove
            // 
            this.btnPhaseRemove.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhaseRemove.Location = new System.Drawing.Point(263, 241);
            this.btnPhaseRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPhaseRemove.Name = "btnPhaseRemove";
            this.btnPhaseRemove.Size = new System.Drawing.Size(77, 27);
            this.btnPhaseRemove.TabIndex = 5;
            this.btnPhaseRemove.Text = "Remove";
            this.btnPhaseRemove.UseVisualStyleBackColor = true;
            this.btnPhaseRemove.Click += new System.EventHandler(this.btnPhaseRemove_Click);
            // 
            // FormMaskCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 283);
            this.Controls.Add(this.btnPhaseRemove);
            this.Controls.Add(this.btnPhaseAdd);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.txtPhase);
            this.Controls.Add(this.txtPhasesList);
            this.Controls.Add(this.lblPhaseMaskTooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMaskCalculator";
            this.Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inverse Phase Mask";
            this.Load += new System.EventHandler(this.FormMaskCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhaseMaskTooltip;
        private System.Windows.Forms.TextBox txtPhasesList;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Button btnPhaseAdd;
        private System.Windows.Forms.Button btnPhaseRemove;
    }
}