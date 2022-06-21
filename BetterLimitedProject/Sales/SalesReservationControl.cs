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
    public partial class SalesReservationControl : UserControl
    {
        internal int id;
        internal string customerName;
        internal DateTime? reservatoinDate;
        internal SalesPayReserForm _parent;

        public SalesReservationControl()
        {
            InitializeComponent();
        }

        private void SalesReservationControl_Load(object sender, EventArgs e)
        {
            lblReservationID.Text = id.ToString();
            lblCustomerName.Text = customerName;
            lblReservationDate.Text = reservatoinDate.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _parent.DeleteReservation(id);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            _parent.PayReservation(id);
        }
    }
}
