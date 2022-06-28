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

namespace BetterLimitedProject.Accounting
{
    public partial class AccountingDashBoardForm : Form
    {
        public AccountingDashBoardForm()
        {
            InitializeComponent();
        }

        private void AccountingDashBoardForm_Load(object sender, EventArgs e)
        {
            DateTime upperBound = DateTime.Now.GetThisMonthUpperBound();
            DateTime lowerBound = DateTime.Now.GetThisMonthLowerBound();
            using (var betterDB = new betterlimitedEntities())
            {
                lblSalesCreated.Text = (from salesOrderRec in betterDB.buyorders
                                        where salesOrderRec.order_date != null
                                              && salesOrderRec.order_date >= lowerBound
                                              && salesOrderRec.order_date <= upperBound
                                        select salesOrderRec).Count().ToString();

                lblOrderShipped.Text = (from salesOrderRec in betterDB.deliveries
                                        where salesOrderRec.type == 1
                                              && salesOrderRec.status == "Completed"
                                              && salesOrderRec.creation_time >= lowerBound
                                              && salesOrderRec.creation_time <= upperBound
                                        select salesOrderRec).Count().ToString();

                lblPurchaseQty.Text = (from purOL in betterDB.purchase_orderline
                                       where purOL.purchaseorder.approve_time >= lowerBound
                                             && purOL.purchaseorder.approve_time <= upperBound
                                       select purOL.qty).Sum().ToString();
                lblPurchaseTotal.Text = "$" +
                ((int)(from purchaseRec in betterDB.purchaseorders
                       where purchaseRec.approve_time >= lowerBound
                             && purchaseRec.approve_time <= upperBound
                       select purchaseRec.total).Sum());
                var top3item = betterDB.orderlines
                    .GroupBy(line => line.product_ID)
                    .Select(g => new
                    { 
                        id = g.FirstOrDefault().product_ID,
                       name = g.FirstOrDefault().product.name,
                       qty = g.Sum(u => u.quantity)
                    }).OrderByDescending(item => item.qty).Take(3).ToList();
                lblTop1itemName.Text = top3item[0].name;
                lblTop1ItemQuantity.Text = top3item[0].qty.ToString();
                lblTop2itemName.Text = top3item[1].name;
                lblTop2ItemQuantity.Text = top3item[1].qty.ToString();
                lblTop3itemName.Text = top3item[2].name;
                lblTop3ItemQuantity.Text = top3item[2].qty.ToString();

                List<PictureBox> pbList = new List<PictureBox>();
                pbList.Add(pbTopItem1);
                pbList.Add(pbTopItem2);
                pbList.Add(pbTopItem3);
                // loading image
                foreach (var item in top3item.Select((value, index) => new {index, value}))
                {
                    var itemPic = (from productRec in betterDB.products
                        where productRec.product_ID == item.value.id
                        select productRec.product_image).FirstOrDefault();
                    MemoryStream ms = new MemoryStream(itemPic);
                    pbList[item.index].Image = Image.FromStream(ms);

                }

                var salesByType = betterDB.orderlines
                    .Where(line =>
                        line.buyorder.order_date >= lowerBound && line.buyorder.order_date <= upperBound)
                    .GroupBy(line => line.product.category.category_name)
                    .Select(g => new
                    {
                        cat = g.FirstOrDefault().product.category.category_name,
                        total = g.Sum(u => u.quantity * u.product.price)
                    }).ToList();
                var totalSales = betterDB.buyorders.Select(order => order.total_price).Sum();
                foreach (var type in salesByType.Select((value, index) => new { index, value }))
                {
                    chartSale.Series["s1"].Points.AddXY(type.value.cat, type.value.total);
                }

                var productCount = betterDB.products.Count();
                var instockproduct = betterDB.warehouse_product
                    .Where(stockline => stockline.qty >= stockline.product.irestock_level)
                    .Count();
                var outofstockproduct = productCount - instockproduct;
                chartStock.Series["s1"].Points.AddXY("IN STOCK", instockproduct);
                chartStock.Series["s1"].Points.AddXY("OUT OF STOCK", outofstockproduct);

            }

        }
    }
}
