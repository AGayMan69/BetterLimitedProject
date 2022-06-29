using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities.IO;

namespace BetterLimitedProject.Inventory
{
    public partial class inventoryPurchaseOrderLineControl : UserControl
    {
        internal InventoryVwStockForm _parent;
        internal int product_id;
        internal string supplier;
        internal byte[] product_image;
        internal string product_name;

        public inventoryPurchaseOrderLineControl()
        {
            InitializeComponent();
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            _parent.removePurchaseOrderline(product_id, supplier);
            this.Parent.Controls.Remove(this);
        }

        private void inventoryPurchaseOrderLineControl_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var productResult = (from productRec in betterDB.products
                                     where productRec.product_ID == product_id
                                     select new { productRec.name, productRec.product_image }).AsNoTracking().FirstOrDefault();
                product_name = productResult.name;
                product_image = productResult.product_image;
            }

            lblSupplier.Text = supplier;
            lblProductName.Text = product_name;
            using (MemoryStream ms = new MemoryStream(product_image))
            {
               pbProduct.Image = Image.FromStream(ms); 
            }

        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            _parent.editPurchaseOrderLineQty(product_id, supplier, (int)nudQty.Value);
        }
    }
}
