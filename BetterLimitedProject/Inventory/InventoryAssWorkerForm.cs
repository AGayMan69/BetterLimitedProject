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

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryAssWorkerForm : Form
    {
        internal int deliveryID;
        public InventoryAssWorkerForm()
        {
            InitializeComponent();
        }

        private void InventoryAssWorkerForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var workerResult = (from workerRec in betterDB.workers
                                    where workerRec.type == "Delivery"
                                    select workerRec).AsNoTracking();
                foreach (var worker in workerResult)
                {
                    cboWorker.Items.Add($"{worker.worker_ID} {worker.name}");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // create assign request
            int newAssignID;
            using (var betterDB = new betterlimitedEntities())
            {

                // Generating new buy order id
                string strYear = DateTime.Now.Year.ToString();
                int year = Int32.Parse(strYear.Remove(0, 2));
                int tempID = year * (int)Math.Pow(10, 5);

                var latestAssign = (from assignRec in betterDB.delivery_assignment
                                   where assignRec.assignment_ID >= tempID
                                   orderby assignRec.assignment_ID descending
                                   select assignRec).AsNoTracking().FirstOrDefault();

                if (latestAssign == null)
                {
                    newAssignID = tempID;
                }
                else
                {
                    newAssignID = latestAssign.assignment_ID + 1;
                }

                string workerID = cboWorker.SelectedItem.ToString().Split().FirstOrDefault();
                delivery_assignment delass = new delivery_assignment();
                delass.assignment_ID = newAssignID;
                delass.delivery_ID = deliveryID;
                delass.worker_ID = Int32.Parse(workerID);
                var deliveryResult = (from delRec in betterDB.deliveries
                    where delRec.delivery_ID == deliveryID
                    select delRec).FirstOrDefault();
                deliveryResult.assignment_ID = newAssignID;
                betterDB.delivery_assignment.Add(delass);
                betterDB.SaveChanges();
            }

        }
    }
}
