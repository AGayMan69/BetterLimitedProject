using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Purchase
{
    public partial class PurchaseGoodControl : UserControl
    {
        internal int receiveID;
        internal int purchaseID;
        internal DateTime receivedTime;

        public PurchaseGoodControl()
        {
            InitializeComponent();
        }

        private void PurchaseGoodControl_Load(object sender, EventArgs e)
        {
            lblReceiveID.Text = receiveID.ToString();
            lblPurchaseOrderID.Text = purchaseID.ToString();
            lblReceivedTime.Text = receivedTime.ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DocumentViewer.showPurchaseOrder(purchaseID);
        }
    }
}
