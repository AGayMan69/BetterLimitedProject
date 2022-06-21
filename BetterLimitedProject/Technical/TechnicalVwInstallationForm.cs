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
    public partial class TechnicalVwInstallationForm : Form
    {
        public TechnicalVwInstallationForm()
        {
            InitializeComponent();
        }

        private void TechnicalVwInstallationForm_Load(object sender, EventArgs e)
        {
           loadInstallation(); 
        }

        private void loadInstallation()
        {
            pnlInstallationLoader.Controls.Clear();
            using (var betterDB = new betterlimitedEntities())
            {
                var installResult = (from installRec in betterDB.installations
                    select new InstallationRowControl()
                    {
                        id = installRec.installation_ID
                    }).AsNoTracking();
                pnlInstallationLoader.Hide();
                foreach (var installRowControl in installResult)
                {
                    installRowControl._parent = this;
                    installRowControl.Dock = DockStyle.Top;
                   pnlInstallationLoader.Controls.Add(installRowControl); 
                }
                pnlInstallationLoader.Show();
            }
        }

        internal void editInstallation(int id)
        {
            InstallationEditInstallationForm editForm = new InstallationEditInstallationForm();
            editForm.id = id;
            var dialogueResult = editForm.ShowDialog();
            if (dialogueResult == DialogResult.OK)
            {
                loadInstallation();
            }
        }
    }
}
