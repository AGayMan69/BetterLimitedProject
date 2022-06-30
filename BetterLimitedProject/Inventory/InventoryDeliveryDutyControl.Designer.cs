
namespace BetterLimitedProject.Inventory
{
    partial class InventoryDeliveryDutyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDeliveryDutyControl));
            this.lblDelID = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUnAss = new System.Windows.Forms.Label();
            this.lblAss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDelID
            // 
            resources.ApplyResources(this.lblDelID, "lblDelID");
            this.lblDelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDelID.Name = "lblDelID";
            // 
            // btnAssign
            // 
            resources.ApplyResources(this.btnAssign, "btnAssign");
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
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
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Name = "lblType";
            // 
            // lblUnAss
            // 
            resources.ApplyResources(this.lblUnAss, "lblUnAss");
            this.lblUnAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblUnAss.ForeColor = System.Drawing.Color.White;
            this.lblUnAss.Image = global::BetterLimitedProject.Properties.Resources.warningicon;
            this.lblUnAss.Name = "lblUnAss";
            // 
            // lblAss
            // 
            resources.ApplyResources(this.lblAss, "lblAss");
            this.lblAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblAss.ForeColor = System.Drawing.Color.White;
            this.lblAss.Image = global::BetterLimitedProject.Properties.Resources.checkicon;
            this.lblAss.Name = "lblAss";
            // 
            // InventoryDeliveryDutyControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnAss);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDelID);
            this.Controls.Add(this.lblAss);
            this.Name = "InventoryDeliveryDutyControl";
            this.Load += new System.EventHandler(this.InventoryDeliveryDutyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnAss;
        private System.Windows.Forms.Label lblAss;
        private System.Windows.Forms.Label lblDelID;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblType;
    }
}
