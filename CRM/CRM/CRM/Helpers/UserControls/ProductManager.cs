﻿using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Products;
using CRM.Helpers.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRM.Helpers.UserControls
{
    public partial class ProductManager : UserControl
    {
        private bool _isAdmin; 
        private List<Contracts> _contracts;
        private int _userID;
        public ProductManager(bool isAdmin, int userId)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            _userID = userId;

            if (!isAdmin)
            {
                BTN_Remove.Visible = false;
            }
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            var removeProduct = new RemoveProducts();
            removeProduct.ShowDialog();
            QueryDBAndFillTable();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProducts();
            addProduct.ShowDialog();
            QueryDBAndFillTable();
        }

        private void QueryDBforContracts()
        {
            CMBX_Contracts.Items.Clear();
            CMBX_Contracts.Text = "";
            CMBX_Contracts.SelectedIndex = -1;

            _contracts = new List<Contracts>();
            if (_isAdmin)
            {
                _contracts = DataBaseGetter.GetAllContracts();
                CMBX_Contracts.Items.Add("All");
                //add all contract option
            }
            else
            {
                _contracts = DataBaseGetter.GetContractsByUser(_userID);
                //query for user contracts
            }

            if(_contracts != null)
            {
                foreach (var contract in _contracts)
                {
                    CMBX_Contracts.Items.Add(contract.Name);
                }
            }
        }

        internal void QueryDBAndFillTable()
        {
            QueryDBforContracts();

            FillTable();
        }

        private void CMBX_Contracts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            if (CMBX_Contracts.SelectedIndex >= 0)
            {
                List<Products> products;
                if (CMBX_Contracts.SelectedIndex == 0 && _isAdmin) //all clients is selected
                {
                    products = DataBaseGetter.GetProducts();
                }
                else if (_isAdmin)
                {
                    products = DataBaseGetter.GetProductsByContract((int)_contracts[CMBX_Contracts.SelectedIndex - 1].ID.Value);
                }
                else
                {
                    products = DataBaseGetter.GetProductsByContract((int)_contracts[CMBX_Contracts.SelectedIndex].ID.Value);
                }

                if (products != null)
                {
                    DGV_Products.Rows.Clear();

                    foreach (var product in products)
                    {
                        DGV_Products.Rows.Add(product.ID.ToString(), product.ContractID.ToString(), product.Name, product.Cost.ToString(), ParseType(product.Type.Value), product.Amount.ToString());
                    }
                }
            }
        }

        private string ParseType(bool type) => type ? "Buy" : "Sell";
    }
}
