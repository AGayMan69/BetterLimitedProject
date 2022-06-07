using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Sales
{
    public partial class SalesOrderLineControl : UserControl
    {
        internal string productName;
        internal byte[] productImage;
        internal int qty;

        public SalesOrderLineControl()
        {
            InitializeComponent();
        }

        private void SalesOrderLineControl_Load(object sender, EventArgs e)
        {
            lblProductName.Text = productName;
            lblQty.Text = qty.ToString();
            MemoryStream ms = new MemoryStream(productImage);
            try
            {
                pbProductImage.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
