
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDeliveryControl));
            this.lblDeliveryID = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblDeliveryTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblStatusCompleted = new System.Windows.Forms.Label();
            this.lblStatusCancel = new System.Windows.Forms.Label();
            this.lblStatusPending = new System.Windows.Forms.Label();
            this.lblStatusApproved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeliveryID
            // 
            resources.ApplyResources(this.lblDeliveryID, "lblDeliveryID");
            this.lblDeliveryID.Name = "lblDeliveryID";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // lblCreationTime
            // 
            resources.ApplyResources(this.lblCreationTime, "lblCreationTime");
            this.lblCreationTime.Name = "lblCreationTime";
            // 
            // lblDeliveryTime
            // 
            resources.ApplyResources(this.lblDeliveryTime, "lblDeliveryTime");
            this.lblDeliveryTime.Name = "lblDeliveryTime";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Name = "panel1";
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
            // btnArrange
            // 
            resources.ApplyResources(this.btnArrange, "btnArrange");
            this.btnArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnArrange.FlatAppearance.BorderSize = 0;
            this.btnArrange.ForeColor = System.Drawing.Color.White;
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.UseVisualStyleBackColor = false;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(37)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblStatusCompleted
            // 
            resources.ApplyResources(this.lblStatusCompleted, "lblStatusCompleted");
            this.lblStatusCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblStatusCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblStatusCompleted.Image = global::BetterLimitedProject.Properties.Resources.completed_status;
            this.lblStatusCompleted.Name = "lblStatusCompleted";
            // 
            // lblStatusCancel
            // 
            resources.ApplyResources(this.lblStatusCancel, "lblStatusCancel");
            this.lblStatusCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lblStatusCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblStatusCancel.Image = global::BetterLimitedProject.Properties.Resources.cancel_status;
            this.lblStatusCancel.Name = "lblStatusCancel";
            // 
            // lblStatusPending
            // 
            resources.ApplyResources(this.lblStatusPending, "lblStatusPending");
            this.lblStatusPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.lblStatusPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(105)))));
            this.lblStatusPending.Image = global::BetterLimitedProject.Properties.Resources.pending_status;
            this.lblStatusPending.Name = "lblStatusPending";
            // 
            // lblStatusApproved
            // 
            resources.ApplyResources(this.lblStatusApproved, "lblStatusApproved");
            this.lblStatusApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblStatusApproved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(207)))), ((int)(((byte)(253)))));
            this.lblStatusApproved.Image = global::BetterLimitedProject.Properties.Resources.approved_status;
            this.lblStatusApproved.Name = "lblStatusApproved";
            // 
            // InventoryDeliveryControl
            // 
            resources.ApplyResources(this, "$this");
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
