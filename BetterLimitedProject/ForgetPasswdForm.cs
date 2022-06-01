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
    public partial class ForgetPasswdForm : Form
    {
        public ForgetPasswdForm()
        {
            InitializeComponent();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ResetPasswdForm resetPasswdForm = new ResetPasswdForm();
            this.Hide();
            DialogResult reset = resetPasswdForm.ShowDialog();
            if (reset == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
