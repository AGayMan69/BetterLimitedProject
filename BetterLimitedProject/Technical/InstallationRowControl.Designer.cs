
namespace BetterLimitedProject.Technical
{
    partial class InstallationRowControl
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
            this.lblInstallationDate = new System.Windows.Forms.Label();
            this.lblDeliveryID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.lblInstallationID = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstallationDate
            // 
            this.lblInstallationDate.AutoSize = true;
            this.lblInstallationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallationDate.Location = new System.Drawing.Point(320, 17);
            this.lblInstallationDate.Name = "lblInstallationDate";
            this.lblInstallationDate.Size = new System.Drawing.Size(157, 21);
            this.lblInstallationDate.TabIndex = 2;
            this.lblInstallationDate.Text = "2022-06-04 15:32:26";
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryID.Location = new System.Drawing.Point(520, 17);
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(73, 21);
            this.lblDeliveryID.TabIndex = 3;
            this.lblDeliveryID.Text = "2200030";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(635, 17);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(73, 21);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "2200029";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(118)))), ((int)(((byte)(19)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(723, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 54);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(203)))), ((int)(((byte)(126)))));
            this.btnArrange.FlatAppearance.BorderSize = 0;
            this.btnArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrange.ForeColor = System.Drawing.Color.White;
            this.btnArrange.Location = new System.Drawing.Point(723, 0);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(101, 54);
            this.btnArrange.TabIndex = 6;
            this.btnArrange.Text = "ARRANGE";
            this.btnArrange.UseVisualStyleBackColor = false;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // lblInstallationID
            // 
            this.lblInstallationID.AutoSize = true;
            this.lblInstallationID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallationID.Location = new System.Drawing.Point(184, 17);
            this.lblInstallationID.Name = "lblInstallationID";
            this.lblInstallationID.Size = new System.Drawing.Size(73, 21);
            this.lblInstallationID.TabIndex = 7;
            this.lblInstallationID.Text = "2200000";
            // 
            // lblAssigned
            // 
            this.lblAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssigned.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblAssigned.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblAssigned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAssigned.Location = new System.Drawing.Point(0, 0);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Padding = new System.Windows.Forms.Padding(5);
            this.lblAssigned.Size = new System.Drawing.Size(156, 54);
            this.lblAssigned.TabIndex = 1;
            this.lblAssigned.Text = "Assigned";
            this.lblAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPending
            // 
            this.lblPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblPending.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPending.Location = new System.Drawing.Point(0, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Padding = new System.Windows.Forms.Padding(5);
            this.lblPending.Size = new System.Drawing.Size(156, 54);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "Pending";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InstallationRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInstallationID);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDeliveryID);
            this.Controls.Add(this.lblInstallationDate);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.lblPending);
            this.Name = "InstallationRowControl";
            this.Size = new System.Drawing.Size(824, 54);
            this.Load += new System.EventHandler(this.InstallationRowControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblInstallationDate;
        private System.Windows.Forms.Label lblDeliveryID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Label lblInstallationID;
    }
}
