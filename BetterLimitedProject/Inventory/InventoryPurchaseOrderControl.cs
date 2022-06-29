using System;
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
    public partial class InventoryPurchaseOrderControl : UserControl
    {
        internal InventoryVwPurchaseForm _parent;
        internal int poID;
        internal string supplier;
        internal DateTime creatTime;
        internal string status;
        public InventoryPurchaseOrderControl()
        {
            InitializeComponent();
        }

        private void InventoryPurchaseOrderControl_Load(object sender, EventArgs e)
        {
            lblApprove.Visible = false;
            lblReject.Visible = false;
            lblPENDING.Visible = false;
            btnRestock.Visible = false;
            lblPOrderID.Text = poID.ToString();
            lblSupplier.Text = supplier;
            lblCreatTime.Text = creatTime.ToString();
            if (status == "PENDING")
            {
                lblPENDING.Visible = true;
                btnView.Location = new Point(btnView.Location.X + 100, btnView.Location.Y);
            }
            else if (status == "APPROVED")
            {
                lblApprove.Visible = true;
                btnRestock.Visible = true;
            }
            else
            {
                lblReject.Visible = true;
                btnView.Location = new Point(btnView.Location.X + 100, btnView.Location.Y);
            }

        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            _parent.updateStockWithPurchaseOrder(poID);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DocumentViewer.showPurchaseOrder(poID);
        }
    }
}
