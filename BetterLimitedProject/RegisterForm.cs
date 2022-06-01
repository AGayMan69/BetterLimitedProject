using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BetterLimitedProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;
            dtpHireDate.MaxDate = DateTime.Today;
            using (var betterDb = new betterlimitedEntities())
            {
                var departments = (from list in betterDb.departments
                                   select list.department_name);
                foreach (var department in departments.ToList())
                {
                    cboDepartment.Items.Add(department);
                }
            }

            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.login_icon, new Size(16,16));

        }

        private void cboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboDepartment.SelectedItem.ToString());
            string targetDepartment = cboDepartment.SelectedItem.ToString();
            // generating position according to the 
            using (var betterDb = new betterlimitedEntities())
            {
                var positions = (from position in betterDb.positions
                    join department in betterDb.departments
                        on position.department_ID equals department.department_ID
                    where department.department_name.Equals(targetDepartment)
                                 select position.position_title);
                foreach (var position in positions.ToList())
                {
                    cboPosition.Items.Add(position);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Name";
            if (string.IsNullOrEmpty(tbName.Text))
            {
                lblErrName.Visible = true;
                lblErrName.Text = e1;
            }
            else
            {
                lblErrName.Visible = false;
                lblErrName.Text = "";
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {

        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Username";
            string e2 = "*Invalid Username";
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                lblErrUsername.Visible = true;
                lblErrUsername.Text = e1;
            }
            else
            {
                lblErrUsername.Visible = false;
                lblErrUsername.Text = "";
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Password";
            if(string.IsNullOrEmpty(tbPassword.Text))
            {
                lblErrPW.Visible = true;
                lblErrPW.Text = e1;
            }
            else
            {
                lblErrPW.Visible = false;
                lblErrPW.Text = "";
            }
        }

        private void tbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Confirm Your Password";
            string e2 = "Your Confirm Password is incorrect";
            string pw = tbPassword.Text;
            string cpw = tbPasswordConfirm.Text;
            if(string.IsNullOrEmpty(tbPasswordConfirm.Text))
            {
                lblErrCPW.Visible = true;
                lblErrCPW.Text = e1;
            }
            else if(cpw!=pw)
            {
                lblErrCPW.Visible = true;
                lblErrCPW.Text = e2;
            }
            else
            {
                lblErrCPW.Visible = false;
                lblErrCPW.Text = "";
            }
            
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Email Address";
            string e2 = "*Invalid Email Address";
            // string pattern = "/.+[@].+[.].+/";
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = e1;
            }
            //if(Regex.IsMatch(tbEmail.Text, pattern))
           // {
           //     lblErrEmail.Visible = false;
           //     lblErrEmail.Text = "";
           // }
            else
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = e2;
            }
        }
    }
}
