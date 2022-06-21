
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // cboType
            // 
            resources.ApplyResources(this.cboType, "cboType");
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            resources.GetString("cboType.Items"),
            resources.GetString("cboType.Items1"),
            resources.GetString("cboType.Items2")});
            this.cboType.Name = "cboType";
            this.cboType.SelectedValueChanged += new System.EventHandler(this.cboType_SelectedValueChanged);
            // 
            // cboOrderDate
            // 
            resources.ApplyResources(this.cboOrderDate, "cboOrderDate");
            this.cboOrderDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderDate.FormattingEnabled = true;
            this.cboOrderDate.Items.AddRange(new object[] {
            resources.GetString("cboOrderDate.Items"),
            resources.GetString("cboOrderDate.Items1"),
            resources.GetString("cboOrderDate.Items2"),
            resources.GetString("cboOrderDate.Items3")});
            this.cboOrderDate.Name = "cboOrderDate";
            this.cboOrderDate.SelectedValueChanged += new System.EventHandler(this.cboOrderDate_SelectedValueChanged);
            // 
            // cboSortOrder
            // 
            resources.ApplyResources(this.cboSortOrder, "cboSortOrder");
            this.cboSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortOrder.FormattingEnabled = true;
            this.cboSortOrder.Items.AddRange(new object[] {
            resources.GetString("cboSortOrder.Items"),
            resources.GetString("cboSortOrder.Items1"),
            resources.GetString("cboSortOrder.Items2"),
            resources.GetString("cboSortOrder.Items3")});
            this.cboSortOrder.Name = "cboSortOrder";
            this.cboSortOrder.SelectedValueChanged += new System.EventHandler(this.cboSortOrder_SelectedValueChanged);
            // 
            // tbSearch
            // 
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panSalesLoad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel2.Name = "panel2";
            // 
            // panSalesLoad
            // 
            resources.ApplyResources(this.panSalesLoad, "panSalesLoad");
            this.panSalesLoad.Controls.Add(this.salesOrderControl2);
            this.panSalesLoad.Controls.Add(this.salesOrderControl1);
            this.panSalesLoad.Name = "panSalesLoad";
            // 
            // salesOrderControl2
            // 
            resources.ApplyResources(this.salesOrderControl2, "salesOrderControl2");
            this.salesOrderControl2.Name = "salesOrderControl2";
            // 
            // salesOrderControl1
            // 
            resources.ApplyResources(this.salesOrderControl1, "salesOrderControl1");
            this.salesOrderControl1.Name = "salesOrderControl1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SalesVwOrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cboSortOrder);
            this.Controls.Add(this.cboOrderDate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Name = "SalesVwOrderForm";
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