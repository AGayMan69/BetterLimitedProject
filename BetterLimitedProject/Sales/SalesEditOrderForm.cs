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
    public partial class SalesEditOrderForm : Form
    {
        internal int orderID;
        internal float price;

        public SalesEditOrderForm()
        {
            InitializeComponent();
        }

        private void SalesEditOrderForm_Load(object sender, EventArgs e)
        {
            lblOrder.Text = orderID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
