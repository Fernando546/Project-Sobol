namespace CRM.Helpers.UserControls
{
    partial class ProductManager
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
            this.DGV_Products = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMBX_Contracts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_AddProductName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Products
            // 
            this.DGV_Products.AllowUserToAddRows = false;
            this.DGV_Products.AllowUserToDeleteRows = false;
            this.DGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ContractID,
            this._Name,
            this.Price,
            this.Type,
            this.Count});
            this.DGV_Products.Location = new System.Drawing.Point(37, 37);
            this.DGV_Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Products.Name = "DGV_Products";
            this.DGV_Products.ReadOnly = true;
            this.DGV_Products.RowHeadersWidth = 51;
            this.DGV_Products.RowTemplate.Height = 24;
            this.DGV_Products.Size = new System.Drawing.Size(602, 202);
            this.DGV_Products.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // ContractID
            // 
            this.ContractID.HeaderText = "Contract ID";
            this.ContractID.MinimumWidth = 6;
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            this.ContractID.Width = 125;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Name";
            this._Name.MinimumWidth = 6;
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            this._Name.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 125;
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(347, 254);
            this.BTN_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(104, 54);
            this.BTN_Remove.TabIndex = 6;
            this.BTN_Remove.Text = "Remove Product";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(226, 254);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(104, 54);
            this.BTN_Add.TabIndex = 7;
            this.BTN_Add.Text = "Add Product";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Contracts
            // 
            this.CMBX_Contracts.FormattingEnabled = true;
            this.CMBX_Contracts.Location = new System.Drawing.Point(106, 272);
            this.CMBX_Contracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBX_Contracts.Name = "CMBX_Contracts";
            this.CMBX_Contracts.Size = new System.Drawing.Size(105, 21);
            this.CMBX_Contracts.TabIndex = 8;
            this.CMBX_Contracts.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Contracts_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contract List";
            // 
            // BTN_AddProductName
            // 
            this.BTN_AddProductName.Location = new System.Drawing.Point(470, 254);
            this.BTN_AddProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AddProductName.Name = "BTN_AddProductName";
            this.BTN_AddProductName.Size = new System.Drawing.Size(104, 54);
            this.BTN_AddProductName.TabIndex = 10;
            this.BTN_AddProductName.Text = "Add Product Name";
            this.BTN_AddProductName.UseVisualStyleBackColor = true;
            this.BTN_AddProductName.Click += new System.EventHandler(this.BTN_AddProductName_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_AddProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBX_Contracts);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.DGV_Products);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductManager";
            this.Size = new System.Drawing.Size(738, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMBX_Contracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_AddProductName;
    }
}
