using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryVwPurchaseForm : Form
    {
        private bool loading;

        public InventoryVwPurchaseForm()
        {
            InitializeComponent();
        }

        private void InventoryVwGoodForm_Load(object sender, EventArgs e)
        {
            loading = true;
            cboStatus.SelectedIndex = 1;
            loading = false;
            loadPurchaseOrder();
        }

        private void loadPurchaseOrder()
        {
            if (loading)
            {
                return;
            }

            pnlPorderLoader.Controls.Clear();
            IQueryable<InventoryPurchaseOrderControl> orderList;
            string targetStatus;
            targetStatus = cboStatus.SelectedItem.ToString();

            using (var betterDB = new betterlimitedEntities())
            {
                orderList = from purchaseOrderRec in betterDB.purchaseorders
                            where purchaseOrderRec.status.Contains(targetStatus)
                            select new InventoryPurchaseOrderControl()
                            {
                                poID = purchaseOrderRec.purchase_order_ID,
                                supplier = purchaseOrderRec.supplier.supplier_name,
                                creatTime = purchaseOrderRec.creation_time,
                                status = purchaseOrderRec.status
                            };
                pnlPorderLoader.Hide();
                foreach (var control in orderList)
                {
                    control._parent = this;
                    control.Dock = DockStyle.Top;
                    pnlPorderLoader.Controls.Add(control);
                }
                pnlPorderLoader.Show();
            }
        }

        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            loadPurchaseOrder();
        }

        internal void updateStockWithPurchaseOrder(int purchaseID)
        {
            InventoryPurUpdateForm form = new InventoryPurUpdateForm();
            form.purchaseOrderID = purchaseID;
            var dialogResult =  form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadPurchaseOrder();
            }
        }
    }
}
