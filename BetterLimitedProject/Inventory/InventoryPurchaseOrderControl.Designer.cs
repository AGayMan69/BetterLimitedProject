
namespace BetterLimitedProject.Inventory
{
    partial class InventoryPurchaseOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryPurchaseOrderControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblCreatTime = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPOrderID = new System.Windows.Forms.Label();
            this.lblApprove = new System.Windows.Forms.Label();
            this.lblPENDING = new System.Windows.Forms.Label();
            this.lblReject = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRestock);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.lblCreatTime);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblPOrderID);
            this.panel1.Controls.Add(this.lblApprove);
            this.panel1.Controls.Add(this.lblPENDING);
            this.panel1.Controls.Add(this.lblReject);
            this.panel1.Name = "panel1";
            // 
            // btnRestock
            // 
            resources.ApplyResources(this.btnRestock, "btnRestock");
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(37)))));
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.FlatAppearance.BorderSize = 3;
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(207)))), ((int)(((byte)(253)))));
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblCreatTime
            // 
            resources.ApplyResources(this.lblCreatTime, "lblCreatTime");
            this.lblCreatTime.Name = "lblCreatTime";
            // 
            // lblSupplier
            // 
            resources.ApplyResources(this.lblSupplier, "lblSupplier");
            this.lblSupplier.Name = "lblSupplier";
            // 
            // lblPOrderID
            // 
            resources.ApplyResources(this.lblPOrderID, "lblPOrderID");
            this.lblPOrderID.Name = "lblPOrderID";
            // 
            // lblApprove
            // 
            resources.ApplyResources(this.lblApprove, "lblApprove");
            this.lblApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblApprove.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblApprove.Name = "lblApprove";
            // 
            // lblPENDING
            // 
            resources.ApplyResources(this.lblPENDING, "lblPENDING");
            this.lblPENDING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblPENDING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblPENDING.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblPENDING.Name = "lblPENDING";
            // 
            // lblReject
            // 
            resources.ApplyResources(this.lblReject, "lblReject");
            this.lblReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lblReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblReject.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.lblReject.Name = "lblReject";
            // 
            // InventoryPurchaseOrderControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "InventoryPurchaseOrderControl";
            this.Load += new System.EventHandler(this.InventoryPurchaseOrderControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReject;
        private System.Windows.Forms.Label lblPENDING;
        private System.Windows.Forms.Label lblApprove;
        private System.Windows.Forms.Label lblCreatTime;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPOrderID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRestock;
    }
}
