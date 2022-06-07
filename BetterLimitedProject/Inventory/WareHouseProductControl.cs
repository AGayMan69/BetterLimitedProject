﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Inventory
{
    public partial class WareHouseProductControl : UserControl
    {        
        internal InventoryVwStockForm _parent;
        internal string productName;
        internal string category;
        internal int qty;
        internal int productID;
        internal int restockLevel;

        public WareHouseProductControl()
        {
            InitializeComponent();
        }

        private void WareHouseProductControl_Load(object sender, EventArgs e)
        {
            lblInStock.Visible = false;
            lblOutStock.Visible = false;
            lblName.Text = productName;
            lblQty.Text = qty.ToString();
            lblProductID.Text = productID.ToString();
            lblCategory.Text = category;
            bool inStock = qty > restockLevel;
            if (inStock)
            {
                lblInStock.Visible = true;
                lblOutStock.Visible = false;
            }
            else
            {
                lblOutStock.Visible = true;
                lblInStock.Visible = false;
            }

        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            _parent.reStock(productID);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.editStock(productID);
        }
    }
}
