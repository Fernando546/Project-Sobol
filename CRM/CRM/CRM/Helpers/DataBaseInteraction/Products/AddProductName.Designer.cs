namespace CRM.Helpers.DataBaseInteraction.Products
{
    partial class AddProductName
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
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(86, 112);
            this.TXTB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(392, 31);
            this.TXTB_Name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(527, 94);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(208, 105);
            this.BTN_Add.TabIndex = 12;
            this.BTN_Add.Text = "Add Product Name";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(527, 248);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(208, 105);
            this.BTN_Cancel.TabIndex = 13;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // AddProductName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 425);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTB_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductName";
            this.Text = "AddProductName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}