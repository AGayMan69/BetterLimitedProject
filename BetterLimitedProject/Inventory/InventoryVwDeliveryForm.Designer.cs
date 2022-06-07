
namespace BetterLimitedProject.Inventory
{
    partial class InventoryVwDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryVwDeliveryForm));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cboSortOrder = new System.Windows.Forms.ComboBox();
            this.cboOrderDate = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panDeliveryLoader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(695, 29);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 23);
            this.tbSearch.TabIndex = 37;
            // 
            // cboSortOrder
            // 
            this.cboSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortOrder.FormattingEnabled = true;
            this.cboSortOrder.Items.AddRange(new object[] {
            "Creation Date",
            "Status",
            "Delivery ID"});
            this.cboSortOrder.Location = new System.Drawing.Point(443, 23);
            this.cboSortOrder.Name = "cboSortOrder";
            this.cboSortOrder.Size = new System.Drawing.Size(129, 29);
            this.cboSortOrder.TabIndex = 36;
            this.cboSortOrder.SelectedValueChanged += new System.EventHandler(this.cboSortOrder_SelectedValueChanged);
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
            this.cboOrderDate.Location = new System.Drawing.Point(167, 23);
            this.cboOrderDate.Name = "cboOrderDate";
            this.cboOrderDate.Size = new System.Drawing.Size(121, 29);
            this.cboOrderDate.TabIndex = 35;
            this.cboOrderDate.SelectedValueChanged += new System.EventHandler(this.cboOrderDate_SelectedValueChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Customer",
            "Replenish",
            "Defect"});
            this.cboType.Location = new System.Drawing.Point(22, 23);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 29);
            this.cboType.TabIndex = 34;
            this.cboType.SelectedValueChanged += new System.EventHandler(this.cboType_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(583, 21);
            this.label2.MaximumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 27);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "sort";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panDeliveryLoader);
            this.panel1.Location = new System.Drawing.Point(22, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 537);
            this.panel1.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(540, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(387, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Creation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(287, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(200, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel2.Location = new System.Drawing.Point(21, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 2);
            this.panel2.TabIndex = 8;
            // 
            // panDeliveryLoader
            // 
            this.panDeliveryLoader.AutoScroll = true;
            this.panDeliveryLoader.Location = new System.Drawing.Point(22, 82);
            this.panDeliveryLoader.Name = "panDeliveryLoader";
            this.panDeliveryLoader.Size = new System.Drawing.Size(832, 438);
            this.panDeliveryLoader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnSearch.Location = new System.Drawing.Point(850, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 38);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // InventoryVwDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cboSortOrder);
            this.Controls.Add(this.cboOrderDate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label2);
            this.Name = "InventoryVwDeliveryForm";
            this.Text = "InventoryVwDeliveryForm";
            this.Load += new System.EventHandler(this.InventoryVwDeliveryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cboSortOrder;
        private System.Windows.Forms.ComboBox cboOrderDate;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panDeliveryLoader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}