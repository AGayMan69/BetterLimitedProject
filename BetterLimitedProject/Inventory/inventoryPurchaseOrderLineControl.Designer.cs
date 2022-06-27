
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnRm = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(120, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(199, 58);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "MIDEA MW-09CRF8B 1HP Window Type Inverter Air-conditioner";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRm);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.nudQty);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 112);
            this.panel1.TabIndex = 2;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(520, 42);
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
            this.nudQty.Size = new System.Drawing.Size(94, 29);
            this.nudQty.TabIndex = 2;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(359, 44);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(86, 21);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "SAMSUNG";
            // 
            // btnRm
            // 
            this.btnRm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnRm.FlatAppearance.BorderSize = 0;
            this.btnRm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRm.ForeColor = System.Drawing.Color.White;
            this.btnRm.Location = new System.Drawing.Point(662, 10);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(110, 90);
            this.btnRm.TabIndex = 4;
            this.btnRm.Text = "REMOVE";
            this.btnRm.UseVisualStyleBackColor = false;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Location = new System.Drawing.Point(10, 10);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(90, 90);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 1;
            this.pbProduct.TabStop = false;
            // 
            // inventoryPurchaseOrderLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "inventoryPurchaseOrderLineControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Size = new System.Drawing.Size(788, 127);
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
