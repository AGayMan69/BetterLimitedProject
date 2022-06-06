
namespace BetterLimitedProject.Inventory
{
    partial class InventoryDeliveryControl
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
            this.lblStatusPending = new System.Windows.Forms.Label();
            this.lblStatusCancel = new System.Windows.Forms.Label();
            this.lblStatusApproved = new System.Windows.Forms.Label();
            this.lblStatusCompleted = new System.Windows.Forms.Label();
            this.lblDeliveryID = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblDeliveryTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusPending
            // 
            this.lblStatusPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblStatusPending.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblStatusPending.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblStatusPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusPending.Location = new System.Drawing.Point(0, 0);
            this.lblStatusPending.Name = "lblStatusPending";
            this.lblStatusPending.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblStatusPending.Size = new System.Drawing.Size(160, 60);
            this.lblStatusPending.TabIndex = 1;
            this.lblStatusPending.Text = "   Pending";
            this.lblStatusPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusCancel
            // 
            this.lblStatusCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lblStatusCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblStatusCancel.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.lblStatusCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusCancel.Location = new System.Drawing.Point(0, 0);
            this.lblStatusCancel.Name = "lblStatusCancel";
            this.lblStatusCancel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblStatusCancel.Size = new System.Drawing.Size(160, 60);
            this.lblStatusCancel.TabIndex = 0;
            this.lblStatusCancel.Text = "  Cancel";
            this.lblStatusCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusApproved
            // 
            this.lblStatusApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblStatusApproved.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusApproved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(207)))), ((int)(((byte)(253)))));
            this.lblStatusApproved.Image = global::BetterLimitedProject.Properties.Resources.approved_status;
            this.lblStatusApproved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusApproved.Location = new System.Drawing.Point(0, 0);
            this.lblStatusApproved.Name = "lblStatusApproved";
            this.lblStatusApproved.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblStatusApproved.Size = new System.Drawing.Size(160, 60);
            this.lblStatusApproved.TabIndex = 2;
            this.lblStatusApproved.Text = "      Approved";
            this.lblStatusApproved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusCompleted
            // 
            this.lblStatusCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblStatusCompleted.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblStatusCompleted.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblStatusCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusCompleted.Location = new System.Drawing.Point(0, 0);
            this.lblStatusCompleted.Name = "lblStatusCompleted";
            this.lblStatusCompleted.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblStatusCompleted.Size = new System.Drawing.Size(160, 60);
            this.lblStatusCompleted.TabIndex = 3;
            this.lblStatusCompleted.Text = "      Completed";
            this.lblStatusCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryID.Location = new System.Drawing.Point(166, 19);
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(73, 21);
            this.lblDeliveryID.TabIndex = 4;
            this.lblDeliveryID.Text = "2200000";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(254, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(81, 21);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Replenish";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationTime.Location = new System.Drawing.Point(363, 19);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(135, 21);
            this.lblCreationTime.TabIndex = 6;
            this.lblCreationTime.Text = "2022-06-05 19:43";
            // 
            // lblDeliveryTime
            // 
            this.lblDeliveryTime.AutoSize = true;
            this.lblDeliveryTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryTime.Location = new System.Drawing.Point(514, 19);
            this.lblDeliveryTime.Name = "lblDeliveryTime";
            this.lblDeliveryTime.Size = new System.Drawing.Size(135, 21);
            this.lblDeliveryTime.TabIndex = 8;
            this.lblDeliveryTime.Text = "2022-06-05 19:43";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 19);
            this.panel1.TabIndex = 9;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(794, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 54);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnArrange.FlatAppearance.BorderSize = 0;
            this.btnArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrange.ForeColor = System.Drawing.Color.White;
            this.btnArrange.Location = new System.Drawing.Point(671, 0);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(102, 54);
            this.btnArrange.TabIndex = 11;
            this.btnArrange.Text = "ARRANGE";
            this.btnArrange.UseVisualStyleBackColor = false;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(37)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(671, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 54);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // InventoryDeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDeliveryTime);
            this.Controls.Add(this.lblCreationTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDeliveryID);
            this.Controls.Add(this.lblStatusCompleted);
            this.Controls.Add(this.lblStatusCancel);
            this.Controls.Add(this.lblStatusPending);
            this.Controls.Add(this.lblStatusApproved);
            this.Name = "InventoryDeliveryControl";
            this.Size = new System.Drawing.Size(832, 73);
            this.Load += new System.EventHandler(this.InventoryDeliveryControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusCancel;
        private System.Windows.Forms.Label lblStatusPending;
        private System.Windows.Forms.Label lblStatusApproved;
        private System.Windows.Forms.Label lblStatusCompleted;
        private System.Windows.Forms.Label lblDeliveryID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lblDeliveryTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Button btnEdit;
    }
}
