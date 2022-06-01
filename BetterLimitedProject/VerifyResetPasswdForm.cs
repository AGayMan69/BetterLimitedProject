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
    public partial class VerifyResetPasswdForm : Form
    {
        public VerifyResetPasswdForm()
        {
            InitializeComponent();
        }

        private bool verifyCode()
        {
            string targetCode = tbVerification.Text;
            using (var betterDB = new betterlimitedEntities())
            {
                var userResult = (from request in betterDB.resetpassword_request
                                 join userRow in betterDB.staffs
                                     on request.staff_ID equals userRow.staff_ID
                                 where request.request_code.Equals(targetCode)
                                 select userRow).FirstOrDefault();
                if (userResult == null)
                {
                    return false;
                }

                ResetPasswdForm resetPasswdForm = new ResetPasswdForm();
                resetPasswdForm.targetStaff = userResult;
                this.Hide();
                resetPasswdForm.ShowDialog();
                this.DialogResult = DialogResult.OK;

            }
            return true;
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (!verifyCode())
            {
                MessageBox.Show("Invalid verification code.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
