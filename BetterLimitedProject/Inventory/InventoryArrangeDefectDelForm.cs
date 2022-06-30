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

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryArrangeDefectDelForm : Form
    {
        internal int deliveryID;
        internal InventoryVwDeliveryForm _parent;

        public InventoryArrangeDefectDelForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _parent.deliveryTime = dtpDeliveryTime.Value;
        }

        private void InventoryArrangeDefectDelForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var defectResult = (from defectRec in betterDB.defects
                    where defectRec.delivery_ID == deliveryID
                    select defectRec).AsNoTracking().FirstOrDefault();
                lblProductName.Text = defectResult.product.name;
                lblCategory.Text = defectResult.product.category.category_name;
                lblDeliveryID.Text = defectResult.delivery_ID.ToString();
                lblSupplier.Text = defectResult.product.supplier.supplier_name;
                tbDescription.Text = defectResult.description;
                using (MemoryStream ms = new MemoryStream(defectResult.product.product_image))
                {
                    pbProduct.Image = Image.FromStream(ms);
                }
                if (defectResult.delivery.delivery_date != null)
                {
                    dtpDeliveryTime.Value = (DateTime)defectResult.delivery.delivery_date;
                }
                else
                {
                    dtpDeliveryTime.Value = _parent.deliveryTime;
                }
            }
        }
    }
}
