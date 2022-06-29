
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRestock);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.lblCreatTime);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblPOrderID);
            this.panel1.Controls.Add(this.lblApprove);
            this.panel1.Controls.Add(this.lblPENDING);
            this.panel1.Controls.Add(this.lblReject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(37)))));
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Location = new System.Drawing.Point(647, 37);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(119, 53);
            this.btnRestock.TabIndex = 11;
            this.btnRestock.Text = "RESTOCK";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 3;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(207)))), ((int)(((byte)(253)))));
            this.btnView.Location = new System.Drawing.Point(541, 37);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 53);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblCreatTime
            // 
            this.lblCreatTime.AutoSize = true;
            this.lblCreatTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatTime.Location = new System.Drawing.Point(348, 54);
            this.lblCreatTime.Name = "lblCreatTime";
            this.lblCreatTime.Size = new System.Drawing.Size(160, 21);
            this.lblCreatTime.TabIndex = 8;
            this.lblCreatTime.Text = "2022-06-26 23:56:59";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(271, 54);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(53, 21);
            this.lblSupplier.TabIndex = 7;
            this.lblSupplier.Text = "Redmi";
            // 
            // lblPOrderID
            // 
            this.lblPOrderID.AutoSize = true;
            this.lblPOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOrderID.Location = new System.Drawing.Point(173, 54);
            this.lblPOrderID.Name = "lblPOrderID";
            this.lblPOrderID.Size = new System.Drawing.Size(73, 21);
            this.lblPOrderID.TabIndex = 6;
            this.lblPOrderID.Text = "2200000";
            // 
            // lblApprove
            // 
            this.lblApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblApprove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblApprove.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApprove.Location = new System.Drawing.Point(0, 0);
            this.lblApprove.Name = "lblApprove";
            this.lblApprove.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblApprove.Size = new System.Drawing.Size(161, 130);
            this.lblApprove.TabIndex = 5;
            this.lblApprove.Text = "  APPROVED";
            this.lblApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPENDING
            // 
            this.lblPENDING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblPENDING.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPENDING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblPENDING.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblPENDING.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPENDING.Location = new System.Drawing.Point(0, 0);
            this.lblPENDING.Name = "lblPENDING";
            this.lblPENDING.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPENDING.Size = new System.Drawing.Size(161, 130);
            this.lblPENDING.TabIndex = 4;
            this.lblPENDING.Text = " PENDING";
            this.lblPENDING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReject
            // 
            this.lblReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lblReject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblReject.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.lblReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReject.Location = new System.Drawing.Point(0, 0);
            this.lblReject.Name = "lblReject";
            this.lblReject.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblReject.Size = new System.Drawing.Size(161, 130);
            this.lblReject.TabIndex = 3;
            this.lblReject.Text = " REJECTED";
            this.lblReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryPurchaseOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "InventoryPurchaseOrderControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Size = new System.Drawing.Size(784, 150);
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
