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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(367, 142);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(139, 67);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(367, 40);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 1;
            this.BTN_Add.Text = "Add Client";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(51, 54);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Name.TabIndex = 3;
            // 
            // TXTB_LastContact
            // 
            this.TXTB_LastContact.Location = new System.Drawing.Point(51, 110);
            this.TXTB_LastContact.Name = "TXTB_LastContact";
            this.TXTB_LastContact.Size = new System.Drawing.Size(263, 22);
            this.TXTB_LastContact.TabIndex = 4;
            // 
            // TXTB_Phone
            // 
            this.TXTB_Phone.Location = new System.Drawing.Point(51, 164);
            this.TXTB_Phone.Name = "TXTB_Phone";
            this.TXTB_Phone.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Phone.TabIndex = 5;
            // 
            // TXTB_EMail
            // 
            this.TXTB_EMail.Location = new System.Drawing.Point(51, 221);
            this.TXTB_EMail.Name = "TXTB_EMail";
            this.TXTB_EMail.Size = new System.Drawing.Size(263, 22);
            this.TXTB_EMail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-Mail";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}