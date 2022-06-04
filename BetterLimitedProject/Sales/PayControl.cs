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
    public partial class PayControl : UserControl
    {
        private orderline line;
        internal string priceText;
        internal string totalText;
        internal string nameText;
        internal string qtyText;

        public PayControl()
        {
            InitializeComponent();
        }

        private void PayControl_Load(object sender, EventArgs e)
        {
            lblName.Text = nameText;
            lblQty.Text = qtyText;
            lblPrice.Text = priceText;
            lblTotal.Text = totalText;
        }
    }
}
