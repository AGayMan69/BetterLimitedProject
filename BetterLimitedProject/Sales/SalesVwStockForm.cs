using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimitedProject.Sales;

namespace BetterLimitedProject
{
    public partial class SalesVwStockForm : Form
    {
        private bool loading;
        private bool haveInput;
        private string targetProduct;

        private class productRow
        {
            internal int product_ID;
            internal string name;
            internal string category_name;
            internal int qty;
            internal int restock_level;

            public productRow(int productId, string name, string categoryName, int qty, int restockLevel)
            {
                product_ID = productId;
                this.name = name;
                category_name = categoryName;
                this.qty = qty;
                restock_level = restockLevel;
            }
        }

        public SalesVwStockForm()
        {
            InitializeComponent();
        }

        private void SalesVwStockForm_Load(object sender, EventArgs e)
        {
            loading = true;
            cboCategory.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;

            // loading category
            using (var betterDB = new betterlimitedEntities())
            {
                var categories = from cateRec in betterDB.categories
                                 select cateRec.category_name;
                foreach (var category in categories)
                {
                    cboCategory.Items.Add(category);
                }
            }

            loading = false;
            loadStock();
        }

        private void cboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadStock();
            tbSearch.Clear();
        }

        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            loadStock();
            tbSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadStock();
            tbSearch.Clear();
        }

        private void loadStock()
        {
            if (loading)
            {
                return;
            }
            else
            {
                // check textbox have text
                if (tbSearch.Text == "")
                {
                    haveInput = false;
                }
                else
                {
                    targetProduct = tbSearch.Text;
                    haveInput = true;
                }
                // getting category
                string targetCategory;
                if (cboCategory.SelectedIndex == 0)
                {
                    targetCategory = "";
                }
                else
                {
                    targetCategory = cboCategory.SelectedItem.ToString();
                }


                panProductLoad.Controls.Clear();
                using (var betterDB = new betterlimitedEntities())
                {
                    IQueryable<SalesProductControl> stockControls;
                    if (haveInput)
                    {
                        stockControls = (from stockRec in betterDB.retail_store_product
                                         where
                                             stockRec.product.name.Contains(targetProduct)
                                             && stockRec.product.category.category_name.Contains(targetCategory)
                                         select new SalesProductControl()
                                         {
                                             productName = stockRec.product.name,
                                             productID = stockRec.product_ID,
                                             category = stockRec.product.category.category_name,
                                             qty = stockRec.qty,
                                             restockLevel = stockRec.product.restock_level
                                         }
                                      ).AsNoTracking();
                    }
                    else
                    {
                        stockControls = (from stockRec in betterDB.retail_store_product
                                         where stockRec.product.category.category_name.Contains(targetCategory)
                                         select new SalesProductControl()
                                         {
                                             productName = stockRec.product.name,
                                             productID = stockRec.product_ID,
                                             category = stockRec.product.category.category_name,
                                             qty = stockRec.qty,
                                             restockLevel = stockRec.product.restock_level
                                         }
                                      ).AsNoTracking();
                    }

                    // getting status
                    if (cboStatus.SelectedItem == "IN STOCK")
                    {
                        stockControls =  stockControls.Where(control => control.qty > control.restockLevel);
                    }
                    else if (cboStatus.SelectedItem == "OUT OF STOCK")
                    {
                        stockControls =  stockControls.Where(control => control.qty <= control.restockLevel);
                    }

                    foreach (var control in stockControls)
                    {
                        control.Dock = DockStyle.Top;
                        control._parent = this;
                        panProductLoad.Controls.Add(control);
                    }
                }
            }
        }

        private void reStock(int productID)
        {
            int reStockQty;
        }
    }
}
