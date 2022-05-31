﻿using System;
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
    public partial class LoginForm : Form
    {
        private string usernamePlaceHolder = "Enter staff ID";
        private string passwordPlaceHolder = "Enter password";
        private char passwordChar = '*';
        private char passwordCharNone = '\0';
        private Boolean passwordHide = true;

        private string username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void enteringTextBox(TextBox tb, string msg)
        {
          
            if (tb.Text == msg)
            {
                tb.ForeColor = Color.Black;
                tb.Text = "";
            }
        }

        private void LeavingTextBox(TextBox tb, string msg)
        {

            if (tb.Text == "")
            {
                tb.ForeColor = Color.Gray;
                tb.Text = msg;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LeavingTextBox(tbUsername, usernamePlaceHolder);
            LeavingTextBox(tbPassword, passwordPlaceHolder);
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            enteringTextBox(tbUsername, usernamePlaceHolder);
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            LeavingTextBox(tbUsername, usernamePlaceHolder);
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            enteringTextBox(tbPassword, passwordPlaceHolder);
            tbPassword.PasswordChar = (passwordHide) ? passwordChar : passwordCharNone;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            LeavingTextBox(tbPassword, passwordPlaceHolder);
            if (tbPassword.Text == passwordPlaceHolder)
            {
                tbPassword.PasswordChar = passwordCharNone;
            }
            else
            {
                tbPassword.PasswordChar = (passwordHide) ? passwordChar : passwordCharNone;
            }

        }

        private void passwordPic_Click(object sender, EventArgs e)
        {
            passwordHide = !passwordHide;
            passwordPic.Image = (passwordHide)
                ? BetterLimitedProject.Properties.Resources.password_show2
                : BetterLimitedProject.Properties.Resources.password_hide;
            if (tbPassword.Text != passwordPlaceHolder)
            {
                tbPassword.PasswordChar = (passwordHide) ? passwordChar : passwordCharNone;
            }
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(79, 79, 79);
        }

        private void clear()
        {
            tbUsername.Text = usernamePlaceHolder;
            tbPassword.Text = passwordPlaceHolder;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;

            if (username == usernamePlaceHolder || password == passwordPlaceHolder)
            {
                MessageBox.Show("Username / Password can not be empty!!");
            }
            else
            {
                using (var betterDB = new betterlimitedEntities())
                {

                    var user = (from users in betterDB.staffs
                                where users.username.Equals(username)
                                select new {users.username, users.password, users.department_ID}).FirstOrDefault();
                    if (password.Equals(user.password))
                    {
                        // Login Successful
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        switch (user.department_ID)
                        {
                            case 1:
                                Sales salefrm = new Sales();
                                salefrm.ShowDialog();
                                break;
                            case 2:
                                Inventory invenfrm = new Inventory();
                                invenfrm.ShowDialog();
                                break;
                            case 3:
                                Technical techfrm = new Technical();
                                techfrm.ShowDialog();
                                break;
                            case 4:
                                Accounting accfrm = new Accounting();
                                accfrm.ShowDialog();
                                break;
                            case 5:
                                Purchase purfrm = new Purchase();
                                purfrm.ShowDialog();
                                break;
                        } 
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                        clear();
                    }
                }
            }
        }
    }
} 