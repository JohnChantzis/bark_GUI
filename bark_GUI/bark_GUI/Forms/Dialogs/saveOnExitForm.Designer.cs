﻿namespace bark_GUI
{
    partial class SaveOnExitForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(285, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(105, 71);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(87, 29);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.Location = new System.Drawing.Point(12, 71);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(87, 29);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(14, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(289, 45);
            this.label.TabIndex = 3;
            this.label.Text = "There are unsaved changes that will be lost. - Do you wish to Save these changes?" +
    "";
            // 
            // SaveOnExitForm
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.ControlBox = false;
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveOnExitForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unsaved Changes";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveOnExitForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label;
    }
}