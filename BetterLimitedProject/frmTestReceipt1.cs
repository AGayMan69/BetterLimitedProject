using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject
{
    public partial class frmTestReceipt1 : Form
    {
        private int deliveryID;
        public frmTestReceipt1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 600, 800);
                PrinterSettings ps = new PrinterSettings();
                pd.PrintPage += generateReceipt;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateReceipt(object sender, PrintPageEventArgs ev)
        {
            //====================================================================================================
            using (var betterDB = new betterlimitedEntities())
            {
                deliveryID = 2200011;
                var buyorderResult = (from orderRec in betterDB.buyorders
                                      where orderRec.delivery_ID == deliveryID
                                      select orderRec).AsNoTracking().FirstOrDefault();
                var retailstore = (from storeRec in betterDB.retail_store
                                   where storeRec.store_ID == 1
                                   select storeRec).AsNoTracking().FirstOrDefault();

                //====================================================================================================
                Font CompanyName = new Font("Century Gothic", 25, FontStyle.Bold);
                Font bold = new Font("Times New Roman", 9, FontStyle.Bold);
                Font normal = new Font("Arial", 8, FontStyle.Regular);
                Font linenormal = new Font("Arial", 8, FontStyle.Regular);


                string line = new string('═', 100);
                float height = 30;
                string delivery = $"Delivery ID: {buyorderResult.delivery_ID}";
                ev.Graphics.DrawString(delivery, bold, Brushes.Gray, 20, height, new StringFormat());
                int hourX = 720;
                int realHX = hourX + 50;
                ev.Graphics.DrawString("Opening Hour", bold, Brushes.Black, hourX, height, new StringFormat());
                height += 15;
                ev.Graphics.DrawString(new DateTime(retailstore.opening_hour.Ticks).ToString("HH:mm"), normal, Brushes.Gray, realHX, height, new StringFormat());
                height += 25;
                ev.Graphics.DrawString("Closing Hour", bold, Brushes.Black, hourX, height, new StringFormat());
                height += 15;
                ev.Graphics.DrawString(new DateTime(retailstore.closing_hour.Ticks).ToString("HH:mm"), normal, Brushes.Gray, realHX, height, new StringFormat());

                height = 60;


                ev.Graphics.DrawString("Better Limited", CompanyName, Brushes.Black, 300, height, new StringFormat());
                height += 80;
                ev.Graphics.DrawString("Address : " + retailstore.address, bold, Brushes.Black, 20, height, new StringFormat());
                height += 30;
                ev.Graphics.DrawString("Contact Number : " + retailstore.contact_number.ToString(), bold, Brushes.Black, 20, height, new StringFormat());
                height += 80;
                ev.Graphics.DrawString("Order Date : " + buyorderResult.order_date.ToString(), bold, Brushes.Black, 20, height, new StringFormat());
                height += 17;
                ev.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());
                height += 17;
                int productX = 20;
                int priceX = productX + 580;
                int quantX = priceX + 80;
                int totalX = quantX + 70;
                ev.Graphics.DrawString("Product", bold, Brushes.Black, productX, height, new StringFormat());
                ev.Graphics.DrawString("Price", bold, Brushes.Black, priceX, height, new StringFormat());
                ev.Graphics.DrawString("Quant.", bold, Brushes.Black, quantX, height, new StringFormat());
                ev.Graphics.DrawString("Total Price", bold, Brushes.Black, totalX, height, new StringFormat());
                height += 25;
                ev.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());
                height += 25;
                foreach (var orderline in buyorderResult.orderlines)
                {
                    string productName = orderline.product.name;
                    string price = "$" + orderline.product.price.ToString();
                    string qty = orderline.quantity.ToString();
                    string total = "$" + (orderline.quantity * orderline.product.price).ToString();
                    var priceWid = ev.Graphics.MeasureString(price, normal);
                    var qtyWid = ev.Graphics.MeasureString(qty, normal);
                    var totalWid = ev.Graphics.MeasureString("$" + total, normal);

                    ev.Graphics.DrawString(productName, normal, Brushes.Black, productX, height, new StringFormat());
                    ev.Graphics.DrawString(price, normal, Brushes.Black, priceX + (50 - priceWid.Width), height, new StringFormat());
                    ev.Graphics.DrawString(qty, normal, Brushes.Black, quantX + (30 - qtyWid.Width), height, new StringFormat());
                    ev.Graphics.DrawString(total, normal, Brushes.Black, totalX + (70 - totalWid.Width), height, new StringFormat());
                    height += 20;
                }

                height = 700;
                ev.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());
                height += 20;
                string allTotal = buyorderResult.total_price.ToString();
                var allTotalWid = ev.Graphics.MeasureString(allTotal, normal);
                ev.Graphics.DrawString("$" + allTotal, normal, Brushes.Black, totalX + (70 - allTotalWid.Width), height, new StringFormat());

                height = 850;
                int tyX = 300;
                ev.Graphics.DrawString("Thank you for your payment!!", bold, Brushes.Black, tyX, height, new StringFormat());




                ev.HasMorePages = false;
            }
        }

    }
}
