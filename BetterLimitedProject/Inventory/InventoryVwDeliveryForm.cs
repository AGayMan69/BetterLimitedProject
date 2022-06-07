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
using MimeKit;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryVwDeliveryForm : Form
    {
        private bool loading;
        private bool haveInput;
        private int targetDelivery;
        private string targetDelType;

        public InventoryVwDeliveryForm()
        {
            InitializeComponent();
        }

        private void InventoryVwDeliveryForm_Load(object sender, EventArgs e)
        {
            loading = true;
            cboOrderDate.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            cboSortOrder.SelectedIndex = 0;
            loading = false;
            loadDelivery();
        }


        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDelivery();
            tbSearch.Clear();
        }

        private void cboOrderDate_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDelivery();
            tbSearch.Clear();
        }

        private void cboSortOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDelivery();
            tbSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadDelivery();
            tbSearch.Clear();
        }

        private void loadDelivery()
        {
            if (loading)
            {
                return;
            }
            // check textbox have text
            if (tbSearch.Text == "")
            {
                haveInput = false;
            }
            else
            {
                try
                {
                    targetDelivery = Int32.Parse(tbSearch.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter delivery to search!!");
                }
                haveInput = true;
            }

            // getting delType
            if (cboType.SelectedIndex == 0)
            {
                targetDelType = "";
            }
            else
            {
                targetDelType = cboType.SelectedItem.ToString();
            }

            // getting time range
            DateTime upperBound;
            DateTime lowerBound;

            if (cboOrderDate.SelectedItem.ToString() == "Today")
            {
                lowerBound = DateTime.Today;
                upperBound = DateTime.Today.GetTodayUpperBound();
            }
            else if (cboOrderDate.SelectedItem.ToString() == "This Week")
            {
                lowerBound = DateTime.Now.GetThisWeekLowerBound();
                upperBound = DateTime.Now.GetThisWeekUpperBound();
            }
            else if (cboOrderDate.SelectedItem.ToString() == "This Month")
            {
                lowerBound = DateTime.Now.GetThisMonthLowerBound();
                upperBound = DateTime.Now.GetThisMonthUpperBound();
            }
            else
            {
                lowerBound = DateTime.Now.GetThisYearLowerBound();
                upperBound = DateTime.Now.GetThisYearUpperBound();
            }

            //MessageBox.Show($"UpperBound {upperBound}");
            //MessageBox.Show($"LowerBound {lowerBound}");
            panDeliveryLoader.Controls.Clear();
            using (var betterDB = new betterlimitedEntities())
            {
                IQueryable<InventoryDeliveryControl> deliveryControls;
                if (haveInput)
                {
                    deliveryControls = (from delRec in betterDB.deliveries
                                        where delRec.delivery_ID == targetDelivery
                                            && delRec.delivery_type.deliveryTypeName.Contains(targetDelType)
                                            && (delRec.creation_time >= lowerBound && delRec.creation_time <= upperBound)
                                        select new InventoryDeliveryControl()
                                        {
                                            deliveryID = delRec.delivery_ID,
                                            status = delRec.status,
                                            delType = delRec.delivery_type.deliveryTypeName,
                                            creaTime = (DateTime)delRec.creation_time,
                                            approvTime = (DateTime)delRec.approve_time,
                                            deliveryTime = (DateTime)delRec.delivery_date
                                        }).AsNoTracking();
                }
                else
                {
                    deliveryControls = (from delRec in betterDB.deliveries
                                        where delRec.delivery_type.deliveryTypeName.Contains(targetDelType)
                                        && (delRec.creation_time >= lowerBound && delRec.creation_time <= upperBound)
                                        select new InventoryDeliveryControl()
                                        {
                                            deliveryID = delRec.delivery_ID,
                                            status = delRec.status,
                                            delType = delRec.delivery_type.deliveryTypeName,
                                            creaTime = (DateTime)delRec.creation_time,
                                            approvTime = delRec.approve_time,
                                            deliveryTime = delRec.delivery_date
                                        }).AsNoTracking();
                }

                // sorting

                if (cboSortOrder.SelectedItem.ToString() == "Creation Date")
                {
                    deliveryControls = deliveryControls.OrderBy(control => control.creaTime);
                }
                else if (cboSortOrder.SelectedItem.ToString() == "Status")
                {
                    deliveryControls = deliveryControls.OrderBy(control => control.status);
                }
                else if (cboSortOrder.SelectedItem.ToString() == "Delivery ID")
                {
                    deliveryControls = deliveryControls.OrderBy(control => control.deliveryID);
                }

                foreach (var delcontrol in deliveryControls)
                {
                    delcontrol.Dock = DockStyle.Top;
                    delcontrol._parent = this;
                    panDeliveryLoader.Controls.Add(delcontrol);
                }
            }
        }

        internal DateTime deliveryTime;
        internal void editDelivery(int deliveryID, string type)
        {
            DialogResult editresult;
            MessageBox.Show($"Editing {type} delivery {deliveryID}");
            if (type == "Customer")
            {
                InventoryArrangeCustomerDelForm custFrm = new InventoryArrangeCustomerDelForm();
                custFrm.deliveryID = deliveryID;
                custFrm._parent = this;
                editresult = custFrm.ShowDialog();
            }
            else if (type == "Replenish")
            {
                InventoryArrangeReplenishForm replFrm = new InventoryArrangeReplenishForm();
                using (var betterDB = new betterlimitedEntities())
                {
                    var replResult = (from replRec in betterDB.deliveries
                                      where replRec.delivery_ID == deliveryID
                                      select replRec.delivery_date).FirstOrDefault();
                    deliveryTime = (DateTime)replResult;
                    replFrm.deliveryID = deliveryID;
                    replFrm._parent = this;
                }

                editresult = replFrm.ShowDialog();
            }
            else
            {
                editresult = DialogResult.Cancel;
            }
            if (editresult == DialogResult.OK)
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    // update the record
                    var deliveryResult = (from delRec in betterDB.deliveries
                                          where delRec.delivery_ID == deliveryID
                                          select delRec).FirstOrDefault();
                    deliveryResult.delivery_date = deliveryTime;
                    betterDB.SaveChanges();
                    loadDelivery();
                }
            }
        }

        internal void delDelivery(int deliveryID, string type)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                MessageBox.Show($"Deleting {type} delivery {deliveryID}");
                var deliveryResult = (from deliveryRec in betterDB.deliveries
                                      where deliveryRec.delivery_ID == deliveryID
                                      select deliveryRec).FirstOrDefault();
                betterDB.deliveries.Remove(deliveryResult);
                betterDB.SaveChanges();
            }
            loadDelivery();
        }

        internal void arrDelivery(int deliveryID, string type)
        {
            MessageBox.Show($"Arranging {type} delivery {deliveryID}");
            DialogResult editresult;
            deliveryTime = DateTime.Now.AddDays(5);
            if (type == "Replenish")
            {
                InventoryArrangeReplenishForm replFrm = new InventoryArrangeReplenishForm();
                replFrm._parent = this;
                replFrm.deliveryID = deliveryID;
                editresult = replFrm.ShowDialog();
            }
            else
            {
                InventoryArrangeDefectDelForm defectFrm = new InventoryArrangeDefectDelForm();
                editresult = defectFrm.ShowDialog();
            }

            if (editresult == DialogResult.OK)
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    var delResult = (from delRec in betterDB.deliveries
                                     where delRec.delivery_ID == deliveryID
                                     select delRec).FirstOrDefault();
                    delResult.status = "Approved";
                    delResult.approve_time = DateTime.Now;
                    delResult.delivery_date = deliveryTime;
                    betterDB.SaveChanges();
                }
                loadDelivery();
            }
        }

    }
}
