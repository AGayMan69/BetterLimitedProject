using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject
{
    public class DocumentViewer
    {
        private static int orderID;
        public static void showPurchaseOrder(int orderID)
        {
            DocumentViewer.orderID = orderID;
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 850, 1000);
            pd.PrintPage += generatePurchaseOrder;
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            printDialog.Document = pd;
            printDialog.ShowDialog();
        }

        private static void generatePurchaseOrder(object sender, PrintPageEventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var purchaseResult = (from purchaseRec in betterDB.purchaseorders
                    where purchaseRec.purchase_order_ID == orderID
                    select purchaseRec).AsNoTracking().FirstOrDefault();

                             //====================================================================================================
                Font Title = new Font("Century Gothic", 25, FontStyle.Bold);
                Font bold = new Font("Times New Roman", 9, FontStyle.Bold);
                Font supplier = new Font("Times New Roman", 15, FontStyle.Bold);
                Font normal = new Font("Arial", 8, FontStyle.Regular);
                Font linenormal = new Font("Arial", 8, FontStyle.Regular);

                string line = new string('═', 100);
                float height = 30;
                string delivery = $"Purchase Order #{DocumentViewer.orderID}";
                e.Graphics.DrawString(delivery, bold, Brushes.Gray, 20, height, new StringFormat());



                var warehouse = (from warehouseRec in betterDB.warehouses
                    where warehouseRec.warehouse_ID == 1
                    select warehouseRec).AsNoTracking().FirstOrDefault();
                int timeX = 720;
                int realTX = timeX - 50;
                e.Graphics.DrawString("Creation Time", bold, Brushes.Black, timeX, height, new StringFormat());
                height += 15;
                e.Graphics.DrawString(purchaseResult.creation_time.ToString(), normal, Brushes.Gray, realTX, height, new StringFormat());
                height += 25;
                e.Graphics.DrawString("Approval Time", bold, Brushes.Black, timeX, height, new StringFormat());
                height += 15;
                e.Graphics.DrawString(purchaseResult.approve_time.ToString(), normal, Brushes.Gray, realTX, height, new StringFormat());

                height = 60;
                            e.Graphics.DrawString("Business Invoice", Title, Brushes.Black, 300, height, new StringFormat());
                height += 80;
                e.Graphics.DrawString("Supplier:", supplier, Brushes.Black, 20, height, new StringFormat());
                height += 30;
                e.Graphics.DrawString(purchaseResult.supplier.supplier_name, bold, Brushes.Black, 20, height, new StringFormat());
                height += 60;
                e.Graphics.DrawString("Ship to:", bold, Brushes.Black, 20, height, new StringFormat());
                height += 30;
                e.Graphics.DrawString("Warehouse: 1", bold, Brushes.Black, 20, height, new StringFormat());
                height += 30;
                e.Graphics.DrawString(warehouse.address, bold, Brushes.Black, 20, height, new StringFormat());
                height += 30;
                e.Graphics.DrawString("Zip Code :" + warehouse.zip_code, bold, Brushes.Black, 20, height, new StringFormat());
                height += 80;
                height += 17;
                e.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());
                height += 17;
                int productX = 20;
                int priceX = productX + 580;
                int quantX = priceX + 80;
                int totalX = quantX + 70;
                e.Graphics.DrawString("Product", bold, Brushes.Black, productX, height, new StringFormat());
                e.Graphics.DrawString("Price", bold, Brushes.Black, priceX, height, new StringFormat());
                e.Graphics.DrawString("Quant.", bold, Brushes.Black, quantX, height, new StringFormat());
                e.Graphics.DrawString("Total Amount", bold, Brushes.Black, totalX, height, new StringFormat());
                height += 25;
                e.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());
                height += 25;

                    foreach (var orderline in purchaseResult.purchase_orderline)
                    {
                        string productName = orderline.product.name;
                        string price = "$" + orderline.product.price.ToString();
                        string qty = orderline.qty.ToString();
                        string total = "$" + (orderline.qty * orderline.product.price).ToString();
                        var priceWid = e.Graphics.MeasureString(price, normal);
                        var qtyWid = e.Graphics.MeasureString(qty, normal);
                        var totalWid = e.Graphics.MeasureString("$" + total, normal);

                        e.Graphics.DrawString(productName, normal, Brushes.Black, productX, height, new StringFormat());
                        e.Graphics.DrawString(price, normal, Brushes.Black, priceX + (50 - priceWid.Width), height, new StringFormat());
                        e.Graphics.DrawString(qty, normal, Brushes.Black, quantX + (30 - qtyWid.Width), height, new StringFormat());
                        e.Graphics.DrawString(total, normal, Brushes.Black, totalX + (70 - totalWid.Width), height, new StringFormat());
                        height += 20;
                    }
                    string allTotal = purchaseResult.total.ToString();
                    var allTotalWid = e.Graphics.MeasureString(allTotal, normal);
                    e.Graphics.DrawString("$" + allTotal, normal, Brushes.Black, totalX + (70 - allTotalWid.Width), 720, new StringFormat());

                height = 700;
                e.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());

            }
        }

    }

}
