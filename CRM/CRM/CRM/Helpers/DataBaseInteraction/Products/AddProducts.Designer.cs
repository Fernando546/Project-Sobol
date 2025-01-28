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
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(539, 331);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(176, 89);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Add Product";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(43, 331);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(211, 89);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CMBX_Contracts
            // 
            this.CMBX_Contracts.FormattingEnabled = true;
            this.CMBX_Contracts.Location = new System.Drawing.Point(54, 49);
            this.CMBX_Contracts.Name = "CMBX_Contracts";
            this.CMBX_Contracts.Size = new System.Drawing.Size(114, 24);
            this.CMBX_Contracts.TabIndex = 5;
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(56, 98);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(133, 22);
            this.TXTB_Name.TabIndex = 6;
            // 
            // TXTB_Price
            // 
            this.TXTB_Price.Location = new System.Drawing.Point(56, 155);
            this.TXTB_Price.Name = "TXTB_Price";
            this.TXTB_Price.Size = new System.Drawing.Size(133, 22);
            this.TXTB_Price.TabIndex = 7;
            // 
            // TXTB_Count
            // 
            this.TXTB_Count.Location = new System.Drawing.Point(54, 257);
            this.TXTB_Count.Name = "TXTB_Count";
            this.TXTB_Count.Size = new System.Drawing.Size(133, 22);
            this.TXTB_Count.TabIndex = 8;
            // 
            // CMBX_Type
            // 
            this.CMBX_Type.FormattingEnabled = true;
            this.CMBX_Type.Location = new System.Drawing.Point(73, 206);
            this.CMBX_Type.Name = "CMBX_Type";
            this.CMBX_Type.Size = new System.Drawing.Size(114, 24);
            this.CMBX_Type.TabIndex = 9;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}