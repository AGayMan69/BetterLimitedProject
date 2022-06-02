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
    public partial class POSOrderLineControl : UserControl
    {
        internal orderline line;
        private SalesCreaOrderForm parent;

        public POSOrderLineControl()
        {
            InitializeComponent();
        }

        public POSOrderLineControl(SalesCreaOrderForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void POSOrderLineControl_Load(object sender, EventArgs e)
        {
            lblProductName.Text = line.product.name;
            lblPrice.Text = "$" + (line.quantity * line.product.price).ToString();
            numUpDwnQty.Value = (decimal)line.quantity;
        }

        private void numUpDwnQty_ValueChanged(object sender, EventArgs e)
        {
            line.quantity = (int) numUpDwnQty.Value;
            parent.UpdatePrice();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            parent.DeleteItem(line);
            Parent.Controls.Remove(this);
        }
    }
}
