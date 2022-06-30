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
using BetterLimitedProject.Sales;

namespace BetterLimitedProject.Accounting
{
    public partial class AccountingVwOrderForm : Form
    {
        private bool loading;
        private bool haveInput;
        private int targetID;

        public AccountingVwOrderForm()
        {
            InitializeComponent();
        }

        private void AccountingVwOrderForm_Load(object sender, EventArgs e)
        {
            loading = true;
            cboOrderDate.SelectedIndex = 0;
            cboSortOrder.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            loading = false;
            loadOrder();
        }
        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            loadOrder();
            tbSearch.Clear();
        }

        private void cboOrderDate_SelectedValueChanged(object sender, EventArgs e)
        {
            loadOrder();
            tbSearch.Clear();
        }

        private void cboSortOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            loadOrder();
            tbSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadOrder();
            tbSearch.Clear();
        }

        private void loadOrder()
        {
            if (loading)
            {
                return;
            }
            else
            {
                panSalesLoad.Controls.Clear();
                // get search input
                if (tbSearch.Text == "")
                {
                    haveInput = false;
                }
                else
                {
                    haveInput = true;
                    try
                    {
                        targetID = Int32.Parse(tbSearch.Text);

                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Please enter customer ID to search!!");
                        tbSearch.Clear();
                        haveInput = false;
                    }

                }
                // get date parameter
                DateTime upperBound;
                DateTime lowerBound;
                if (cboOrderDate.SelectedItem == "Today")
                {
                    lowerBound = DateTime.Today;
                    upperBound = DateTime.Today.GetTodayUpperBound();
                }
                else if (cboOrderDate.SelectedItem == "This Week")
                {
                    upperBound = DateTime.Now.GetThisWeekUpperBound();
                    lowerBound = DateTime.Now.GetThisWeekLowerBound();
                }
                else if (cboOrderDate.SelectedItem == "This Month")
                {
                    upperBound = DateTime.Now.GetThisMonthUpperBound();
                    lowerBound = DateTime.Now.GetThisMonthLowerBound();
                }
                else
                {
                    upperBound = DateTime.Now.GetThisYearUpperBound();
                    lowerBound = DateTime.Now.GetThisYearLowerBound();
                }

                //MessageBox.Show($"Lower Bound {lowerBound.ToString("yyyy-MM-dd HH:mm:ss")}");
                //MessageBox.Show($"Upper Bound {upperBound.ToString("yyyy-MM-dd HH:mm:ss")}");

                // get customer type
                int walkINCustomerID = 1000000000;
                int searchCustomerUpperBound;
                int searchCustomerLowerBound;
                if (cboType.SelectedItem == "Walkin")
                {
                    //MessageBox.Show("Searching Walkin Order");
                    searchCustomerLowerBound = walkINCustomerID;
                    searchCustomerUpperBound = walkINCustomerID;
                    tbSearch.Enabled = false;
                }
                else if (cboType.SelectedItem == "Delivery")
                {
                    //MessageBox.Show("Searching Delivery Order");
                    searchCustomerLowerBound = 0;
                    searchCustomerUpperBound = walkINCustomerID - 1;
                    tbSearch.Enabled = true;
                }
                else
                {
                    //MessageBox.Show("Searching All Order");
                    searchCustomerLowerBound = 0;
                    searchCustomerUpperBound = walkINCustomerID;
                    tbSearch.Enabled = true;
                }
                using (var betterDB = new betterlimitedEntities())
                {
                    IQueryable<buyorder> orderResult;

                    // search according to the input
                    if (haveInput)
                    {

                        orderResult = (from orderRec in betterDB.buyorders
                                       where
                                            orderRec.customer_ID >= searchCustomerLowerBound
                                            && orderRec.customer_ID <= searchCustomerUpperBound
                                            && (orderRec.customer_ID == targetID
                                            || orderRec.order_ID == targetID)
                                            && orderRec.order_date >= lowerBound && orderRec.order_date <= upperBound
                                       select orderRec).AsNoTracking();
                    }
                    else
                    {
                        orderResult = (from orderRec in betterDB.buyorders
                                       where
                                            orderRec.customer_ID >= searchCustomerLowerBound
                                            && orderRec.customer_ID <= searchCustomerUpperBound
                                             && orderRec.order_date >= lowerBound && orderRec.order_date <= upperBound
                                       select orderRec).AsNoTracking();
                    }

                    //MessageBox.Show($"Number of sales: {orderResult.Count()}");

                    // sorting
                    if (cboSortOrder.SelectedItem == "Date")
                    {
                        orderResult = orderResult.OrderBy(order => order.order_date);
                    }
                    else if (cboSortOrder.SelectedItem == "Price")
                    {
                        orderResult = orderResult.OrderBy(order => order.total_price);
                    }
                    else if (cboSortOrder.SelectedItem == "Order ID")
                    {
                        orderResult = orderResult.OrderBy(order => order.order_ID);
                    }
                    else if (cboSortOrder.SelectedItem == "Customer ID")
                    {
                        orderResult = orderResult.OrderBy(order => order.customer_ID);
                    }

                    foreach (var order in orderResult)
                    {

                        AccountingOrderControl orderControl = new AccountingOrderControl() { Dock = DockStyle.Top };
                        orderControl.order = order;
                        orderControl._parent = this;
                        panSalesLoad.Controls.Add(orderControl);
                    }
                }
            }
        }
        internal void viewOrder(int orderID)
        {
            SalesEditOrderForm editform = new SalesEditOrderForm();
            editform.orderID = orderID;
            editform.read = true;

            var dialogResult = editform.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadOrder();
            }
        }


    }
}
