
namespace BetterLimitedProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblErrName = new System.Windows.Forms.Label();
            this.lblErrEmail = new System.Windows.Forms.Label();
            this.lblErrCPW = new System.Windows.Forms.Label();
            this.lblErrUsername = new System.Windows.Forms.Label();
            this.lblErrPW = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblErrPhone = new System.Windows.Forms.Label();
            this.pnlPW = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Name = "panel1";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 5;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbName.Name = "tbName";
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbPasswordConfirm
            // 
            resources.ApplyResources(this.tbPasswordConfirm, "tbPasswordConfirm");
            this.tbPasswordConfirm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.tbPasswordConfirm_Validating);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // dtpDOB
            // 
            resources.ApplyResources(this.dtpDOB, "dtpDOB");
            this.dtpDOB.Name = "dtpDOB";
            // 
            // cboDepartment
            // 
            resources.ApplyResources(this.cboDepartment, "cboDepartment");
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.SelectedValueChanged += new System.EventHandler(this.cboDepartment_SelectedValueChanged);
            // 
            // cboPosition
            // 
            resources.ApplyResources(this.cboPosition, "cboPosition");
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Name = "cboPosition";
            // 
            // dtpHireDate
            // 
            resources.ApplyResources(this.dtpHireDate, "dtpHireDate");
            this.dtpHireDate.Name = "dtpHireDate";
            // 
            // lblErrName
            // 
            resources.ApplyResources(this.lblErrName, "lblErrName");
            this.lblErrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrName.Name = "lblErrName";
            // 
            // lblErrEmail
            // 
            resources.ApplyResources(this.lblErrEmail, "lblErrEmail");
            this.lblErrEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrEmail.Name = "lblErrEmail";
            // 
            // lblErrCPW
            // 
            resources.ApplyResources(this.lblErrCPW, "lblErrCPW");
            this.lblErrCPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrCPW.Name = "lblErrCPW";
            // 
            // lblErrUsername
            // 
            resources.ApplyResources(this.lblErrUsername, "lblErrUsername");
            this.lblErrUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrUsername.Name = "lblErrUsername";
            // 
            // lblErrPW
            // 
            resources.ApplyResources(this.lblErrPW, "lblErrPW");
            this.lblErrPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrPW.Name = "lblErrPW";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // lblErrPhone
            // 
            resources.ApplyResources(this.lblErrPhone, "lblErrPhone");
            this.lblErrPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrPhone.Name = "lblErrPhone";
            // 
            // pnlPW
            // 
            resources.ApplyResources(this.pnlPW, "pnlPW");
            this.pnlPW.Name = "pnlPW";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BetterLimitedProject.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblErrPW);
            this.Controls.Add(this.lblErrUsername);
            this.Controls.Add(this.lblErrCPW);
            this.Controls.Add(this.lblErrEmail);
            this.Controls.Add(this.lblErrName);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrName;
        private System.Windows.Forms.Label lblErrEmail;
        private System.Windows.Forms.Label lblErrCPW;
        private System.Windows.Forms.Label lblErrUsername;
        private System.Windows.Forms.Label lblErrPW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblErrPhone;
        private System.Windows.Forms.Panel pnlPW;
    }
}