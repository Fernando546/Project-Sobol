namespace CRM.Helpers.UserControls
{
    partial class ContractManager
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
            this.DGV_Contracts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMBX_Clients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contracts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Contracts
            // 
            this.DGV_Contracts.AllowUserToAddRows = false;
            this.DGV_Contracts.AllowUserToDeleteRows = false;
            this.DGV_Contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Contracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Employee,
            this.Client,
            this.Type,
            this._Name,
            this.Cost,
            this.Profit,
            this.FinalProfit,
            this.Signed,
            this.Expires});
            this.DGV_Contracts.Location = new System.Drawing.Point(55, 44);
            this.DGV_Contracts.Name = "DGV_Contracts";
            this.DGV_Contracts.ReadOnly = true;
            this.DGV_Contracts.RowHeadersWidth = 51;
            this.DGV_Contracts.RowTemplate.Height = 24;
            this.DGV_Contracts.Size = new System.Drawing.Size(1304, 248);
            this.DGV_Contracts.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Name";
            this._Name.MinimumWidth = 6;
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            this._Name.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 125;
            // 
            // FinalProfit
            // 
            this.FinalProfit.HeaderText = "Final Profit";
            this.FinalProfit.MinimumWidth = 6;
            this.FinalProfit.Name = "FinalProfit";
            this.FinalProfit.ReadOnly = true;
            this.FinalProfit.Width = 125;
            // 
            // Signed
            // 
            this.Signed.HeaderText = "Signed";
            this.Signed.MinimumWidth = 6;
            this.Signed.Name = "Signed";
            this.Signed.ReadOnly = true;
            this.Signed.Width = 125;
            // 
            // Expires
            // 
            this.Expires.HeaderText = "Expires";
            this.Expires.MinimumWidth = 6;
            this.Expires.Name = "Expires";
            this.Expires.ReadOnly = true;
            this.Expires.Width = 125;
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(1401, 225);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(139, 67);
            this.BTN_Remove.TabIndex = 4;
            this.BTN_Remove.Text = "Remove Contract";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(1401, 123);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.Text = "Add Contract";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Clients
            // 
            this.CMBX_Clients.FormattingEnabled = true;
            this.CMBX_Clients.Location = new System.Drawing.Point(1401, 65);
            this.CMBX_Clients.Name = "CMBX_Clients";
            this.CMBX_Clients.Size = new System.Drawing.Size(139, 24);
            this.CMBX_Clients.TabIndex = 10;
            this.CMBX_Clients.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Clients_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1398, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client List";
            // 
            // ContractManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBX_Clients);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.DGV_Contracts);
            this.Name = "ContractManager";
            this.Size = new System.Drawing.Size(1590, 340);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expires;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMBX_Clients;
        private System.Windows.Forms.Label label1;
    }
}
