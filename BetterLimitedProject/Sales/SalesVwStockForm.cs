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
            using (var betterDb = new betterlimitedEntities())
            {
                var stockResult = (from stRec in betterDb.retail_store_product
                                   where stRec.product_ID == productID
                                                  && stRec.store_ID == 1
                                   select new
                                   {
                                       stRec.store_date,
                                       stRec.product.name,
                                       stRec.product.weight,
                                       stRec.product.product_image
                                   }).AsNoTracking().FirstOrDefault();

                SalesRestockForm restockForm = new SalesRestockForm();
                restockForm.name = stockResult.name;
                restockForm.imageBlob = stockResult.product_image;
                restockForm.restockTime = (DateTime)stockResult.store_date;
                var restockDialog = restockForm.ShowDialog();
                if (restockDialog == DialogResult.OK)
                {
                    // create replenishment
                    MessageBox.Show($"Restocking : {restockForm.reStockAmount}");
                    // Generating new buy order id
                    string strYear = DateTime.Now.Year.ToString();
                    int year = Int32.Parse(strYear.Remove(0, 2));
                    int tempID = year * (int)Math.Pow(10, 5);

                    int newDeliveryID;
                    var latestDelivery = (from deliverRec in betterDb.deliveries
                                       where deliverRec.delivery_ID >= tempID
                                       orderby deliverRec.delivery_ID descending
                                       select deliverRec).AsNoTracking().FirstOrDefault();

                    if (latestDelivery == null)
                    {
                        newDeliveryID = tempID;
                    }
                    else
                    {
                        newDeliveryID = latestDelivery.delivery_ID + 1;
                    }
                    delivery newDelivery = new delivery();
                    newDelivery.delivery_ID = newDeliveryID;
                    newDelivery.type = 2;
                    newDelivery.status = "Pending";
                    newDelivery.net_weight = stockResult.weight * restockForm.reStockAmount;

                    replenishment newReplenishment = new replenishment();
                    newReplenishment.delivery_ID = newDeliveryID;
                    newReplenishment.salesID = 3;
                    newReplenishment.store_ID = 1;
                    newReplenishment.request_date = DateTime.Now;
                    replenishment_product newReplenishmentProduct = new replenishment_product();
                    newReplenishmentProduct.product_ID = productID;
                    newReplenishmentProduct.delivery_ID = newDeliveryID;
                    newReplenishmentProduct.qty = restockForm.reStockAmount;
                    newDelivery.creation_time = DateTime.Now;

                    betterDb.deliveries.Add(newDelivery);
                    betterDb.replenishments.Add(newReplenishment);
                    betterDb.replenishment_product.Add(newReplenishmentProduct);

                    betterDb.SaveChanges();
                }
            }
        }
    }
}
