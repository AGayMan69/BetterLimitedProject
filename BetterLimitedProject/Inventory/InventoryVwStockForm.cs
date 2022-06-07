using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryVwStockForm : Form
    {        
        private bool loading;
        private bool haveInput;
        private string targetProduct;

        public InventoryVwStockForm()
        {
            InitializeComponent();
        }

        private void InventoryVwStockForm_Load(object sender, EventArgs e)
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
                    IQueryable<WareHouseProductControl> stockControls;
                    if (haveInput)
                    {
                        stockControls = (from stockRec in betterDB.warehouse_product
                                         where
                                            stockRec.warehouse_ID == 1
                                             && stockRec.product.name.Contains(targetProduct)
                                             && stockRec.product.category.category_name.Contains(targetCategory)
                                         select new WareHouseProductControl()
                                         {
                                             productName = stockRec.product.name,
                                             productID = stockRec.product_ID,
                                             category = stockRec.product.category.category_name,
                                             qty = stockRec.qty,
                                             restockLevel = stockRec.product.irestock_level
                                         }
                                      ).AsNoTracking();
                    }
                    else
                    {
                        stockControls = (from stockRec in betterDB.warehouse_product
                                         where stockRec.product.category.category_name.Contains(targetCategory)
                                            &&stockRec.warehouse_ID == 1
                                         select new WareHouseProductControl()
                                         {
                                             productName = stockRec.product.name,
                                             productID = stockRec.product_ID,
                                             category = stockRec.product.category.category_name,
                                             qty = stockRec.qty,
                                             restockLevel = stockRec.product.irestock_level
                                         }
                                      ).AsNoTracking();
                    }

                    // getting status
                    if (cboStatus.SelectedItem == "IN STOCK")
                    {
                        stockControls = stockControls.Where(control => control.qty > control.restockLevel);
                    }
                    else if (cboStatus.SelectedItem == "OUT OF STOCK")
                    {
                        stockControls = stockControls.Where(control => control.qty <= control.restockLevel);
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

        internal void reStock(int productID)
        {
            MessageBox.Show("Restocking");
        }


        internal void editStock(int productID)
        {
            MessageBox.Show("Editing Warehouse stock");
            //SalesEditStockForm editStock = new SalesEditStockForm();
            //editStock.productID = productID;
            //var dialog = editStock.ShowDialog();
            //if (dialog == DialogResult.OK)
            //{
            //    loadStock();
            //}
        }

    }
}
