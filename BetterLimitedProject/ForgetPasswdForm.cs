using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace BetterLimitedProject
{
    public partial class ForgetPasswdForm : Form
    {
        public ForgetPasswdForm()
        {
            InitializeComponent();
        }

        private void generateForgotPasswordRequest()
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("limitedbetter@outlook.com"));
            email.To.Add(MailboxAddress.Parse("sendbetter4915m@gmail.com"));
            email.Subject = "Better Limited: Reset Password";
            var emailBuilder = new BodyBuilder();
            emailBuilder.HtmlBody = "<h2>Dear Username, </h2>To reset your password, please copy & enter the verification code<br/><br/>dsfsdfsdfsd2342";
            email.Body = emailBuilder.ToMessageBody();

            // send email
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("limitedbetter@outlook.com", "itp4915m");
                smtp.Send(email);
                MessageBox.Show("Sending email");
                smtp.Disconnect(true);
            }
        }

        private bool clickValidUser()
        {
            var username = tbUsername.Text;
            var email = tbEmail.Text;

            using (var betterDb = new betterlimitedEntities())
            {
                var userResult = (from result in betterDb.staffs
                                  where result.username.Equals(username) && result.email.Equals(email)
                                  select result).FirstOrDefault();
                return (userResult != null);
            }

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            if (clickValidUser())
            {
                generateForgotPasswordRequest();
                VerifyResetPasswdForm verifyResetPasswdForm = new VerifyResetPasswdForm();
                this.Hide();
                DialogResult reset = verifyResetPasswdForm.ShowDialog();
                if (reset == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }

            }
            else
            {
                MessageBox.Show("Invalid username / email");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
