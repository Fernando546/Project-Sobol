namespace CRM.Helpers.DataBaseInteraction.Users
{
    partial class AddUser
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
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TXTB_Username = new System.Windows.Forms.TextBox();
            this.TXTB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(549, 331);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(176, 89);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Add User";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(56, 331);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(211, 89);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TXTB_Username
            // 
            this.TXTB_Username.Location = new System.Drawing.Point(59, 103);
            this.TXTB_Username.Name = "TXTB_Username";
            this.TXTB_Username.Size = new System.Drawing.Size(125, 22);
            this.TXTB_Username.TabIndex = 5;
            // 
            // TXTB_Password
            // 
            this.TXTB_Password.Location = new System.Drawing.Point(53, 154);
            this.TXTB_Password.Name = "TXTB_Password";
            this.TXTB_Password.Size = new System.Drawing.Size(125, 22);
            this.TXTB_Password.TabIndex = 6;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTB_Password);
            this.Controls.Add(this.TXTB_Username);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Add);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TXTB_Username;
        private System.Windows.Forms.TextBox TXTB_Password;
    }
}