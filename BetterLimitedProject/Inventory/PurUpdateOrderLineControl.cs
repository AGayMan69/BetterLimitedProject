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
    public partial class PurUpdateOrderLineControl : UserControl
    {
        internal InventoryPurUpdateForm _parent;
        internal int productID;
        internal byte[] productImage;
        internal string productName;
        internal int qty;

        public PurUpdateOrderLineControl()
        {
            InitializeComponent();
        }

        private void PurUpdateOrderLineControl_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            lblProductName.Text = productName;
            using (MemoryStream ms = new MemoryStream(productImage))
            {
                pbProduct.Image = Image.FromStream(ms);
            }
            lblQty.Text = qty.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = true;
            _parent.confirm(productID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnConfirm.Visible = true;
            _parent.cancel(productID);
        }
    }
}
