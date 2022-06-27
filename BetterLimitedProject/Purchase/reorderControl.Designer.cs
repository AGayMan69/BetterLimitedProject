
namespace BetterLimitedProject.Purchase
{
    partial class reorderControl
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
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblApprove = new System.Windows.Forms.Label();
            this.lblReject = new System.Windows.Forms.Label();
            this.lblPENDING = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.lblCreate);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblApprove);
            this.panel1.Controls.Add(this.lblReject);
            this.panel1.Controls.Add(this.lblPENDING);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 96);
            this.panel1.TabIndex = 0;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnReject.FlatAppearance.BorderSize = 3;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnReject.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.btnReject.Location = new System.Drawing.Point(705, 22);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(53, 53);
            this.btnReject.TabIndex = 7;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnApprove.FlatAppearance.BorderSize = 3;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnApprove.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.btnApprove.Location = new System.Drawing.Point(635, 22);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(53, 53);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.FlatAppearance.BorderSize = 3;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(37)))));
            this.btnDetail.Location = new System.Drawing.Point(514, 22);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(103, 53);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "DETAIL";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(310, 39);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(135, 21);
            this.lblCreate.TabIndex = 4;
            this.lblCreate.Text = "2022-06-05 19:43";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(207, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 21);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "2200000";
            // 
            // lblApprove
            // 
            this.lblApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblApprove.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblApprove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblApprove.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApprove.Location = new System.Drawing.Point(0, 0);
            this.lblApprove.Name = "lblApprove";
            this.lblApprove.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblApprove.Size = new System.Drawing.Size(183, 96);
            this.lblApprove.TabIndex = 0;
            this.lblApprove.Text = "  APPROVED";
            this.lblApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReject
            // 
            this.lblReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lblReject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblReject.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.lblReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReject.Location = new System.Drawing.Point(0, 0);
            this.lblReject.Name = "lblReject";
            this.lblReject.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblReject.Size = new System.Drawing.Size(183, 96);
            this.lblReject.TabIndex = 2;
            this.lblReject.Text = " REJECTED";
            this.lblReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPENDING
            // 
            this.lblPENDING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblPENDING.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPENDING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblPENDING.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblPENDING.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPENDING.Location = new System.Drawing.Point(0, 0);
            this.lblPENDING.Name = "lblPENDING";
            this.lblPENDING.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPENDING.Size = new System.Drawing.Size(183, 96);
            this.lblPENDING.TabIndex = 1;
            this.lblPENDING.Text = " PENDING";
            this.lblPENDING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reorderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "reorderControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Size = new System.Drawing.Size(784, 116);
            this.Load += new System.EventHandler(this.reorderControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApprove;
        private System.Windows.Forms.Label lblPENDING;
        private System.Windows.Forms.Label lblReject;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}
