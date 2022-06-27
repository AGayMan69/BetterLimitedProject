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

namespace BetterLimitedProject.Purchase
{
    public partial class PurchaseVwGoodRecievedForm : Form
    {
        private bool loading;
        public PurchaseVwGoodRecievedForm()
        {
            InitializeComponent();
        }

        private void PurchaseVwGoodRecievedForm_Load(object sender, EventArgs e)
        {
            loading = true;
            cboDate.SelectedIndex = 0;
            loading = false;
            loadReceiveGoods();
        }

        internal void loadReceiveGoods()
        {
            if (loading)
            {
                return;
            }
            pnlReceiveGDLoader.Controls.Clear();
            // get date parameter
            DateTime upperBound;
            DateTime lowerBound;
            if (cboDate.SelectedItem == "Today")
            {
                lowerBound = DateTime.Today;
                upperBound = DateTime.Today.GetTodayUpperBound();
            }
            else if (cboDate.SelectedItem == "This Week")
            {
                upperBound = DateTime.Now.GetThisWeekUpperBound();
                lowerBound = DateTime.Now.GetThisWeekLowerBound();
            }
            else if (cboDate.SelectedItem == "This Month")
            {
                upperBound = DateTime.Now.GetThisMonthUpperBound();
                lowerBound = DateTime.Now.GetThisMonthLowerBound();
            }
            else
            {
                upperBound = DateTime.Now.GetThisYearUpperBound();
                lowerBound = DateTime.Now.GetThisYearLowerBound();
            }

            using (var betterDB = new betterlimitedEntities())
            {
                var receivedGoodResult = (from receiveRec in betterDB.good_received
                                          where receiveRec.received_time >= lowerBound
                                                && receiveRec.received_time <= upperBound
                                          select receiveRec).AsNoTracking();
                foreach (var goodReceived in receivedGoodResult)
                {
                    PurchaseGoodControl control = new PurchaseGoodControl() { Dock = DockStyle.Top };
                    control.purchaseID = goodReceived.purchase_order_id;
                    control.receiveID = goodReceived.received_id;
                    control.receivedTime = goodReceived.received_time;
                    pnlReceiveGDLoader.Controls.Add(control);
                }
            }

        }

        private void cboDate_SelectedValueChanged(object sender, EventArgs e)
        {
            loadReceiveGoods();
        }
    }
}
