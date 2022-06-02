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

namespace BetterLimitedProject
{
    public partial class ImageTestingForm : Form
    {
        public ImageTestingForm()
        {
            InitializeComponent();
        }

        private void ImageTestingForm_Load(object sender, EventArgs e)
        {
            using (var betterDb = new betterlimitedEntities())
            {
                var productImage = (from row in betterDb.products
                    select row).FirstOrDefault();

                File.WriteAllBytes(@"C:\Users\WindowsEnjoyer\test.jpg", productImage.image);
            }
        }
    }
}
