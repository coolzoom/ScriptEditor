﻿namespace ScriptEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picScriptEditor = new System.Windows.Forms.PictureBox();
            this.picEventEditor = new System.Windows.Forms.PictureBox();
            this.picGitLink = new System.Windows.Forms.PictureBox();
            this.picCastsEditor = new System.Windows.Forms.PictureBox();
            this.picConditionEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConditionEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // picScriptEditor
            // 
            this.picScriptEditor.BackColor = System.Drawing.Color.Transparent;
            this.picScriptEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.script_editor_button_black;
            this.picScriptEditor.InitialImage = null;
            this.picScriptEditor.Location = new System.Drawing.Point(56, 145);
            this.picScriptEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picScriptEditor.Name = "picScriptEditor";
            this.picScriptEditor.Size = new System.Drawing.Size(132, 95);
            this.picScriptEditor.TabIndex = 0;
            this.picScriptEditor.TabStop = false;
            this.picScriptEditor.Click += new System.EventHandler(this.picScriptEditor_Click);
            this.picScriptEditor.MouseEnter += new System.EventHandler(this.picScriptEditor_MouseEnter);
            this.picScriptEditor.MouseLeave += new System.EventHandler(this.picScriptEditor_MouseLeave);
            // 
            // picEventEditor
            // 
            this.picEventEditor.BackColor = System.Drawing.Color.Transparent;
            this.picEventEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.event_editor_button_black;
            this.picEventEditor.InitialImage = null;
            this.picEventEditor.Location = new System.Drawing.Point(258, 145);
            this.picEventEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picEventEditor.Name = "picEventEditor";
            this.picEventEditor.Size = new System.Drawing.Size(140, 95);
            this.picEventEditor.TabIndex = 1;
            this.picEventEditor.TabStop = false;
            this.picEventEditor.Click += new System.EventHandler(this.picEventEditor_Click);
            this.picEventEditor.MouseEnter += new System.EventHandler(this.picEventEditor_MouseEnter);
            this.picEventEditor.MouseLeave += new System.EventHandler(this.picEventEditor_MouseLeave);
            // 
            // picGitLink
            // 
            this.picGitLink.BackColor = System.Drawing.Color.Transparent;
            this.picGitLink.BackgroundImage = global::ScriptEditor.Properties.Resources.gitlink1;
            this.picGitLink.Location = new System.Drawing.Point(81, 85);
            this.picGitLink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picGitLink.Name = "picGitLink";
            this.picGitLink.Size = new System.Drawing.Size(302, 54);
            this.picGitLink.TabIndex = 2;
            this.picGitLink.TabStop = false;
            this.picGitLink.Click += new System.EventHandler(this.picGitLink_Click);
            this.picGitLink.MouseEnter += new System.EventHandler(this.picGitLink_MouseEnter);
            this.picGitLink.MouseLeave += new System.EventHandler(this.picGitLink_MouseLeave);
            // 
            // picCastsEditor
            // 
            this.picCastsEditor.BackColor = System.Drawing.Color.Transparent;
            this.picCastsEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.cast_editor_button_black;
            this.picCastsEditor.InitialImage = null;
            this.picCastsEditor.Location = new System.Drawing.Point(55, 285);
            this.picCastsEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCastsEditor.Name = "picCastsEditor";
            this.picCastsEditor.Size = new System.Drawing.Size(133, 96);
            this.picCastsEditor.TabIndex = 3;
            this.picCastsEditor.TabStop = false;
            this.picCastsEditor.Click += new System.EventHandler(this.picCastsEditor_Click);
            this.picCastsEditor.MouseEnter += new System.EventHandler(this.picCastsEditor_MouseEnter);
            this.picCastsEditor.MouseLeave += new System.EventHandler(this.picCastsEditor_MouseLeave);
            // 
            // picConditionEditor
            // 
            this.picConditionEditor.BackColor = System.Drawing.Color.Transparent;
            this.picConditionEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.condition_editor_button_black;
            this.picConditionEditor.InitialImage = null;
            this.picConditionEditor.Location = new System.Drawing.Point(258, 287);
            this.picConditionEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picConditionEditor.Name = "picConditionEditor";
            this.picConditionEditor.Size = new System.Drawing.Size(125, 94);
            this.picConditionEditor.TabIndex = 4;
            this.picConditionEditor.TabStop = false;
            this.picConditionEditor.Click += new System.EventHandler(this.picConditionEditor_Click);
            this.picConditionEditor.MouseEnter += new System.EventHandler(this.picConditionEditor_MouseEnter);
            this.picConditionEditor.MouseLeave += new System.EventHandler(this.picConditionEditor_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ScriptEditor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 471);
            this.Controls.Add(this.picConditionEditor);
            this.Controls.Add(this.picCastsEditor);
            this.Controls.Add(this.picGitLink);
            this.Controls.Add(this.picEventEditor);
            this.Controls.Add(this.picScriptEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            this.Text = "VMaNGOS Developer Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConditionEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScriptEditor;
        private System.Windows.Forms.PictureBox picEventEditor;
        private System.Windows.Forms.PictureBox picGitLink;
        private System.Windows.Forms.PictureBox picCastsEditor;
        private System.Windows.Forms.PictureBox picConditionEditor;
    }
}