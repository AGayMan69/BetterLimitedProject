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

namespace BetterLimitedProject.Technical
{
    public partial class InstallationAssignWorkerForm : Form
    {
        internal int installationID;

        public InstallationAssignWorkerForm()
        {
            InitializeComponent();
        }

        private void InstallationAssignWorkerForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var workerResult = (from workRec in betterDB.workers
                    where workRec.type == "Installation"
                    select workRec).AsNoTracking();
                foreach (var worker in workerResult)
                {
                    cboWorker.Items.Add($"{worker.worker_ID} {worker.name}");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int newAssignID;
            using (var betterDB = new betterlimitedEntities())
            {
                
                // Generating new assignment id
                string strYear = DateTime.Now.Year.ToString();
                int year = Int32.Parse(strYear.Remove(0, 2));
                int tempID = year * (int)Math.Pow(10, 5);

                var latestAssign = (from assignRec in betterDB.installation_assignment
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
                installation_assignment insass = new installation_assignment();
                insass.assignment_ID = newAssignID;
                insass.installation_ID = installationID;
                insass.worker_ID = Int32.Parse(workerID);
                betterDB.installation_assignment.Add(insass);
                betterDB.SaveChanges();
                var installationResult = (from installationRec in betterDB.installations
                    where installationRec.installation_ID == installationID
                    select installationRec).FirstOrDefault();
                installationResult.assignment_ID = newAssignID;
                betterDB.SaveChanges();
            }
        }
    }
}
