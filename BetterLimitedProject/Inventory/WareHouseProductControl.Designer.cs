﻿
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
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(787, 75);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnRestock);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblProductID);
            this.panel2.Controls.Add(this.lblInStock);
            this.panel2.Controls.Add(this.lblOutStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 71);
            this.panel2.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEdit.FlatAppearance.BorderSize = 4;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEdit.Location = new System.Drawing.Point(599, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 71);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(118)))), ((int)(((byte)(19)))));
            this.btnRestock.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Location = new System.Drawing.Point(692, 0);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(91, 71);
            this.btnRestock.TabIndex = 5;
            this.btnRestock.Text = "RESTOCK";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoEllipsis = true;
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(537, 25);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(25, 20);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "20";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoEllipsis = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(372, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(115, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Gaming";
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(200, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "TUF Gaming sdfsdfsd";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(145, 25);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(23, 20);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "12";
            // 
            // lblInStock
            // 
            this.lblInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInStock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.ForeColor = System.Drawing.Color.White;
            this.lblInStock.Location = new System.Drawing.Point(-2, -2);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(130, 75);
            this.lblInStock.TabIndex = 0;
            this.lblInStock.Text = "IN STOCK";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutStock
            // 
            this.lblOutStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblOutStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutStock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStock.ForeColor = System.Drawing.Color.White;
            this.lblOutStock.Location = new System.Drawing.Point(-2, -2);
            this.lblOutStock.Name = "lblOutStock";
            this.lblOutStock.Size = new System.Drawing.Size(130, 75);
            this.lblOutStock.TabIndex = 1;
            this.lblOutStock.Text = "OUT OF STOCK";
            this.lblOutStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WareHouseProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WareHouseProductControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Size = new System.Drawing.Size(787, 85);
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