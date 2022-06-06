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

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryProductControl : UserControl
    {
        internal string productName;
        internal byte[] productImage;
        internal int qty;

        public InventoryProductControl()
        {
            InitializeComponent();
        }

        private void InventoryProductControl_Load(object sender, EventArgs e)
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
