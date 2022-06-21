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
    public partial class InstallationDutyAfternoonForm : Form
    {
        internal TechnicalArraInstallationForm _parent;
        internal DateTime targetDate;
        internal DateTime targetDateUpper;
        private List<Panel> dutyPanels;

        public InstallationDutyAfternoonForm()
        {
            InitializeComponent();
        }

        private void InstallationDutyAfternoonForm_Load(object sender, EventArgs e)
        {

            dutyPanels = new List<Panel>();
            dutyPanels.Add(panDuty13);
            dutyPanels.Add(panDuty14);
            dutyPanels.Add(panDuty15);
            dutyPanels.Add(panDuty16);

            foreach (var panel in dutyPanels)
            {
                panel.Controls.Clear();
            }
            targetDate = targetDate.AddHours(13);
            targetDateUpper = targetDate.AddHours(4);
            using (var betterDB = new betterlimitedEntities())
            {
                var dutyControls = (from installRec in betterDB.installations
                    where installRec.installation_date >= targetDate
                          && installRec.installation_date <= targetDateUpper
                    select new InstallationDutyControl()
                    {
                        installationID = installRec.installation_ID,
                        installationType = installRec.installation_type,
                        installTime = installRec.installation_date,
                        assignmentID = installRec.assignment_ID
                    });
                targetDate = targetDate.AddHours(-1);
                foreach (var panel in dutyPanels)
                {
                    targetDate = targetDate.AddHours(1);
                    targetDateUpper = targetDate.AddHours(1).AddTicks(-1);
                    var newControls = dutyControls.Where(control =>
                        control.installTime >= targetDate && control.installTime <= targetDateUpper);

                    foreach (var control in newControls)
                    {
                        control.Dock = DockStyle.Top;
                        control._parentAfternoon = this;
                        panel.Controls.Add(control);
                    }
                }
            }
        }
    }
}
