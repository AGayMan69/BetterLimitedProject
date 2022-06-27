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
    public partial class InventoryPurUpdateForm : Form
    {
        internal int purchaseOrderID;
        private purchaseorder targetOrder;
        private Dictionary<int, bool> lineConfirmList;

        public InventoryPurUpdateForm()
        {
            InitializeComponent();
        }

        private void InventoryPurUpdateForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                targetOrder = (from purchaseRec in betterDB.purchaseorders
                    where purchaseRec.purchase_order_ID == purchaseOrderID
                    select purchaseRec).AsNoTracking().FirstOrDefault();
                lblPurchaseID.Text = "Purchase Order #" + purchaseOrderID;
                lblCreationTime.Text = targetOrder.creation_time.ToString();
                lblStatus.Text = targetOrder.status;
                if (targetOrder.approve_time == null)
                {
                    lblApproveTime.Text = "";
                }
                else
                {
                    lblApproveTime.Text = targetOrder.approve_time.ToString();
                }
                lblSupplier.Text = targetOrder.supplier.supplier_name;
                pnlOrderLineLoader.Hide();
                lineConfirmList = new Dictionary<int, bool>();
                foreach (var line in targetOrder.purchase_orderline)
                {
                    PurUpdateOrderLineControl control = new PurUpdateOrderLineControl() { Dock = DockStyle.Top };
                    control.productID = line.product_id;
                    control.productImage = line.product.product_image;
                    control.productName = line.product.name;
                    control.qty = line.qty;
                    control._parent = this;
                    pnlOrderLineLoader.Controls.Add(control);
                    lineConfirmList.Add(line.product_id, false);
                }
                pnlOrderLineLoader.Show();
            }

        }

        internal void confirm(int productID)
        {
            lineConfirmList[productID] = true;
        }

        internal void cancel (int productID)
        {
            lineConfirmList[productID] = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lineConfirmList.ContainsValue(false))
            {
                MessageBox.Show("Please confirm all the received good!!");
            }
            else
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    // updating warehouse stock
                    var purchaseOrderLineList = (from purchaseOrderOLRec in betterDB.purchase_orderline
                        where purchaseOrderOLRec.purchase_order_id == purchaseOrderID
                        select purchaseOrderOLRec).AsNoTracking();
                    foreach (var line in purchaseOrderLineList.ToList())
                    {
                        var warehouseStockLine = (from warehouseStockRec in betterDB.warehouse_product
                            where warehouseStockRec.warehouse_ID == 1
                                  && warehouseStockRec.product_ID == line.product_id
                            select warehouseStockRec).FirstOrDefault();
                        warehouseStockLine.qty += line.qty;
                    }

                    // changing purchase order status
                    var purchaseOrder = (from purchaseOrderRec in betterDB.purchaseorders
                        where purchaseOrderRec.purchase_order_ID == purchaseOrderID
                        select purchaseOrderRec).FirstOrDefault();
                    purchaseOrder.status = "COMPLETED";

                    // generating purhcase order id

                    string strYear = DateTime.Now.Year.ToString();
                    int year = Int32.Parse(strYear.Remove(0, 2));
                    int tempID = year * (int)Math.Pow(10, 5);

                    int newGoodReceivedID;
                       
                    var latestGoodReceived = (from goodRec in betterDB.good_received
                                       where goodRec.received_id >= tempID
                                       orderby goodRec.received_id descending
                                       select goodRec).AsNoTracking().FirstOrDefault();

                    if (latestGoodReceived == null)
                    {
                        newGoodReceivedID = tempID;
                    }
                    else
                    {
                        newGoodReceivedID = latestGoodReceived.received_id + 1;
                    }

                    good_received newReceived = new good_received();
                    newReceived.received_id = newGoodReceivedID;
                    newReceived.purchase_order_id = purchaseOrderID;
                    newReceived.received_time = DateTime.Now;
                    betterDB.good_received.Add(newReceived);
                    betterDB.SaveChanges();
                }
                MessageBox.Show("Restock successfully");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
