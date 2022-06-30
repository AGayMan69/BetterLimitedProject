
namespace BetterLimitedProject.Purchase
{
    partial class PurchaseGoodControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseGoodControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblReceivedTime = new System.Windows.Forms.Label();
            this.lblPurchaseOrderID = new System.Windows.Forms.Label();
            this.lblReceiveID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.lblReceivedTime);
            this.panel1.Controls.Add(this.lblPurchaseOrderID);
            this.panel1.Controls.Add(this.lblReceiveID);
            this.panel1.Name = "panel1";
            // 
            // btnDetail
            // 
            resources.ApplyResources(this.btnDetail, "btnDetail");
            this.btnDetail.FlatAppearance.BorderSize = 3;
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblReceivedTime
            // 
            resources.ApplyResources(this.lblReceivedTime, "lblReceivedTime");
            this.lblReceivedTime.Name = "lblReceivedTime";
            // 
            // lblPurchaseOrderID
            // 
            resources.ApplyResources(this.lblPurchaseOrderID, "lblPurchaseOrderID");
            this.lblPurchaseOrderID.Name = "lblPurchaseOrderID";
            // 
            // lblReceiveID
            // 
            resources.ApplyResources(this.lblReceiveID, "lblReceiveID");
            this.lblReceiveID.Name = "lblReceiveID";
            // 
            // PurchaseGoodControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseGoodControl";
            this.Load += new System.EventHandler(this.PurchaseGoodControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReceiveID;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblReceivedTime;
        private System.Windows.Forms.Label lblPurchaseOrderID;
    }
}
