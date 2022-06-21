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
    public partial class InstallationRowControl : UserControl
    {
        internal TechnicalVwInstallationForm _parent;
        internal int id;

        public InstallationRowControl()
        {
            InitializeComponent();
        }

        private void InstallationRowControl_Load(object sender, EventArgs e)
        {
            lblAssigned.Visible = false;
            lblPending.Visible = false;
            btnArrange.Visible = false;
            btnEdit.Visible = false;

            using (var betterDB = new betterlimitedEntities())
            {
                var installResult = (from installRec in betterDB.installations
                                    where installRec.installation_ID == id
                                    select installRec).AsNoTracking().FirstOrDefault();
                if (installResult.installation_date == null)
                {
                    lblPending.Visible = true;
                    btnArrange.Visible = true;
                }
                else
                {
                    lblAssigned.Visible = true;
                    btnEdit.Visible = true;
                }

                lblInstallationDate.Text = "";
                if (installResult.installation_date != null)
                {
                    lblInstallationDate.Text = installResult.installation_date.ToString();
                }

                lblInstallationID.Text = id.ToString();
                lblDeliveryID.Text = installResult.delivery_ID.ToString();
                lblOrderID.Text = installResult.order_ID.ToString();
            }
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            _parent.editInstallation(id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.editInstallation(id);
        }
    }
}
