
namespace BetterLimitedProject.Sales
{
    partial class SalesVwOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesVwOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboOrderDate = new System.Windows.Forms.ComboBox();
            this.cboSortOrder = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panSalesLoad = new System.Windows.Forms.Panel();
            this.salesOrderControl2 = new BetterLimitedProject.Sales.SalesOrderControl();
            this.salesOrderControl1 = new BetterLimitedProject.Sales.SalesOrderControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panSalesLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(588, 28);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Walkin",
            "Delivery",
            "All"});
            this.cboType.Location = new System.Drawing.Point(27, 33);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 29);
            this.cboType.TabIndex = 3;
            this.cboType.SelectedValueChanged += new System.EventHandler(this.cboType_SelectedValueChanged);
            // 
            // cboOrderDate
            // 
            this.cboOrderDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrderDate.FormattingEnabled = true;
            this.cboOrderDate.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cboOrderDate.Location = new System.Drawing.Point(172, 33);
            this.cboOrderDate.Name = "cboOrderDate";
            this.cboOrderDate.Size = new System.Drawing.Size(121, 29);
            this.cboOrderDate.TabIndex = 4;
            this.cboOrderDate.SelectedValueChanged += new System.EventHandler(this.cboOrderDate_SelectedValueChanged);
            // 
            // cboSortOrder
            // 
            this.cboSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortOrder.FormattingEnabled = true;
            this.cboSortOrder.Items.AddRange(new object[] {
            "Date",
            "Price",
            "Order ID",
            "Customer ID"});
            this.cboSortOrder.Location = new System.Drawing.Point(461, 35);
            this.cboSortOrder.Name = "cboSortOrder";
            this.cboSortOrder.Size = new System.Drawing.Size(121, 29);
            this.cboSortOrder.TabIndex = 5;
            this.cboSortOrder.SelectedValueChanged += new System.EventHandler(this.cboSortOrder_SelectedValueChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(700, 36);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 23);
            this.tbSearch.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panSalesLoad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 541);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel2.Location = new System.Drawing.Point(21, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 2);
            this.panel2.TabIndex = 7;
            // 
            // panSalesLoad
            // 
            this.panSalesLoad.AutoScroll = true;
            this.panSalesLoad.Controls.Add(this.salesOrderControl2);
            this.panSalesLoad.Controls.Add(this.salesOrderControl1);
            this.panSalesLoad.Location = new System.Drawing.Point(21, 72);
            this.panSalesLoad.Name = "panSalesLoad";
            this.panSalesLoad.Size = new System.Drawing.Size(833, 448);
            this.panSalesLoad.TabIndex = 6;
            // 
            // salesOrderControl2
            // 
            this.salesOrderControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesOrderControl2.Location = new System.Drawing.Point(0, 123);
            this.salesOrderControl2.Name = "salesOrderControl2";
            this.salesOrderControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.salesOrderControl2.Size = new System.Drawing.Size(833, 123);
            this.salesOrderControl2.TabIndex = 1;
            // 
            // salesOrderControl1
            // 
            this.salesOrderControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesOrderControl1.Location = new System.Drawing.Point(0, 0);
            this.salesOrderControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 300);
            this.salesOrderControl1.Name = "salesOrderControl1";
            this.salesOrderControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.salesOrderControl1.Size = new System.Drawing.Size(833, 123);
            this.salesOrderControl1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "InstallID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "DeliveryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnSearch.Location = new System.Drawing.Point(855, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 38);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SalesVwOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cboSortOrder);
            this.Controls.Add(this.cboOrderDate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Name = "SalesVwOrderForm";
            this.Text = "VwOrderForm";
            this.Load += new System.EventHandler(this.SalesVwOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSalesLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboOrderDate;
        private System.Windows.Forms.ComboBox cboSortOrder;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panSalesLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private SalesOrderControl salesOrderControl2;
        private SalesOrderControl salesOrderControl1;
        private System.Windows.Forms.Panel panel2;
    }
}