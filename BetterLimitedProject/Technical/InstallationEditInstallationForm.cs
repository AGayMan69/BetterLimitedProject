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
using FluentValidation;

namespace BetterLimitedProject.Technical
{
    public partial class InstallationEditInstallationForm : Form
    {
        internal int id;
        public InstallationEditInstallationForm()
        {
            InitializeComponent();
        }

        private void InstallationEditInstallationForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var installationResult = (from installRec in betterDB.installations
                    where installRec.installation_ID == id
                    select installRec).AsNoTracking().FirstOrDefault();
                lblInstallationID.Text = $"Installation#{installationResult.installation_ID}";
                lblDeliveryID.Text = $"Delivery#{installationResult.delivery_ID}";
                cboInstallType.SelectedIndex = 0;
                lblDeliveryTime.Text = installationResult.delivery.delivery_date.ToString();
                dtpInstallationTime.MinDate = ((DateTime)installationResult.delivery.delivery_date).AddHours(2);
                if (installationResult.installation_date != null)
                {
                    dtpInstallationTime.Value = (DateTime) installationResult.installation_date;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var installationResult = (from installRec in betterDB.installations
                    where installRec.installation_ID == id
                    select installRec).FirstOrDefault();
                installationResult.installation_date = dtpInstallationTime.Value;
                installationResult.installation_type = cboInstallType.SelectedIndex;
                betterDB.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
