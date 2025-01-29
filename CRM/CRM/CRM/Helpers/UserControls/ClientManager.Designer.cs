namespace CRM.Helpers.UserControls
{
    partial class ClientManager
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
            this.components = new System.ComponentModel.Container();
            this.DGV_Clients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Clients
            // 
            this.DGV_Clients.AllowUserToAddRows = false;
            this.DGV_Clients.AllowUserToDeleteRows = false;
            this.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this._Name,
            this.LastContact,
            this.Phone,
            this.EMail});
            this.DGV_Clients.Location = new System.Drawing.Point(43, 46);
            this.DGV_Clients.Name = "DGV_Clients";
            this.DGV_Clients.ReadOnly = true;
            this.DGV_Clients.RowHeadersWidth = 51;
            this.DGV_Clients.RowTemplate.Height = 24;
            this.DGV_Clients.Size = new System.Drawing.Size(678, 248);
            this.DGV_Clients.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Name";
            this._Name.MinimumWidth = 6;
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            this._Name.Width = 125;
            // 
            // LastContact
            // 
            this.LastContact.HeaderText = "Last Contacted";
            this.LastContact.MinimumWidth = 6;
            this.LastContact.Name = "LastContact";
            this.LastContact.ReadOnly = true;
            this.LastContact.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.MinimumWidth = 6;
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Width = 125;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(760, 46);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(139, 67);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Add Client";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(760, 141);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(139, 67);
            this.BTN_Remove.TabIndex = 3;
            this.BTN_Remove.Text = "Remove Client";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(CRM.Helpers.DatabaseObjects.Clients);
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataSource = typeof(CRM.Helpers.DatabaseObjects.Clients);
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.DGV_Clients);
            this.Name = "ClientManager";
            this.Size = new System.Drawing.Size(943, 340);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridView DGV_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Remove;
    }
}
