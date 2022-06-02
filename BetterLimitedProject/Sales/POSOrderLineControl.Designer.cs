
namespace BetterLimitedProject.Sales
{
    partial class POSOrderLineControl
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
            this.numUpDwnQty = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(66, 30);
            this.lblProductName.MaximumSize = new System.Drawing.Size(120, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 50);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDwnQty
            // 
            this.numUpDwnQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.numUpDwnQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwnQty.ForeColor = System.Drawing.Color.White;
            this.numUpDwnQty.Location = new System.Drawing.Point(15, 30);
            this.numUpDwnQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnQty.Name = "numUpDwnQty";
            this.numUpDwnQty.ReadOnly = true;
            this.numUpDwnQty.Size = new System.Drawing.Size(36, 25);
            this.numUpDwnQty.TabIndex = 2;
            this.numUpDwnQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnQty.ValueChanged += new System.EventHandler(this.numUpDwnQty_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(205, 34);
            this.lblPrice.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "$2323";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(285, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 86);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // POSOrderLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numUpDwnQty);
            this.Controls.Add(this.lblProductName);
            this.Name = "POSOrderLineControl";
            this.Size = new System.Drawing.Size(317, 86);
            this.Load += new System.EventHandler(this.POSOrderLineControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.NumericUpDown numUpDwnQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDel;
    }
}
