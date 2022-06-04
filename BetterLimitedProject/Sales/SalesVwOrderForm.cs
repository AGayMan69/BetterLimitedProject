using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Data.Entity;
using System.Data.Objects.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Sales
{
    public partial class SalesVwOrderForm : Form
    {
        private bool loading;
        private bool haveInput;
        private int targetID;
        public SalesVwOrderForm()
        {
            InitializeComponent();
        }

        private void SalesVwOrderForm_Load(object sender, EventArgs e)
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
                MessageBox.Show("Loading Product...");
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
                else
                {
                    upperBound = DateTime.Now.GetThisYearUpperBound();
                    lowerBound = DateTime.Now.GetThisYearLowerBound();
                }

                MessageBox.Show($"Lower Bound {lowerBound.ToString("yyyy-MM-dd HH:mm:ss")}");
                MessageBox.Show($"Upper Bound {upperBound.ToString("yyyy-MM-dd HH:mm:ss")}");

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
                else if(cboType.SelectedItem == "Delivery")
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
                                            && ( orderRec.customer_ID == targetID
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

                        SalesOrderControl orderControl = new SalesOrderControl() { Dock = DockStyle.Top };
                        orderControl.order = order;
                        orderControl._parent = this;
                        panSalesLoad.Controls.Add(orderControl);
                    }
                }
            }
        }

        internal void DeleteOrder(int orderID)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var targetOrder = (from orderRec in betterDB.buyorders
                                  where orderRec.order_ID == orderID
                                  select orderRec).FirstOrDefault();
                var delConfirm = MessageBox.Show("Are you sure to delete this record?", 
                    $"Deleting Order: {targetOrder.order_ID}",
                    MessageBoxButtons.YesNo);
                if (delConfirm == DialogResult.Yes)
                {
                    betterDB.buyorders.Remove(targetOrder);
                    betterDB.SaveChanges();
                    loadOrder();
                }
            }
        }

        internal void EditOrder(int orderID)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var targetOrder = (from orderRec in betterDB.buyorders
                                  where orderRec.order_ID == orderID
                                  select orderRec).FirstOrDefault();
            }
        }
    }
}
