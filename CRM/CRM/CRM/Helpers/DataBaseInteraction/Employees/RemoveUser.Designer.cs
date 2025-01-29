namespace CRM.Helpers.DataBaseInteraction.Users
{
    partial class RemoveUser
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
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.TXTB_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(352, 134);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(139, 67);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Remove.Location = new System.Drawing.Point(352, 35);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(139, 67);
            this.BTN_Remove.TabIndex = 5;
            this.BTN_Remove.Text = "Remove User";
            this.BTN_Remove.UseVisualStyleBackColor = false;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // TXTB_ID
            // 
            this.TXTB_ID.Location = new System.Drawing.Point(45, 54);
            this.TXTB_ID.Name = "TXTB_ID";
            this.TXTB_ID.Size = new System.Drawing.Size(263, 22);
            this.TXTB_ID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTB_ID);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "RemoveUser";
            this.Text = "RemoveUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.TextBox TXTB_ID;
        private System.Windows.Forms.Label label1;
    }
}