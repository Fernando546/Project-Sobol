namespace CRM.Helpers.DataBaseInteraction.Contracts
{
    partial class AddContract
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
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.TXTB_SignDate = new System.Windows.Forms.TextBox();
            this.TXTB_ExpireDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(357, 139);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(139, 67);
            this.BTN_Cancel.TabIndex = 1;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(357, 36);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Add Contract";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(50, 47);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(263, 24);
            this.CMBX_Type.TabIndex = 4;
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(50, 105);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Name.TabIndex = 5;
            // 
            // TXTB_SignDate
            // 
            this.TXTB_SignDate.Location = new System.Drawing.Point(50, 168);
            this.TXTB_SignDate.Name = "TXTB_SignDate";
            this.TXTB_SignDate.Size = new System.Drawing.Size(263, 22);
            this.TXTB_SignDate.TabIndex = 9;
            // 
            // TXTB_ExpireDate
            // 
            this.TXTB_ExpireDate.Location = new System.Drawing.Point(50, 229);
            this.TXTB_ExpireDate.Name = "TXTB_ExpireDate";
            this.TXTB_ExpireDate.Size = new System.Drawing.Size(263, 22);
            this.TXTB_ExpireDate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sign Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Expire Date";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTB_ExpireDate);
            this.Controls.Add(this.TXTB_SignDate);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.CMBX_Type);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMBX_Type;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.TextBox TXTB_SignDate;
        private System.Windows.Forms.TextBox TXTB_ExpireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}