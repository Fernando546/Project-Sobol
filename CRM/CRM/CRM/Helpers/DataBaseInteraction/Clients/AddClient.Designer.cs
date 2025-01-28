namespace CRM.Helpers.DataBaseInteraction.Clients
{
    partial class AddClient
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
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.TXTB_LastContact = new System.Windows.Forms.TextBox();
            this.TXTB_Phone = new System.Windows.Forms.TextBox();
            this.TXTB_EMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(37, 327);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(211, 89);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(562, 327);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(176, 89);
            this.BTN_Add.TabIndex = 1;
            this.BTN_Add.Text = "Add Client";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(35, 93);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Name.TabIndex = 3;
            // 
            // TXTB_LastContact
            // 
            this.TXTB_LastContact.Location = new System.Drawing.Point(37, 136);
            this.TXTB_LastContact.Name = "TXTB_LastContact";
            this.TXTB_LastContact.Size = new System.Drawing.Size(263, 22);
            this.TXTB_LastContact.TabIndex = 4;
            // 
            // TXTB_Phone
            // 
            this.TXTB_Phone.Location = new System.Drawing.Point(35, 186);
            this.TXTB_Phone.Name = "TXTB_Phone";
            this.TXTB_Phone.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Phone.TabIndex = 5;
            // 
            // TXTB_EMail
            // 
            this.TXTB_EMail.Location = new System.Drawing.Point(35, 245);
            this.TXTB_EMail.Name = "TXTB_EMail";
            this.TXTB_EMail.Size = new System.Drawing.Size(263, 22);
            this.TXTB_EMail.TabIndex = 6;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTB_EMail);
            this.Controls.Add(this.TXTB_Phone);
            this.Controls.Add(this.TXTB_LastContact);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.TextBox TXTB_LastContact;
        private System.Windows.Forms.TextBox TXTB_Phone;
        private System.Windows.Forms.TextBox TXTB_EMail;
    }
}