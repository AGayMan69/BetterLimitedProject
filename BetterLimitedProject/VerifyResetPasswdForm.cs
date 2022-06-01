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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswdForm resetPasswdForm = new ResetPasswdForm();
            resetPasswdForm.ShowDialog();
        }
    }
}
