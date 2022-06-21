
namespace BetterLimitedProject.Sales
{
    partial class SalesReservationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReservationControl));
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReservationID
            // 
            resources.ApplyResources(this.lblReservationID, "lblReservationID");
            this.lblReservationID.Name = "lblReservationID";
            // 
            // lblCustomerName
            // 
            resources.ApplyResources(this.lblCustomerName, "lblCustomerName");
            this.lblCustomerName.Name = "lblCustomerName";
            // 
            // lblReservationDate
            // 
            resources.ApplyResources(this.lblReservationDate, "lblReservationDate");
            this.lblReservationDate.Name = "lblReservationDate";
            // 
            // btnDel
            // 
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Name = "btnDel";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPay
            // 
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(203)))), ((int)(((byte)(126)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Name = "btnPay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // SalesReservationControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblReservationDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblReservationID);
            this.Name = "SalesReservationControl";
            this.Load += new System.EventHandler(this.SalesReservationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPay;
    }
}
