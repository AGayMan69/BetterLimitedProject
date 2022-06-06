using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryArrangeReplenishForm : Form
    {
        internal int deliveryID;
        internal InventoryVwDeliveryForm _parent;

        public InventoryArrangeReplenishForm()
        {
            InitializeComponent();
        }

        private void InventoryArrangeReplenishForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var replenishLineResult = (from line in betterDB.replenishment_product
                                           where line.delivery_ID == deliveryID
                                           select new { line.product.name, line.qty, line.product.product_image }).AsNoTracking();
                var replenishResult = (from replenishRec in betterDB.replenishments
                                       where replenishRec.delivery_ID == deliveryID
                                       select new { replenishRec.request_date }).AsNoTracking().FirstOrDefault();
                var storeResult = (from replenishRec in betterDB.replenishments
                                   where replenishRec.delivery_ID == deliveryID
                                   select replenishRec.retail_store).AsNoTracking().FirstOrDefault();

                lblRequestTime.Text = replenishResult.request_date.ToString();
                lblStoreName.Text = (storeResult.store_ID == 1) ? "Kowloon Bay Store" : "Tsuen Wan";
                lblManager.Text = storeResult.staff.name;
                lblOpenHr.Text = storeResult.opening_hour.ToString();
                lblClosingHour.Text = storeResult.closing_hour.ToString();
                lblEmail.Text = storeResult.contact_email;
                lblPhone.Text = storeResult.contact_number.ToString();
                tbAddress.Text = storeResult.address;
                dtpDeliveryTime.Value = _parent.deliveryTime;

                foreach (var line in replenishLineResult)
                {
                    InventoryProductControl lineControl = new InventoryProductControl() { Dock = DockStyle.Top };
                    lineControl.productName = line.name;
                    lineControl.productImage = line.product_image;
                    lineControl.qty = line.qty;
                    panReplenishLoader.Controls.Add(lineControl);
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _parent.deliveryTime = dtpDeliveryTime.Value;
        }
    }
}
