
namespace BetterLimitedProject.Inventory
{
    partial class WareHouseProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseProductControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblOutStock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnRestock);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblProductID);
            this.panel2.Controls.Add(this.lblInStock);
            this.panel2.Controls.Add(this.lblOutStock);
            this.panel2.Name = "panel2";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEdit.FlatAppearance.BorderSize = 4;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRestock
            // 
            resources.ApplyResources(this.btnRestock, "btnRestock");
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(118)))), ((int)(((byte)(19)))));
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // lblQty
            // 
            resources.ApplyResources(this.lblQty, "lblQty");
            this.lblQty.AutoEllipsis = true;
            this.lblQty.Name = "lblQty";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.AutoEllipsis = true;
            this.lblCategory.Name = "lblCategory";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.AutoEllipsis = true;
            this.lblName.Name = "lblName";
            // 
            // lblProductID
            // 
            resources.ApplyResources(this.lblProductID, "lblProductID");
            this.lblProductID.Name = "lblProductID";
            // 
            // lblInStock
            // 
            resources.ApplyResources(this.lblInStock, "lblInStock");
            this.lblInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInStock.ForeColor = System.Drawing.Color.White;
            this.lblInStock.Name = "lblInStock";
            // 
            // lblOutStock
            // 
            resources.ApplyResources(this.lblOutStock, "lblOutStock");
            this.lblOutStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblOutStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutStock.ForeColor = System.Drawing.Color.White;
            this.lblOutStock.Name = "lblOutStock";
            // 
            // WareHouseProductControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WareHouseProductControl";
            this.Load += new System.EventHandler(this.WareHouseProductControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblOutStock;
    }
}
