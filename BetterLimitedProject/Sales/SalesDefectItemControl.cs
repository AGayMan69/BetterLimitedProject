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

namespace BetterLimitedProject.Sales
{

    public partial class SalesDefectItemControl : UserControl
    {
        internal byte[] imageSource;
        internal string productName;
        internal string category;

        public SalesDefectItemControl()
        {
            InitializeComponent();
        }

        private void SalesDefectItemControl_Load(object sender, EventArgs e)
        {
            lblProductName.Text = productName;
            using (var betterDB = new betterlimitedEntities())
            {

                var productResults = (from itemRec in betterDB.products
                                     where itemRec.name == productName
                                     select new { itemRec.product_image, itemRec.category.category_name }).AsNoTracking().FirstOrDefault();
                category = productResults.category_name;
                imageSource = productResults.product_image;
            }
            lblCategory.Text = category;
            MemoryStream ms = new MemoryInputStream(imageSource);
            try
            {
                Image image = Image.FromStream(ms);
                pbProduct.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{productName} can not be converted");
            }
        }
    }
}
