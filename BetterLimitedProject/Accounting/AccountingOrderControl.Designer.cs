
namespace BetterLimitedProject.Accounting
{
    partial class AccountingOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingOrderControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInstallationID = new System.Windows.Forms.Label();
            this.lblDeliveryID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblInstallationID);
            this.panel2.Controls.Add(this.lblDeliveryID);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblCustomerID);
            this.panel2.Controls.Add(this.lblOrderID);
            this.panel2.Name = "panel2";
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(203)))), ((int)(((byte)(126)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblInstallationID
            // 
            resources.ApplyResources(this.lblInstallationID, "lblInstallationID");
            this.lblInstallationID.Name = "lblInstallationID";
            // 
            // lblDeliveryID
            // 
            resources.ApplyResources(this.lblDeliveryID, "lblDeliveryID");
            this.lblDeliveryID.Name = "lblDeliveryID";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // lblCustomerID
            // 
            resources.ApplyResources(this.lblCustomerID, "lblCustomerID");
            this.lblCustomerID.Name = "lblCustomerID";
            // 
            // lblOrderID
            // 
            resources.ApplyResources(this.lblOrderID, "lblOrderID");
            this.lblOrderID.Name = "lblOrderID";
            // 
            // AccountingOrderControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AccountingOrderControl";
            this.Load += new System.EventHandler(this.AccountingOrderControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInstallationID;
        private System.Windows.Forms.Label lblDeliveryID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblOrderID;
    }
}
