namespace CRM.Helpers
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.TXTB_Server = new System.Windows.Forms.TextBox();
            this.TXTB_Database = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(959, 22);
            this.BTN_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(222, 108);
            this.BTN_Login.TabIndex = 0;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(22, 22);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(222, 108);
            this.BTN_Exit.TabIndex = 1;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // TXTB_Server
            // 
            this.TXTB_Server.Location = new System.Drawing.Point(348, 81);
            this.TXTB_Server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Server.Name = "TXTB_Server";
            this.TXTB_Server.Size = new System.Drawing.Size(162, 31);
            this.TXTB_Server.TabIndex = 2;
            // 
            // TXTB_Database
            // 
            this.TXTB_Database.Location = new System.Drawing.Point(590, 81);
            this.TXTB_Database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Database.Name = "TXTB_Database";
            this.TXTB_Database.Size = new System.Drawing.Size(162, 31);
            this.TXTB_Database.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database ";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTB_Database);
            this.Controls.Add(this.TXTB_Server);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1200, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.TextBox TXTB_Server;
        private System.Windows.Forms.TextBox TXTB_Database;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
