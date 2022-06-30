
namespace BetterLimitedProject.Inventory
{
    partial class PurUpdateOrderLineControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurUpdateOrderLineControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Name = "panel1";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQty
            // 
            resources.ApplyResources(this.lblQty, "lblQty");
            this.lblQty.Name = "lblQty";
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // pbProduct
            // 
            resources.ApplyResources(this.pbProduct, "pbProduct");
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.TabStop = false;
            // 
            // PurUpdateOrderLineControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "PurUpdateOrderLineControl";
            this.Load += new System.EventHandler(this.PurUpdateOrderLineControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnConfirm;
    }
}
