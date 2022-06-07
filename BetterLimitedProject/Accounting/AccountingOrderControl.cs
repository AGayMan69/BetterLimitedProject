using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Accounting
{
    public partial class AccountingOrderControl : UserControl
    {
        internal buyorder order;
        internal AccountingVwOrderForm _parent;
        public AccountingOrderControl()
        {
            InitializeComponent();
        }

        private void AccountingOrderControl_Load(object sender, EventArgs e)
        {
            if (order != null)
            {

                lblCustomerID.Text = order.customer_ID.ToString();
                lblOrderID.Text = order.order_ID.ToString();
                lblDate.Text = order.order_date.ToString();
                lblTotal.Text = $"${order.total_price}";
                if (order.delivery_ID == 0)
                {
                    lblDeliveryID.Text = "";
                }
                else
                {
                    lblDeliveryID.Text = order.delivery_ID.ToString();
                }

                if (order.installation_ID == 0)
                {
                    lblInstallationID.Text = "";
                }
                else
                {
                    lblInstallationID.Text = order.installation_ID.ToString();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _parent.viewOrder(order.order_ID);
        }
    }
}
