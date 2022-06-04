using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Sales
{
    public partial class SalesOrderControl : UserControl
    {
        internal buyorder order;
        internal SalesVwOrderForm _parent;

        public SalesOrderControl()
        {
            InitializeComponent();
        }

        private void SalesOrderControl_Load(object sender, EventArgs e)
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            _parent.DeleteOrder(order.order_ID);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.EditOrder(order.order_ID);
        }
    }
}
