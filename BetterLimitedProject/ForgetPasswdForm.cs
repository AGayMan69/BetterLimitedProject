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
using Org.BouncyCastle.Bcpg;

namespace BetterLimitedProject
{
    public partial class ForgetPasswdForm : Form
    {
        private string name;
        private int staffID;

        public ForgetPasswdForm()
        {
            InitializeComponent();
        }

        private void generateForgotPasswordRequest()
        {
            // generate UUID
            Guid uuid = Guid.NewGuid();
            String g = uuid.ToString();

            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("limitedbetter@outlook.com"));
            email.To.Add(MailboxAddress.Parse("testbetterlimited@outlook.com"));
            email.Subject = "Better Limited: Reset Password";
            var emailBuilder = new BodyBuilder();
            emailBuilder.HtmlBody = $"<h2>Dear {name}, </h2>To reset your password, please copy & enter the verification code<br/><br/>{g}";
            email.Body = emailBuilder.ToMessageBody();

            // send email
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("limitedbetter@outlook.com", "itp4915m");
                try
                {

                    smtp.Send(email);
                    MessageBox.Show("Sending email");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("fail to send email");
                }
                finally
                {
                    smtp.Disconnect(true);
                }
            }

            // create reset password request
            using (var betterDB = new betterlimitedEntities())
            {
                resetpassword_request request = new resetpassword_request();
                request.staff_ID = staffID;
                request.request_code = g;
                request.request_time = DateTime.Now;
                betterDB.resetpassword_request.Add(request);

                try
                {
                    betterDB.SaveChanges();
                    MessageBox.Show("Request generated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating request.");
                }
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
                if (userResult == null)
                {
                    return false;
                }
                else
                {
                    name = userResult.name;
                    staffID = userResult.staff_ID;
                    return true;
                }
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
