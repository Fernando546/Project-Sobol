namespace CRM.Helpers.DataBaseInteraction.Products
{
    partial class AddProducts
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
            this.TXTB_Price = new System.Windows.Forms.TextBox();
            this.TXTB_Count = new System.Windows.Forms.TextBox();
            this.CMBX_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBX_Name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(538, 77);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(208, 105);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Add Product";
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(538, 239);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(208, 105);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TXTB_Price
            // 
            this.TXTB_Price.Location = new System.Drawing.Point(81, 206);
            this.TXTB_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Price.Name = "TXTB_Price";
            this.TXTB_Price.Size = new System.Drawing.Size(392, 31);
            this.TXTB_Price.TabIndex = 7;
            // 
            // TXTB_Count
            // 
            this.TXTB_Count.Location = new System.Drawing.Point(81, 430);
            this.TXTB_Count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTB_Count.Name = "TXTB_Count";
            this.TXTB_Count.Size = new System.Drawing.Size(392, 31);
            this.TXTB_Count.TabIndex = 8;
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(81, 314);
            this.CMBX_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(392, 33);
            this.CMBX_Type.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Count";
            // 
            // CMBX_Name
            // 
            this.CMBX_Name.FormattingEnabled = true;
            this.CMBX_Name.Location = new System.Drawing.Point(81, 97);
            this.CMBX_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBX_Name.Name = "CMBX_Name";
            this.CMBX_Name.Size = new System.Drawing.Size(392, 33);
            this.CMBX_Name.TabIndex = 15;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 538);
            this.Controls.Add(this.CMBX_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBX_Type);
            this.Controls.Add(this.TXTB_Count);
            this.Controls.Add(this.TXTB_Price);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Add);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TXTB_Price;
        private System.Windows.Forms.TextBox TXTB_Count;
        private System.Windows.Forms.ComboBox CMBX_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBX_Name;
    }
}