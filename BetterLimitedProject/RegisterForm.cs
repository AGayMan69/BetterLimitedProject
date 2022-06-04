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
        private bool name, username, password, cfpassword, email, phone;
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
                name = true;
                
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {

        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Username";
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                lblErrUsername.Visible = true;
                lblErrUsername.Text = e1;
            }
            else
            {
                lblErrUsername.Visible = false;
                lblErrUsername.Text = "";
                username = true;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Password";
            string e2 = "Accept numbers and letters between 8-20";
            string pattern = "^[0-9a-zA-Z].{7,20}$";
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                lblErrPW.Visible = true;
                lblErrPW.Text = e1;
            }
            else if(Regex.IsMatch(tbPassword.Text,pattern))
            {
                lblErrPW.Visible = false;
                lblErrPW.Text = "";
            }
            else
            {
                lblErrPW.Visible = true;
                lblErrPW.Text = e2;
            }
        }

        private void tbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Confirm Your Password";
            string e2 = "Please Match Your Password";
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
            string pattern= "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = e1;
            }
            else if(Regex.IsMatch(tbEmail.Text,pattern))
            {
                lblErrEmail.Visible = false;
                lblErrEmail.Text = "";
            }
            else
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = e2;
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbEmail.Text) && string.IsNullOrEmpty(tbPasswordConfirm.Text) && string.IsNullOrEmpty(tbPassword.Text) && string.IsNullOrEmpty(tbName.Text) && string.IsNullOrEmpty(tbUsername.Text)) 
            {
                staff newstaff = new staff();
                using (var betterdb=new betterlimitedEntities())
                {
                    newstaff.name = tbName.Text;
                    newstaff.phone_no = (int)Convert.ToDouble(tbPhone.Text);
                    newstaff.email = tbEmail.Text;
                    newstaff.position_ID = cboPosition.SelectedIndex;
                    newstaff.department_ID = cboDepartment.SelectedIndex;
                    newstaff.username = tbUsername.Text;
                    newstaff.password = tbPassword.Text;
                    newstaff.hire_date = Convert.ToDateTime(dtpHireDate);
                    newstaff.DOB = Convert.ToDateTime(dtpDOB);
                    betterdb.staffs.Add(newstaff);
                    betterdb.SaveChanges();
                    var userNameResult = (from uName in betterdb.staffs
                                          where uName.username == tbUsername.Text
                                          select uName.username).FirstOrDefault();
                    if(!(userNameResult==null))
                    {

                    }


                }
            }
            else
            {
                MessageBox.Show("Please fill in all infomation!");
                return;
            }
            
            
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Phone Number";
            string e2 = "*Phone number must between 8-11 digits";
            string pattern = "^[0-9].{7,11}$";
            if(string.IsNullOrEmpty(tbPhone.Text))
            {
                lblErrPhone.Visible = true;
                lblErrPhone.Text = e1;
            }
            else if(Regex.IsMatch(tbPhone.Text,pattern))
            {
                lblErrPhone.Visible = false;
                lblErrPhone.Text = "";
            }
            else
            {
                lblErrPhone.Visible = true;
                lblErrPhone.Text = e2;
            }

        }
    }
}
