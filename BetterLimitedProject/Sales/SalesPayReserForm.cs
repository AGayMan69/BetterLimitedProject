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
    public partial class SalesPayReserForm : Form
    {
        private bool loading;
        private bool haveInput;
        private string targetCustomer;
        public SalesPayReserForm()
        {
            InitializeComponent();
        }

        private void SalesPayReserForm_Load(object sender, EventArgs e)
        {

            loading = true;
            cboOrderDate.SelectedIndex = 0;
            loading = false;
            loadReservation();
        }

        private void loadReservation()
        {
            if (loading)
            {
               return; 
            }
            else
            {
               pnlReservationLoad.Controls.Clear(); 
                if (tbSearch.Text == "")
                {
                    haveInput = false;
                }
                else
                {
                    haveInput = true;
                    targetCustomer  = tbSearch.Text.ToUpper();
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

                IQueryable<SalesReservationControl> reservationControls;
                using (var betterDB = new betterlimitedEntities())
                {
                    if (haveInput)
                    {

                        reservationControls = (from reservationRec in betterDB.reservations
                                       where reservationRec.customer.name.ToUpper().Contains(targetCustomer)
                                            && reservationRec.reservation_date >= lowerBound && reservationRec.reservation_date <= upperBound
                                            && reservationRec.complete_date == null
                                       select new SalesReservationControl()
                                       {
                                            id = reservationRec.reservation_ID,
                                            customerName = reservationRec.customer.name,
                                            reservatoinDate = reservationRec.reservation_date
                                       }).AsNoTracking();
                    }
                    else
                    {
                        reservationControls = (from reservationRec in betterDB.reservations
                                               where reservationRec.reservation_date >= lowerBound && reservationRec.reservation_date <= upperBound
                                               && reservationRec.complete_date == null
                                       select new SalesReservationControl()
                                       {
                                            id = reservationRec.reservation_ID,
                                            customerName = reservationRec.customer.name,
                                            reservatoinDate = reservationRec.reservation_date
                                       }).AsNoTracking();
                    }
                    pnlReservationLoad.Hide();
                    foreach (var control in reservationControls)
                    {
                        control.Dock = DockStyle.Top;
                        control._parent = this;
                        pnlReservationLoad.Controls.Add(control);
                    }
                    pnlReservationLoad.Show();
                }
            }
        }

        internal void DeleteReservation(int id)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var reservationResult = (from reserRec in betterDB.reservations
                    where reserRec.reservation_ID == id
                    select reserRec).FirstOrDefault();
                betterDB.reservations.Remove(reservationResult);
                betterDB.SaveChanges();
                loadReservation();
            }
        }

        internal void PayReservation(int id)
        {
            SalesReservationConfirmForm confirmFrm = new SalesReservationConfirmForm();
            confirmFrm.reservationID = id;

            var dialogResult = confirmFrm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadReservation();
            }
        }

        private void cboOrderDate_SelectedValueChanged(object sender, EventArgs e)
        {
            loadReservation();
            tbSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadReservation();
            tbSearch.Clear();
        }
    }
}
