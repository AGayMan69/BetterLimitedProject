using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Technical
{
    public partial class InstallationDutyControl : UserControl
    {
        internal int installationID;
        internal int? installationType;
        internal int? assignmentID;
        internal DateTime? installTime;

        internal InstallationDutyMorningForm _parentMorning;
        internal InstallationDutyAfternoonForm _parentAfternoon;
        internal InstallationDutyEveningForm _parentEvening;

        public InstallationDutyControl()
        {
            InitializeComponent();
        }

        private void InstallationDutyControl_Load(object sender, EventArgs e)
        {
            lblInstallation.Text = installationID.ToString();
            btnAssign.Visible = false;
            lblAss.Visible = false;
            lblUnAss.Visible = false;

            if (assignmentID == null)
            {
                btnAssign.Visible = true;
                lblUnAss.Visible = true;
            }
            else
            {
                lblAss.Visible = true;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            InstallationAssignWorkerForm assForm = new InstallationAssignWorkerForm();
            assForm.installationID = installationID;
            var dialogueResult = assForm.ShowDialog();
            if (dialogueResult == DialogResult.OK)
            {
                if (_parentMorning != null)
                {
                    _parentMorning._parent.loadDuty();
                } 
                else if (_parentAfternoon != null)
                {
                    _parentAfternoon._parent.loadDuty();
                } 
                else if (_parentEvening != null)
                {
                    _parentEvening._parent.loadDuty();
                }
            }
        }
    }
}
