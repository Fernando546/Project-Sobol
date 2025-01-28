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
            this.CMBX_Clients = new System.Windows.Forms.ComboBox();
            this.CMBX_Type = new System.Windows.Forms.ComboBox();
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.TXTB_SignDate = new System.Windows.Forms.TextBox();
            this.TXTB_ExpireDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(32, 337);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(211, 89);
            this.BTN_Cancel.TabIndex = 1;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(567, 311);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(176, 89);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Add Contract";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Clients
            // 
            this.CMBX_Clients.FormattingEnabled = true;
            this.CMBX_Clients.Location = new System.Drawing.Point(28, 51);
            this.CMBX_Clients.Name = "CMBX_Clients";
            this.CMBX_Clients.Size = new System.Drawing.Size(114, 24);
            this.CMBX_Clients.TabIndex = 3;
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(26, 99);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(115, 24);
            this.CMBX_Type.TabIndex = 4;
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(30, 146);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(171, 22);
            this.TXTB_Name.TabIndex = 5;
            // 
            // TXTB_SignDate
            // 
            this.TXTB_SignDate.Location = new System.Drawing.Point(32, 184);
            this.TXTB_SignDate.Name = "TXTB_SignDate";
            this.TXTB_SignDate.Size = new System.Drawing.Size(171, 22);
            this.TXTB_SignDate.TabIndex = 9;
            // 
            // TXTB_ExpireDate
            // 
            this.TXTB_ExpireDate.Location = new System.Drawing.Point(32, 237);
            this.TXTB_ExpireDate.Name = "TXTB_ExpireDate";
            this.TXTB_ExpireDate.Size = new System.Drawing.Size(171, 22);
            this.TXTB_ExpireDate.TabIndex = 10;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTB_ExpireDate);
            this.Controls.Add(this.TXTB_SignDate);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.CMBX_Type);
            this.Controls.Add(this.CMBX_Clients);
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
        private System.Windows.Forms.ComboBox CMBX_Clients;
        private System.Windows.Forms.ComboBox CMBX_Type;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.TextBox TXTB_SignDate;
        private System.Windows.Forms.TextBox TXTB_ExpireDate;
    }
}