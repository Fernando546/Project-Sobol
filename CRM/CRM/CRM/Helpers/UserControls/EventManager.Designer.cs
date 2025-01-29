namespace CRM.Helpers.UserControls
{
    partial class EventManager
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
            this.DGV_Events = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMBX_Clients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Events)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Events
            // 
            this.DGV_Events.AllowUserToAddRows = false;
            this.DGV_Events.AllowUserToDeleteRows = false;
            this.DGV_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Employee,
            this.Date,
            this.Type,
            this.Description});
            this.DGV_Events.Location = new System.Drawing.Point(25, 172);
            this.DGV_Events.Name = "DGV_Events";
            this.DGV_Events.ReadOnly = true;
            this.DGV_Events.RowHeadersWidth = 51;
            this.DGV_Events.RowTemplate.Height = 24;
            this.DGV_Events.Size = new System.Drawing.Size(814, 195);
            this.DGV_Events.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 125;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(606, 48);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(118, 77);
            this.BTN_Remove.TabIndex = 5;
            this.BTN_Remove.Text = "Remove Event";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(342, 58);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 6;
            this.BTN_Add.Text = "Add Event";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CMBX_Clients
            // 
            this.CMBX_Clients.FormattingEnabled = true;
            this.CMBX_Clients.Location = new System.Drawing.Point(117, 48);
            this.CMBX_Clients.Name = "CMBX_Clients";
            this.CMBX_Clients.Size = new System.Drawing.Size(62, 24);
            this.CMBX_Clients.TabIndex = 9;
            this.CMBX_Clients.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Clients_SelectionChangeCommitted);
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CMBX_Clients);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.DGV_Events);
            this.Name = "EventManager";
            this.Size = new System.Drawing.Size(891, 398);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Events)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Events;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMBX_Clients;
    }
}
