
namespace BetterLimitedProject.Sales
{
    partial class POSProductControl
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
            this.panProductdesc = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panProductdesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panProductdesc
            // 
            this.panProductdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panProductdesc.Controls.Add(this.lblProductName);
            this.panProductdesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProductdesc.Location = new System.Drawing.Point(0, 196);
            this.panProductdesc.Name = "panProductdesc";
            this.panProductdesc.Size = new System.Drawing.Size(250, 110);
            this.panProductdesc.TabIndex = 1;
            this.panProductdesc.DoubleClick += new System.EventHandler(this.panProductdesc_DoubleClick);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(24, 24);
            this.lblProductName.MaximumSize = new System.Drawing.Size(230, 80);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(140, 60);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "TUF Gaming VS28UQIA";
            // 
            // pbProduct
            // 
            this.pbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProduct.Location = new System.Drawing.Point(0, 0);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(250, 198);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            this.pbProduct.DoubleClick += new System.EventHandler(this.pbProduct_DoubleClick);
            // 
            // POSProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panProductdesc);
            this.Controls.Add(this.pbProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 20, 20);
            this.Name = "POSProductControl";
            this.Size = new System.Drawing.Size(250, 306);
            this.panProductdesc.ResumeLayout(false);
            this.panProductdesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Panel panProductdesc;
        private System.Windows.Forms.Label lblProductName;
    }
}
