﻿using System;
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
    public partial class InstallationDutyEveningForm : Form
    {
        internal TechnicalArraInstallationForm _parent;
        internal DateTime targetDate;
        internal DateTime targetDateUpper;
        private List<Panel> dutyPanels;

        public InstallationDutyEveningForm()
        {
            InitializeComponent();
        }

        private void InstallationDutyEveningForm_Load(object sender, EventArgs e)
        {
            dutyPanels = new List<Panel>();
            dutyPanels.Add(panDuty18);
            dutyPanels.Add(panDuty19);
            dutyPanels.Add(panDuty20);
            dutyPanels.Add(panDuty21);

            foreach (var panel in dutyPanels)
            {
                panel.Controls.Clear();
            }
            targetDate = targetDate.AddHours(18);
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
                        control._parentEvening = this;
                        panel.Controls.Add(control);
                    }
                }
            }
        }
    }
}
