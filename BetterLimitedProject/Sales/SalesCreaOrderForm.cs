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
            int year = Int32.Parse(strYear.Remove(0, 2)) * Convert.ToInt32(Math.Pow(10, 5));

            int latestOrderID = (from buyorderRec in betterDb.buyorders
                                 where buyorderRec.order_ID > year
                                 orderby buyorderRec.order_ID descending
                                 select buyorderRec.order_ID).FirstOrDefault();

            if (latestOrderID == 0)
            {
                latestOrderID = year;
            }
            else
            {
                latestOrderID++;
            }
            order = new buyorder();
            order.order_ID = latestOrderID;
            dtpDeliveryTime.MinDate = DateTime.Now.AddDays(15);

            UpdatePrice();
            categorySearch = "";
            nameSearch = "";
            loadProduct();
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
            } else if (tabControl.SelectedTab == tpPrintReceipt)
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
            foreach (var product in productList.ToList())
            {
                POSProductControl productControl = new POSProductControl(this);

                productControl.productID = product.product_ID;
                productControl.productName = product.name;
                productControl.ImageBytes = product.product_image;
                flpanProduct.Controls.Add(productControl);
            }
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

                orderln.buyorder = order;
                orderln.product = addedProduct;
                orderln.product_ID = addedProduct.product_ID;
                orderln.order_ID = order.order_ID;
                orderln.quantity = 1;
                shoppingCart.Add(orderln);
                POSOrderLineControl orderLineControl = new POSOrderLineControl(this) { Dock = DockStyle.Top };
                orderLineControl.line = orderln;
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
            var cat = from catRec in betterDb.categories
                select catRec.category_name;
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
        private void fillInOnLoad()
        {
            if (newCustomerID == 0)
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    var userResult = (from userRec in betterDB.customers
                        where userRec.user_ID != 1000000000
                        orderby userRec.user_ID descending
                        select userRec.user_ID).FirstOrDefault();
                    newCustomerID = ++userResult;
                    MessageBox.Show($"{newCustomerID}");
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (customerInfoClick())
            {
                createCustomer();
                tabControl.SelectedTab = tpPay;
                newDelivery = new delivery();
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
        }


        // =========================================== Fill in Page Section =======================================================


        // =========================================== Payment Page Section =======================================================
        private void payOnLoad()
        {
            if (ordOption == OrderOption.LevelCUSTOMER || ordOption == OrderOption.LevelDelivery)
            {
                loadFullPayment();
            }
            else
            {
                loadDepositPayment();
            }
        }

        private void loadFullPayment()
        {
            MessageBox.Show("Full Payment Page");
        }

        private void loadDepositPayment()
        {
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
            createOrder();
            tabControl.SelectedTab = tpPrintReceipt;
        }

        private void createOrder()
        {
            if (ordOption == OrderOption.LevelCUSTOMER)
            {
                MessageBox.Show("Creating walkin order");
            } else if (ordOption == OrderOption.LevelDelivery)
            {
                MessageBox.Show("Creating delivery order");
            }
            else if (ordOption == OrderOption.LevelDeposit)
            {
                MessageBox.Show("Creating deposit");
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
            createReceipt();
        }

        private void createReceipt()
        {
            MessageBox.Show("Create Receipt");
            if (ordOption == OrderOption.LevelDelivery)
            {
                
            } 
        }
        // =========================================== Receipt Page Section =======================================================
    }
}
