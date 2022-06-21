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

namespace BetterLimitedProject.Sales
{
    public partial class SalesReservationConfirmForm : Form
    {
        internal int reservationID;
        //private reservation targetRersvation;
        //private customer targetCustomer;
        //private product targetProduct;
        internal int total;
        private class reservationInternal
        {
            internal reservation targetRersvation;
            internal customer targetCustomer;
            internal product targetProduct;
        }

        private reservationInternal reserFormData;

        public SalesReservationConfirmForm()
        {
            InitializeComponent();
        }

        private void SalesReservationConfirmForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                reserFormData = (from reservationRec in betterDB.reservations
                    where reservationRec.reservation_ID == reservationID
                    select new reservationInternal()
                    {
                        targetRersvation = reservationRec,
                        targetCustomer = reservationRec.customer,
                        targetProduct = reservationRec.product
                    }).AsNoTracking().FirstOrDefault();
            }

            lblReservationID.Text = "Reseravtion#" + reserFormData.targetRersvation.reservation_ID;
            lblReservationDate.Text = "Reservation Date: " + reserFormData.targetRersvation.reservation_date.ToString();
            lblCustomerName.Text = reserFormData.targetCustomer.name;
            lblEmailAddress.Text = reserFormData.targetCustomer.email;
            lblPhoneNumber.Text = reserFormData.targetCustomer.phone_No.ToString();
            tbAddress.Text = reserFormData.targetCustomer.address;

            MemoryStream ms = new MemoryStream(reserFormData.targetProduct.product_image);
            pbProductImage.Image = Image.FromStream(ms);
            lblProductName.Text = reserFormData.targetProduct.name;
            lblQty.Text = reserFormData.targetRersvation.qty.ToString();
            total= (int) (reserFormData.targetRersvation.qty * reserFormData.targetProduct.price);
            lblAmount.Text = $"$ {total}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var reserResult = (from reserRec in betterDB.reservations
                    where reserRec.reservation_ID == reservationID
                    select reserRec).FirstOrDefault();
                reserResult.complete_date = DateTime.Now;
                buyorder newOrder = new buyorder();

                // Generating new order id
                string strYear = DateTime.Now.Year.ToString();
                int year = Int32.Parse(strYear.Remove(0, 2));
                int tempID = year * (int)Math.Pow(10, 5);

                int newOrderID;
                var latestOrder = (from orderRec in betterDB.buyorders
                                      where orderRec.order_ID >= tempID
                                      orderby orderRec.order_ID descending
                                      select orderRec).AsNoTracking().FirstOrDefault();

                if (latestOrder == null)
                {
                    newOrderID = tempID;
                }
                else
                {
                    newOrderID = latestOrder.order_ID + 1;
                }

                newOrder.order_ID = newOrderID;
                newOrder.customer_ID = reserFormData.targetCustomer.user_ID;
                newOrder.order_date = DateTime.Now;
                newOrder.total_price = total;
                betterDB.buyorders.Add(newOrder);

                orderline newLine = new orderline();
                newLine.product_ID = reserFormData.targetProduct.product_ID;
                newLine.order_ID = newOrderID;
                newLine.quantity = reserFormData.targetRersvation.qty;
                betterDB.orderlines.Add(newLine);

                betterDB.SaveChanges();
                MessageBox.Show("Payment Success");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
