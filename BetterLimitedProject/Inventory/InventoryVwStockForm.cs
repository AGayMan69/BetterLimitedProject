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
        private Dictionary<string, List<purchase_orderline>> restockContent;
        private List<reorder> newReordersList;
        private List<purchaseorder> newPurchaseordersList;

        private int newPurchaseOrderID, newReorderID;

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

                    panProductLoad.Hide();
                    foreach (var control in stockControls)
                    {
                        control.Dock = DockStyle.Top;
                        control._parent = this;
                        panProductLoad.Controls.Add(control);
                    }
                    panProductLoad.Show();
                }
            }
        }

        internal void reStock(int productID, string supplier)
        {
            if (restockContent == null)
            {
                initiatePurchaseOrder();
            }

            if (!(restockContent.ContainsKey(supplier)))
            {
                restockContent.Add(supplier, new List<purchase_orderline>());
            }
            // check if product exist
            else if (restockContent[supplier].Exists(line => line.product_id == productID))
            {
                MessageBox.Show("Duplicate item");
                return;
            }
            purchase_orderline prOrderline = new purchase_orderline();
            prOrderline.product_id = productID;
            prOrderline.qty = 1;
            restockContent[supplier].Add(prOrderline);

            // adding restock line
            inventoryPurchaseOrderLineControl orderLineControl = new inventoryPurchaseOrderLineControl() {Dock = DockStyle.Top};
            orderLineControl._parent = this;
            orderLineControl.product_id = prOrderline.product_id;
            orderLineControl.supplier = supplier;

            pnlPurchaseOLLoader.Controls.Add(orderLineControl);

        }

        internal void initiatePurchaseOrder()
        {
            restockContent = new Dictionary<string, List<purchase_orderline>>();
            MessageBox.Show("Product Added to restock form\nCheck out the restock tab to submit restock");
        }

        internal void removePurchaseOrderline(int product_id, string supplier)
        {
                // remove last item of the supplier
            if (restockContent[supplier].Count == 1)
            {
                restockContent.Remove(supplier);
            }
            else
            {
                restockContent[supplier].RemoveAll(line => line.product_id == product_id);
            }

            if (restockContent.Count == 0)
            {
                restockContent = null;
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            restockContent = null;
            pnlPurchaseOLLoader.Controls.Clear();
        }

        public void editPurchaseOrderLineQty(int productId, string supplier, int qty)
        {
            restockContent[supplier].Find(line => line.product_id == productId).qty = qty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            generateReorderRequest();
        }

        private void generateReorderRequest()
        {
            if (restockContent == null)
            {
                MessageBox.Show("No item is selected!!");
                return;
            }

            newReordersList = new List<reorder>();
            newPurchaseordersList = new List<purchaseorder>();
            // Generating new purchase order id
            string strYear = DateTime.Now.Year.ToString();
            int year = Int32.Parse(strYear.Remove(0, 2));
            int tempID = year * (int)Math.Pow(10, 5);

            using (var betterDB = new betterlimitedEntities())
            {
                // generating purhcase order id
                var latestOrder = (from purchaseOrderRec in betterDB.purchaseorders
                                   where purchaseOrderRec.purchase_order_ID >= tempID
                                   orderby purchaseOrderRec.purchase_order_ID descending
                                   select purchaseOrderRec).AsNoTracking().FirstOrDefault();

                if (latestOrder == null)
                {
                    newPurchaseOrderID = tempID;
                }
                else
                {
                    newPurchaseOrderID = latestOrder.purchase_order_ID + 1;
                }

                // generating  reorder id
                var latestReorder = (from reorderRec in betterDB.reorders
                                   where reorderRec.reorder_ID >= tempID
                                   orderby reorderRec.reorder_ID descending
                                   select reorderRec).AsNoTracking().FirstOrDefault();

                if (latestReorder == null)
                {
                    newReorderID = tempID;
                }
                else
                {
                    newReorderID = latestReorder.reorder_ID + 1;
                }

                // generating purchase order and reorder request according to supplier
                foreach (var supplierOrder in restockContent)
                {
                    // creating reorder request 
                    reorder reo = new reorder();
                    reo.reorder_ID = newReorderID;
                    reo.warehouse_ID = 1;
                    reo.creation_time = DateTime.Now;
                    // searching supplier ID
                    var supplierResult = (from supplierRec in betterDB.suppliers
                        where supplierRec.supplier_name == supplierOrder.Key
                        select supplierRec.supplier_id).FirstOrDefault();
                    purchaseorder po = new purchaseorder();
                    po.purchase_order_ID = newPurchaseOrderID;
                    po.supplier_ID = supplierResult;
                    po.status = "PENDING";
                    po.reorder_ID = newReorderID;
                    po.creation_time = DateTime.Now;
                    int total = 0;
                    foreach (var line in supplierOrder.Value)
                    {
                        var productPrice = (from productRec in betterDB.products
                            where productRec.product_ID == line.product_id
                            select productRec.price).FirstOrDefault();
                        total += (int)(productPrice * line.qty);
                        line.purchase_order_id = newPurchaseOrderID;
                    }

                    po.total = total;

                    newReordersList.Add(reo);
                    newPurchaseordersList.Add(po);
                    newReorderID++;
                    newPurchaseOrderID++;

                }

                foreach (var reorderRec in newReordersList)
                {
                    betterDB.reorders.Add(reorderRec);
                }

                foreach (var purchaseorderRec in newPurchaseordersList)
                {
                    betterDB.purchaseorders.Add(purchaseorderRec);
                }

                foreach (var orderlineList in restockContent.Values)
                {
                    foreach (var pol in orderlineList)
                    {
                        betterDB.purchase_orderline.Add(pol);
                    } 
                }

                betterDB.SaveChanges();

            }

            MessageBox.Show("Reorder Quest Created Successfully.\nWaiting for approval...");
            this.Controls.Clear();
            InitializeComponent();
            InventoryVwStockForm_Load(null, EventArgs.Empty);
            restockContent = null;
            newReordersList = null;
            newPurchaseordersList = null;
        }
    }
}
