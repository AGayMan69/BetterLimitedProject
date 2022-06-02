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
    public partial class POSProductControl : UserControl
    {
        private SalesCreaOrderForm _parentform;

        public int productID { get; set; }

        public string productName
        {
            get { return productName; }
            set { lblProductName.Text = value; }
        }

        public byte[] ImageBytes
        {
            get { return ImageBytes; }
            set
            {
                MemoryStream ms = new MemoryStream(value);
                //Image image = Image.FromStream(ms);
                //pbProduct.Image = Image.FromStream(imageStream);
            }
        }
        public POSProductControl(SalesCreaOrderForm parentform)
        {
            InitializeComponent();
            this._parentform = parentform;
        }

        private void pbProduct_DoubleClick(object sender, EventArgs e)
        {
            _parentform.addProduct(productID);
        }

        private void panProductdesc_DoubleClick(object sender, EventArgs e)
        {
            _parentform.addProduct(productID);
        }
    }
}
