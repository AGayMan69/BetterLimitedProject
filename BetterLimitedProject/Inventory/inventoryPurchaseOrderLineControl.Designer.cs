
namespace BetterLimitedProject.Inventory
{
    partial class inventoryPurchaseOrderLineControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryPurchaseOrderLineControl));
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRm = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRm);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.nudQty);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Name = "panel1";
            // 
            // btnRm
            // 
            resources.ApplyResources(this.btnRm, "btnRm");
            this.btnRm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnRm.FlatAppearance.BorderSize = 0;
            this.btnRm.ForeColor = System.Drawing.Color.White;
            this.btnRm.Name = "btnRm";
            this.btnRm.UseVisualStyleBackColor = false;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // lblSupplier
            // 
            resources.ApplyResources(this.lblSupplier, "lblSupplier");
            this.lblSupplier.Name = "lblSupplier";
            // 
            // nudQty
            // 
            resources.ApplyResources(this.nudQty, "nudQty");
            this.nudQty.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // pbProduct
            // 
            resources.ApplyResources(this.pbProduct, "pbProduct");
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.TabStop = false;
            // 
            // inventoryPurchaseOrderLineControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "inventoryPurchaseOrderLineControl";
            this.Load += new System.EventHandler(this.inventoryPurchaseOrderLineControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnRm;
    }
}
