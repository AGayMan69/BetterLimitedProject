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
        private bool nameFill, usernameFill, pwFill, cfPWFill, emailFill, phoneFill;
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
                nameFill = true;
                
            }
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
                usernameFill = true;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string wkPW = @"^\d{7,20}$";
            string normalPW = "[^A-Z].+[a-z].[^A-Z]{7,20}";
            string strongPW = ".+[A-Z].{7,20}";
            if (Regex.IsMatch(tbPassword.Text, wkPW))
            {
                pnlPW.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (Regex.IsMatch(tbPassword.Text, normalPW))
            {
                pnlPW.BackColor = Color.FromArgb(255, 255, 0);
            }
            else if (Regex.IsMatch(tbPassword.Text, strongPW))
            {
                pnlPW.BackColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                pnlPW.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string e1 = "*Please Enter Your Password";
            string e2 = "Accept numbers and letters between 8-20";
            string pattern = "^[0-9a-zA-Z]{7,20}$";
            string tooWeak = @"^\d{7,20}$";
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                lblErrPW.Visible = true;
                lblErrPW.Text = e1;
            }
            else if (Regex.IsMatch(tbPassword.Text, tooWeak))
            {
                MessageBox.Show("Your password is too weak!\n Please add letters in the password!\n e.g. 'W2X154dasWA'");
            }
            else if(Regex.IsMatch(tbPassword.Text,pattern))
            {
                lblErrPW.Visible = false;
                lblErrPW.Text = "";
                pwFill = true;
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
            string e2 = "*Please Match Your Password";
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
                cfPWFill = true;
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
                emailFill = true;
            }
            else
            {
                lblErrEmail.Visible = true;
                lblErrEmail.Text = e2;
                
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
                phoneFill = true;
            }
            else
            {
                lblErrPhone.Visible = true;
                lblErrPhone.Text = e2;
                
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (nameFill && usernameFill && pwFill && cfPWFill && emailFill && phoneFill) 
            {
                string matchPW = "*Please Match Your Password";
                string pw = tbPassword.Text;
                string cpw = tbPasswordConfirm.Text;
                if (pw != cpw)
                {
                    lblErrCPW.Visible = true;
                    lblErrCPW.Text = matchPW;
                }
                staff newstaff = new staff();
                int phoneNumber = (int)Convert.ToDouble(tbPhone.Text);
                using (var betterdb=new betterlimitedEntities())
                {
                    if (cboDepartment.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the department");
                        return;
                    }
                    if(cboPosition.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the position");
                        return;
                    }
                    string targetPostn = cboPosition.SelectedItem.ToString();
                    var userNameResult = (from uName in betterdb.staffs
                                          where uName.username == tbUsername.Text
                                          select uName.username).FirstOrDefault();
                    var phoneResult = (from phoneNo in betterdb.staffs
                                       where phoneNo.phone_no == phoneNumber
                                       select phoneNo.phone_no).FirstOrDefault();
                    var emailResult = (from emailRe in betterdb.staffs
                                       where emailRe.email == tbEmail.Text
                                       select emailRe.email).FirstOrDefault();
                    if (!(userNameResult == null))
                    {
                        lblErrUsername.Visible = true;
                        lblErrUsername.Text = "*This Username has been used";
                        return;
                    }
                    else
                    {
                        lblErrUsername.Visible = false;
                        lblErrUsername.Text = "";
                    }
                    if (!(phoneResult == 0))
                    {
                        lblErrPhone.Visible = true;
                        lblErrPhone.Text = "*This Phone number has been used";
                    }
                    else
                    {
                        lblErrPhone.Visible = true;
                        lblErrPhone.Text = "";
                    }
                    newstaff.name = tbName.Text;
                    newstaff.phone_no = (int)Convert.ToDouble(tbPhone.Text);
                    newstaff.email = tbEmail.Text;
                    var findPoID = (from postn in betterdb.positions
                                    where postn.position_title.Contains(targetPostn)
                                    select postn.positionID).FirstOrDefault();
                    newstaff.position_ID = findPoID;
                    newstaff.department_ID = cboDepartment.SelectedIndex+1;
                    newstaff.username = tbUsername.Text;
                    newstaff.password = tbPassword.Text;
                    newstaff.hire_date = dtpHireDate.Value;
                    newstaff.DOB = dtpDOB.Value;
                    betterdb.staffs.Add(newstaff);
                    betterdb.SaveChanges();
                    MessageBox.Show("You have successfully registered");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all infomation!");
                return;
            }
            
            
        }
    }
}
