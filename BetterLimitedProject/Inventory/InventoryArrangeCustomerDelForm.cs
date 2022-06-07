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
    public partial class InventoryArrangeCustomerDelForm : Form
    {
        internal int deliveryID;
        internal InventoryVwDeliveryForm _parent;

        public InventoryArrangeCustomerDelForm()
        {
            InitializeComponent();
        }

        private void InventoryArrangeCustomerDelForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var orderResult = (from orderRec in betterDB.buyorders
                                   where orderRec.delivery_ID == deliveryID
                                   select orderRec).AsNoTracking().FirstOrDefault();
                var customerResult = (from orderRec in betterDB.buyorders
                                   where orderRec.delivery_ID == deliveryID
                                   select orderRec.customer).AsNoTracking().FirstOrDefault();
                var delResult = (from delRec in betterDB.deliveries
                                   where delRec.delivery_ID == deliveryID
                                   select delRec).AsNoTracking().FirstOrDefault();
                lblCustomerName.Text = customerResult.name;
                lblEmail.Text = customerResult.email;
                lblPhone.Text = customerResult.phone_No.ToString();
                tbAddress.Text = customerResult.address;
                lblDeliveryID.Text = $"Delivery ID: {deliveryID}";
                dtpDeliveryTime.Value = (DateTime)delResult.delivery_date;

                foreach (var line in orderResult.orderlines)
                {
                    InventoryProductControl productLineControl = new InventoryProductControl();
                    productLineControl.productName = line.product.name;
                    productLineControl.productImage = line.product.product_image;
                    productLineControl.qty = line.quantity;
                    productLineControl.Dock = DockStyle.Top;
                    panOrderlineLoader.Controls.Add(productLineControl);
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _parent.deliveryTime = dtpDeliveryTime.Value;
        }
    }
}
