﻿namespace CRM.Helpers.DataBaseInteraction.Events
{
    partial class AddEvent
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
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMBX_Type = new System.Windows.Forms.ComboBox();
            this.TXTB_Date = new System.Windows.Forms.TextBox();
            this.TXTB_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(555, 218);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(208, 105);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(555, 66);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(208, 105);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Add Event";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(85, 180);
            this.CMBX_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(392, 33);
            this.CMBX_Type.TabIndex = 5;
            // 
            // TXTB_Date
            // 
            this.TXTB_Date.Location = new System.Drawing.Point(85, 84);
            this.TXTB_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Date.Name = "TXTB_Date";
            this.TXTB_Date.Size = new System.Drawing.Size(392, 31);
            this.TXTB_Date.TabIndex = 6;
            // 
            // TXTB_Description
            // 
            this.TXTB_Description.Location = new System.Drawing.Point(85, 288);
            this.TXTB_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Description.Name = "TXTB_Description";
            this.TXTB_Description.Size = new System.Drawing.Size(392, 31);
            this.TXTB_Description.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTB_Description);
            this.Controls.Add(this.TXTB_Date);
            this.Controls.Add(this.CMBX_Type);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Cancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMBX_Type;
        private System.Windows.Forms.TextBox TXTB_Date;
        private System.Windows.Forms.TextBox TXTB_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}