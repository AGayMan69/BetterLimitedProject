using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject
{
    public partial class ResetPasswdForm : Form
    {
        public staff targetStaff { get; set; }

        public ResetPasswdForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            string passwordConf = tbPasswordConf.Text;
            if (password == "" || passwordConf == "")
            {
                MessageBox.Show("Password can not be empty");
                return;
            }

            if (passwordConf != password)
            {
                MessageBox.Show("Passwords not the same");
                return;
            }

            try
            {
                using (var betterDB = new betterlimitedEntities())
                {
                    var user = (from row in betterDB.staffs
                                where targetStaff.staff_ID.Equals(row.staff_ID)
                                select row).FirstOrDefault();
                    user.password = password;
                    betterDB.SaveChanges();
                }

                MessageBox.Show("Password Updated.");
            }
            catch
            {
                MessageBox.Show("Failed to save password");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void ResetPasswdForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"name: {targetStaff.name}");
            MessageBox.Show($"username: {targetStaff.username}");
        }
    }
}
