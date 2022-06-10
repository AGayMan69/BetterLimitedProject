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
using MailKit.Search;

namespace BetterLimitedProject.Sales
{
    public partial class SalesCreaOrderForm : Form
    {
        enum OrderOption
        {
            LevelCUSTOMER,
            LevelDelivery,
            LevelDeposit
        }

        private IQueryable<product> productList;
        private betterlimitedEntities betterDb;
        private List<orderline> shoppingCart;
        private int cartCount;
        private buyorder order;
        private string categorySearch;
        private string nameSearch;
        private OrderOption ordOption;
        private int newOrderID;



        public SalesCreaOrderForm()
        {
            InitializeComponent();
        }

        private void SalesCreaOrderForm_Load(object sender, EventArgs e)
        {
            betterDb = new betterlimitedEntities();
            shoppingCart = new List<orderline>();

            // Generating new buy order id
            string strYear = DateTime.Now.Year.ToString();
            int year = Int32.Parse(strYear.Remove(0, 2));
            int tempID = year * (int)Math.Pow(10, 5);

            var latestOrder = (from buyorderRec in betterDb.buyorders
                               where buyorderRec.order_ID >= tempID
                               orderby buyorderRec.order_ID descending
                               select buyorderRec).AsNoTracking().FirstOrDefault();

            if (latestOrder == null)
            {
                newOrderID = tempID;
            }
            else
            {
                newOrderID = latestOrder.order_ID + 1;
            }
            order = new buyorder();
            order.order_ID = newOrderID;
            dtpDeliveryTime.MinDate = DateTime.Now.AddDays(15);

            UpdatePrice();
            categorySearch = "";
            nameSearch = "";
            loadComboBox();
            lblBuyOrder.Text = $"Order ID: {order.order_ID}";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tpFillInfo)
            {
                fillInOnLoad();
            }
            else if (tabControl.SelectedTab == tpPay)
            {
                payOnLoad();
            }
            else if (tabControl.SelectedTab == tpPrintReceipt)
            {
                receiptOnLoad();
            }
        }

        private void loadProduct()
        {
            productList = (from productRec in betterDb.products
                           join categoryRec in betterDb.categories
                               on productRec.category_ID equals categoryRec.category_ID
                           where categoryRec.category_name.Contains(categorySearch)
                           where productRec.name.Contains(nameSearch)
                           select productRec).AsNoTracking();

            flpanProduct.Controls.Clear();
            flpanProduct.Hide();
            foreach (var product in productList.ToList())
            {
                POSProductControl productControl = new POSProductControl(this);

                productControl.productID = product.product_ID;
                productControl.productName = product.name;
                productControl.ImageBytes = product.product_image;
                flpanProduct.Controls.Add(productControl);
            }
            flpanProduct.Show();    
        }

        internal void addProduct(int productID)
        {
            product addedProduct = (from product in productList
                                    where product.product_ID.Equals(productID)
                                    select product).AsNoTracking().FirstOrDefault();
            if (shoppingCart.Exists(x => x.product_ID.Equals(addedProduct.product_ID)))
            {

                MessageBox.Show("Duplicate item!!");
            }
            else
            {
                orderline orderln = new orderline();

                orderln.product_ID = addedProduct.product_ID;
                orderln.order_ID = order.order_ID;
                orderln.product = addedProduct;
                orderln.quantity = 1;
                shoppingCart.Add(orderln);
                POSOrderLineControl orderLineControl = new POSOrderLineControl(this) { Dock = DockStyle.Top };
                orderLineControl.line = orderln;
                orderLineControl.product = addedProduct;
                panOrderLine.Controls.Add(orderLineControl);

            }
            UpdatePrice();
            cartCount++;
            MessageBox.Show($"You have {cartCount} item(s) in your cart");
        }

        internal void UpdatePrice()
        {
            float total = 0;
            int counter = 0;
            foreach (orderline line in shoppingCart)
            {
                //MessageBox.Show($"You have ordered: {line.product.name}\n quantity: {line.quantity}");
                total += (float)line.quantity * line.product.price;
                counter++;
            }

            lblPrice.Text = $"$ {total:0.##}";
            //MessageBox.Show($"{counter} item(s) ordered!!!");
        }

        internal void DeleteItem(orderline line)
        {
            var removeItem = shoppingCart.SingleOrDefault(x => x.product_ID == line.product_ID);
            shoppingCart.Remove(removeItem);
            cartCount--;
            MessageBox.Show($"You have {cartCount} item(s) in your cart");
            UpdatePrice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panOrderLine.Controls.Clear();
            shoppingCart.Clear();
            UpdatePrice();
        }

        private void loadComboBox()
        {
            cboCategory.SelectedIndex = 0;
            var cat = (from catRec in betterDb.categories
                       select catRec.category_name).AsNoTracking();
            foreach (var categoryitem in cat.ToList())
            {
                cboCategory.Items.Add(categoryitem);
            }
        }

        private void cboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            tbSearch.Clear();
            nameSearch = tbSearch.Text;
            if (cboCategory.Text == "-- Select Category --")
            {
                categorySearch = "";
            }
            else
            {
                categorySearch = cboCategory.SelectedItem.ToString();
            }
            loadProduct();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            nameSearch = tbSearch.Text;
            loadProduct();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            // at least 1 item to checkout
            if (cartCount < 1)
            {
                MessageBox.Show("Please select at least 1 item before checkout!!");
            }
            else
            {
                tabControl.SelectedTab = tpOption;
            }
        }

        // =========================================== Option Page Section =======================================================
        private void btnBackCart_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tpShoppingCart;
        }

        private void btnSelectDelivery_Click(object sender, EventArgs e)
        {
            ordOption = OrderOption.LevelDelivery;
            tabControl.SelectedTab = tpFillInfo;
        }

        private void btnSelectDeposit_Click(object sender, EventArgs e)
        {
            ordOption = OrderOption.LevelDeposit;
            tabControl.SelectedTab = tpFillInfo;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            ordOption = OrderOption.LevelCUSTOMER;
            tabControl.SelectedTab = tpPay;
        }
        // =========================================== Option Page Section =======================================================

        // =========================================== Fill in Page Section =======================================================

        private int newCustomerID;
        private customer newCustomer;
        private delivery newDelivery;
        private reservation newReservation;

        private void fillInOnLoad()
        {
            if (newCustomerID == 0)
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    var userResult = (from userRec in betterDB.customers
                                      where userRec.user_ID != 1000000000
                                      orderby userRec.user_ID descending
                                      select userRec).AsNoTracking().FirstOrDefault();
                    newCustomerID = userResult.user_ID + 1;
                    //MessageBox.Show($"{newCustomerID}");
                }
            }

            if (ordOption == OrderOption.LevelDelivery)
            {
                label10.Visible = true;
                dtpDeliveryTime.Visible = true;
            }
            else if (ordOption == OrderOption.LevelDeposit)
            {
                label10.Visible = false;
                dtpDeliveryTime.Visible = false;
            }
            return;
        }
        private void btnBackOption_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tpOption;
        }

        private bool customerInfoClick()
        {
            return true;
        }

        private void createCustomer()
        {
            newCustomer = new customer();
            newCustomer.user_ID = newCustomerID;
            newCustomer.name = tbName.Text;
            newCustomer.phone_No = Int32.Parse(tbPhone.Text);
            newCustomer.email = tbEmail.Text;
            newCustomer.address = tbAddress.Text;
            newCustomer.create_date = DateTime.Now;
        }

        private List<reservation> newReserList;
        private void createReservation(customer cust, orderline line, int reserID)
        {

            reservation newReservation = new reservation();
            newReservation.reservation_ID = reserID;
            newReservation.product = line.product;
            newReservation.qty = (int)line.quantity;
            newReservation.productID = line.product_ID;
            newReservation.customerID = cust.user_ID;
            newReservation.reservation_date = DateTime.Now;
            newReserList.Add(newReservation);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (customerInfoClick())
            {
                createCustomer();
                // Create Delivery
                if (ordOption == OrderOption.LevelDelivery)
                {

                    // Generating new delivery id
                    string strYear = DateTime.Now.Year.ToString();
                    int year = Int32.Parse(strYear.Remove(0, 2));
                    int tempID = year * (int)Math.Pow(10, 5);

                    int newDeliveryID;
                    var latestDelivery = (from deliveryRec in betterDb.deliveries
                                          where deliveryRec.delivery_ID >= tempID
                                          orderby deliveryRec.delivery_ID descending
                                          select deliveryRec).AsNoTracking().FirstOrDefault();

                    if (latestDelivery == null)
                    {
                        newDeliveryID = tempID;
                    }
                    else
                    {
                        newDeliveryID = latestDelivery.delivery_ID + 1;
                    }

                    newDelivery = new delivery();
                    newDelivery.delivery_ID = newDeliveryID;
                    newDelivery.approve_time = DateTime.Now;
                    newDelivery.delivery_date = dtpDeliveryTime.Value;
                    newDelivery.status = "Approved";
                    newDelivery.type = 1;

                    // calculate order weight
                    float deliveryWeight = 0;
                    foreach (var line in shoppingCart)
                    {
                        deliveryWeight += line.product.weight;
                    }

                    newDelivery.net_weight = deliveryWeight;
                    MessageBox.Show("New Delivery created!");
                }
                // create reservation according to the orderline
                else
                {
                    newReserList = new List<reservation>();
                    // Generating new reservation id
                    string strYear = DateTime.Now.Year.ToString();
                    int year = Int32.Parse(strYear.Remove(0, 2));
                    int tempID = year * (int)Math.Pow(10, 5);

                    int newReservationID;
                    var latestReservation = (from reserRec in betterDb.reservations
                                             where reserRec.reservation_ID >= tempID
                                             orderby reserRec.reservation_ID descending
                                             select reserRec).AsNoTracking().FirstOrDefault();

                    if (latestReservation == null)
                    {
                        newReservationID = tempID;
                    }
                    else
                    {
                        newReservationID = latestReservation.reservation_ID + 1;
                    }
                    foreach (var line in shoppingCart)
                    {
                        createReservation(newCustomer, line, newReservationID++);
                    }
                }

                tabControl.SelectedTab = tpPay;
            }
        }


        // =========================================== Fill in Page Section =======================================================


        // =========================================== Payment Page Section =======================================================
        private int discount = 0;
        private float totalPrice = 0;
        private bool confirmPay;
        private void payOnLoad()
        {
            confirmPay = false;
            if (ordOption == OrderOption.LevelCUSTOMER || ordOption == OrderOption.LevelDelivery)
            {
                loadFullPayment();
            }
            else if (ordOption == OrderOption.LevelDeposit)
            {
                loadDepositPayment();
            }
            else
            {

            }
        }

        private void loadFullPayment()
        {
            panPayList.Controls.Clear();
            foreach (var line in shoppingCart)
            {
                PayControl payItemRow = new PayControl() { Dock = DockStyle.Top };
                payItemRow.nameText = line.product.name;
                payItemRow.qtyText = (line.quantity).ToString();
                payItemRow.priceText = $"$HK{line.product.price:.}";
                float total = line.product.price * (float)line.quantity;
                totalPrice += total;
                payItemRow.totalText = $"$HK{total:.}";
                panPayList.Controls.Add(payItemRow);

            }

            lblSub.Text = $"HK${totalPrice}";
            lblDiscount.Text = $"HK${discount}";
            float realTotal = totalPrice - discount;
            lblTotalPrice.Text = $"HK${realTotal:.}";
            MessageBox.Show("Full Payment Page");
        }

        private void loadDepositPayment()
        {
            panPayList.Controls.Clear();

            foreach (var reser in newReserList)
            {
                PayControl payItemRow = new PayControl() { Dock = DockStyle.Top };
                payItemRow.nameText = reser.product.name;
                payItemRow.qtyText = (reser.qty).ToString();
                double total;
                if (reser.product.price > 5000)
                {
                    payItemRow.priceText = $"20%";
                    total = reser.product.price * 0.2 * (float)reser.qty;
                }
                else
                {
                    payItemRow.priceText = $"0";
                    total = 0;
                }
                totalPrice += (float)total;
                payItemRow.totalText = $"$HK{total}";
                panPayList.Controls.Add(payItemRow);

            }

            lblSub.Text = $"HK${totalPrice}";
            lblDiscount.Text = $"HK${discount}";
            float realTotal = totalPrice - discount;
            lblTotalPrice.Text = $"HK${realTotal}";
            MessageBox.Show("Deposit Payment Page");
        }

        private void btnPpReturn_Click(object sender, EventArgs e)
        {
            TabPage page;
            if (ordOption == OrderOption.LevelCUSTOMER)
            {
                page = tpOption;
            }
            else if (ordOption == OrderOption.LevelDelivery)
            {
                page = tpFillInfo;
            }
            // deposit
            else
            {
                page = tpFillInfo;
            }

            tabControl.SelectedTab = page;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!(confirmPay))
            {
                float cash = (float)numCash.Value;
                if (cash >= totalPrice)
                {
                    confirmPay = true;
                    float change = cash - totalPrice;
                    tbChange.Text = $"${change}";
                    btnPpReturn.Hide();
                    btnConfirmPayment.Text = "Continue";
                }
                else
                {
                    MessageBox.Show("Please enter sufficient balance!!");
                }

            }
            else
            {
                createOrder();
                tabControl.SelectedTab = tpPrintReceipt;
            }
        }

        private void createOrder()
        {
            foreach (var line in shoppingCart)
            {
                line.product = null;
            }
            order.order_date = DateTime.Now;
            order.total_price = totalPrice;
            if (ordOption == OrderOption.LevelCUSTOMER)
            {
                var walkinCustomer = (from customerRec in betterDb.customers
                                      where customerRec.user_ID == 1000000000
                                      select customerRec).AsNoTracking().FirstOrDefault();
                order.customer_ID = walkinCustomer.user_ID;
                betterDb.buyorders.Add(order);
                foreach (var line in shoppingCart)
                {
                    betterDb.orderlines.Add(line);
                }

                betterDb.SaveChanges();
            }
            else if (ordOption == OrderOption.LevelDelivery)
            {
                order.customer_ID = newCustomer.user_ID;
                order.delivery_ID = newDelivery.delivery_ID;
                betterDb.customers.Add(newCustomer);
                betterDb.buyorders.Add(order);
                foreach (var line in shoppingCart)
                {
                    betterDb.orderlines.Add(line);
                }

                betterDb.deliveries.Add(newDelivery);


                betterDb.SaveChanges();
            }
            else if (ordOption == OrderOption.LevelDeposit)
            {
                MessageBox.Show("Creating deposit");
                betterDb.customers.Add(newCustomer);
                foreach (var reser in newReserList)
                {
                    reser.product = null;
                    betterDb.reservations.Add(reser);
                }

                betterDb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        // =========================================== Payment Page Section =======================================================

        // =========================================== Receipt Page Section =======================================================
        private void receiptOnLoad()
        {
        }


        private bool receiptCreated = false;
        PrintDocument pd;
        private void createReceipt()
        {
            try
            {
                pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 850, 1000);
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
                string delivery = $"Order ID: {newOrderID}";
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

                if (ordOption == OrderOption.LevelDelivery || ordOption == OrderOption.LevelCUSTOMER)
                {
                    var buyorderResult = (from orderRec in betterDB.buyorders
                                          where orderRec.order_ID == newOrderID
                                          select orderRec).AsNoTracking().FirstOrDefault();

                    ev.Graphics.DrawString("Order Date : " + buyorderResult.order_date.ToString(), bold, Brushes.Black, 20, 250, new StringFormat());
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
                    string allTotal = buyorderResult.total_price.ToString();
                    var allTotalWid = ev.Graphics.MeasureString(allTotal, normal);
                    ev.Graphics.DrawString("$" + allTotal, normal, Brushes.Black, totalX + (70 - allTotalWid.Width), 720, new StringFormat());
                }
                else if (ordOption == OrderOption.LevelDeposit)
                {
                    var reserResults = (from reserRec in betterDB.reservations
                                        where reserRec.customerID == newCustomerID
                                        select new { reserRec.product.name, reserRec.product.price, reserRec.qty });

                    //ev.Graphics.DrawString("Order Date : " + reserResults.FirstOrDefault().reservation_date.ToString(), bold, Brushes.Black, 20, 250, new StringFormat());
                    foreach (var reser in reserResults)
                    {
                        string productName = reser.name;
                        ev.Graphics.DrawString(productName, normal, Brushes.Black, productX, height, new StringFormat());

                        string price = (reser.price > 5000) ? (reser.price * 0.2).ToString() : "0";
                        string total = "$" + (reser.qty * decimal.Parse(price)).ToString();
                        price = "$" + price;
                        var priceWid = ev.Graphics.MeasureString(price, normal);
                        ev.Graphics.DrawString(price, normal, Brushes.Black, priceX + (50 - priceWid.Width), height, new StringFormat());

                        string qty = reser.qty.ToString();
                        var qtyWid = ev.Graphics.MeasureString(qty, normal);
                        ev.Graphics.DrawString(qty, normal, Brushes.Black, quantX + (30 - qtyWid.Width), height, new StringFormat());

                        var totalWid = ev.Graphics.MeasureString("$" + total, normal);
                        ev.Graphics.DrawString(total, normal, Brushes.Black, totalX + (70 - totalWid.Width), height, new StringFormat());

                        height += 20;
                    }
                }

                height = 700;
                ev.Graphics.DrawString(line, linenormal, Brushes.Black, 20, height, new StringFormat());

                height = 850;
                int tyX = 300;
                ev.Graphics.DrawString("Thank you for your payment!!", bold, Brushes.Black, tyX, height, new StringFormat());




                ev.HasMorePages = false;
            }
        }
        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            createReceipt();
            receiptCreated = true;
        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            if (!(receiptCreated))
            {
                return;
            }

            PrintPreviewDialog printdialog = new PrintPreviewDialog();
            printdialog.Document = pd;
            printdialog.ShowDialog();
        }
        // =========================================== Receipt Page Section =======================================================
    }
}
