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

namespace BetterLimitedProject.Sales
{
    public partial class SalesEditOrderForm : Form
    {
        internal int orderID;
        internal SalesVwOrderForm _parent;
        internal bool walkIn;

        public SalesEditOrderForm()
        {
            InitializeComponent();
        }

        private void SalesEditOrderForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var orderResult = (from orderRec in betterDB.buyorders
                                   where orderRec.order_ID == orderID
                                   select orderRec).AsNoTracking().FirstOrDefault();
                var customerResult = (from orderRec in betterDB.buyorders
                                      where orderRec.order_ID == orderID
                                      select orderRec.customer).AsNoTracking().FirstOrDefault();
                if (customerResult.user_ID == 1000000000)
                {
                    panCustomerInfo.Visible = false;
                    panDelivery.Visible = false;
                    walkIn = true;
                }
                else
                {
                    walkIn = false;
                    var delResult = (from buyRec in betterDB.buyorders
                                     where buyRec.order_ID == orderID
                                     select buyRec.delivery).AsNoTracking().FirstOrDefault();
                    tbCustomerName.Text = customerResult.name;
                    tbEmail.Text = customerResult.email;
                    tbPhone.Text = customerResult.phone_No.ToString();
                    tbAddress.Text = customerResult.address;
                    lblDeliveryID.Text = $"Delivery ID: {orderID}";
                    dtpDeliveryTime.Value = (DateTime)delResult.delivery_date;
                }

                foreach (var line in orderResult.orderlines)
                {
                    SalesOrderLineControl productLineControl = new SalesOrderLineControl();
                    productLineControl.productName = line.product.name;
                    productLineControl.productImage = line.product.product_image;
                    productLineControl.qty = line.quantity;
                    productLineControl.Dock = DockStyle.Top;
                    panOrderlineLoader.Controls.Add(productLineControl);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (walkIn)
            {
                this.DialogResult = DialogResult.Ignore;
            }
            else
            {
                if (tbCustomerName.Text == "")
                {
                    MessageBox.Show("Please input a Name!!");
                    return;
                }

                if (tbPhone.Text == "")
                {
                    MessageBox.Show("Please input a Phone number");
                    return;
                }

                int phone;
                try
                {
                    phone = Int32.Parse(tbPhone.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input a valid phone number!!");
                    return;
                }

                if (tbEmail.Text == "")
                {
                    MessageBox.Show("Please input a email");
                    return;
                }

                if (tbAddress.Text == "")
                {
                    MessageBox.Show("Please input a address!!");
                    return;
                }

                using (var betterDB = new betterlimitedEntities())
                {
                    var customerResult = (from buyRec in betterDB.buyorders
                        where buyRec.order_ID == orderID
                        select buyRec.customer).FirstOrDefault();
                    customerResult.name = tbCustomerName.Text;
                    customerResult.phone_No = phone;
                    customerResult.email = tbEmail.Text;
                    customerResult.address = tbAddress.Text;

                    var deliResult = (from buyRec in betterDB.buyorders
                        where buyRec.order_ID == orderID
                        select buyRec.delivery).FirstOrDefault();
                    deliResult.delivery_date = dtpDeliveryTime.Value;
                    betterDB.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
