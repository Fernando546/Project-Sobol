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
            this.CMBX_Contracts = new System.Windows.Forms.ComboBox();
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.TXTB_Price = new System.Windows.Forms.TextBox();
            this.TXTB_Count = new System.Windows.Forms.TextBox();
            this.CMBX_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Add.Location = new System.Drawing.Point(359, 49);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Add Product";
            this.BTN_Add.UseVisualStyleBackColor = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(359, 153);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(139, 67);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CMBX_Contracts
            // 
            this.CMBX_Contracts.FormattingEnabled = true;
            this.CMBX_Contracts.Location = new System.Drawing.Point(54, 129);
            this.CMBX_Contracts.Name = "CMBX_Contracts";
            this.CMBX_Contracts.Size = new System.Drawing.Size(263, 24);
            this.CMBX_Contracts.TabIndex = 5;
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(54, 62);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Name.TabIndex = 6;
            // 
            // TXTB_Price
            // 
            this.TXTB_Price.Location = new System.Drawing.Point(54, 198);
            this.TXTB_Price.Name = "TXTB_Price";
            this.TXTB_Price.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Price.TabIndex = 7;
            // 
            // TXTB_Count
            // 
            this.TXTB_Count.Location = new System.Drawing.Point(54, 341);
            this.TXTB_Count.Name = "TXTB_Count";
            this.TXTB_Count.Size = new System.Drawing.Size(263, 22);
            this.TXTB_Count.TabIndex = 8;
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(54, 267);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(263, 24);
            this.CMBX_Type.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contracts List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Count";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBX_Type);
            this.Controls.Add(this.TXTB_Count);
            this.Controls.Add(this.TXTB_Price);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.CMBX_Contracts);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Add);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.ComboBox CMBX_Contracts;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.TextBox TXTB_Price;
        private System.Windows.Forms.TextBox TXTB_Count;
        private System.Windows.Forms.ComboBox CMBX_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}