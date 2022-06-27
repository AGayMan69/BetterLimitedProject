
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReceiveID = new System.Windows.Forms.Label();
            this.lblPurchaseOrderID = new System.Windows.Forms.Label();
            this.lblReceivedTime = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.lblReceivedTime);
            this.panel1.Controls.Add(this.lblPurchaseOrderID);
            this.panel1.Controls.Add(this.lblReceiveID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 94);
            this.panel1.TabIndex = 0;
            // 
            // lblReceiveID
            // 
            this.lblReceiveID.AutoSize = true;
            this.lblReceiveID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveID.Location = new System.Drawing.Point(37, 38);
            this.lblReceiveID.Name = "lblReceiveID";
            this.lblReceiveID.Size = new System.Drawing.Size(73, 21);
            this.lblReceiveID.TabIndex = 1;
            this.lblReceiveID.Text = "2200000";
            // 
            // lblPurchaseOrderID
            // 
            this.lblPurchaseOrderID.AutoSize = true;
            this.lblPurchaseOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderID.Location = new System.Drawing.Point(201, 38);
            this.lblPurchaseOrderID.Name = "lblPurchaseOrderID";
            this.lblPurchaseOrderID.Size = new System.Drawing.Size(73, 21);
            this.lblPurchaseOrderID.TabIndex = 2;
            this.lblPurchaseOrderID.Text = "2200000";
            // 
            // lblReceivedTime
            // 
            this.lblReceivedTime.AutoSize = true;
            this.lblReceivedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedTime.Location = new System.Drawing.Point(355, 38);
            this.lblReceivedTime.Name = "lblReceivedTime";
            this.lblReceivedTime.Size = new System.Drawing.Size(157, 21);
            this.lblReceivedTime.TabIndex = 3;
            this.lblReceivedTime.Text = "2022-06-27 15:28:55";
            // 
            // btnDetail
            // 
            this.btnDetail.FlatAppearance.BorderSize = 3;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnDetail.Location = new System.Drawing.Point(648, 17);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(104, 60);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "DETAIL";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // PurchaseGoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseGoodControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Size = new System.Drawing.Size(788, 109);
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
