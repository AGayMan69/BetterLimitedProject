
namespace BetterLimitedProject.Sales
{
    partial class SalesCreaOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCreaOrderForm));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpanProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBuyOrder = new System.Windows.Forms.Label();
            this.panOrderLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpShoppingCart = new System.Windows.Forms.TabPage();
            this.tpOption = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBackCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpShoppingCart.SuspendLayout();
            this.tpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.Black;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnCheckout.Location = new System.Drawing.Point(820, 582);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(108, 49);
            this.btnCheckout.TabIndex = 34;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 5;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(696, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 49);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.lblPrice.Location = new System.Drawing.Point(210, 8);
            this.lblPrice.MaximumSize = new System.Drawing.Size(250, 24);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(102, 24);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "$343";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(616, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 44);
            this.panel1.TabIndex = 39;
            // 
            // flpanProduct
            // 
            this.flpanProduct.AutoScroll = true;
            this.flpanProduct.BackColor = System.Drawing.Color.White;
            this.flpanProduct.Location = new System.Drawing.Point(22, 68);
            this.flpanProduct.Name = "flpanProduct";
            this.flpanProduct.Size = new System.Drawing.Size(568, 565);
            this.flpanProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Location = new System.Drawing.Point(131, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSearch.Size = new System.Drawing.Size(164, 29);
            this.tbSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnSearch.Location = new System.Drawing.Point(322, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 38);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "-- Select Category --"});
            this.cboCategory.Location = new System.Drawing.Point(404, 22);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(186, 29);
            this.cboCategory.TabIndex = 32;
            this.cboCategory.SelectedValueChanged += new System.EventHandler(this.cboCategory_SelectedValueChanged);
            // 
            // lblBuyOrder
            // 
            this.lblBuyOrder.AutoSize = true;
            this.lblBuyOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyOrder.ForeColor = System.Drawing.Color.Black;
            this.lblBuyOrder.Location = new System.Drawing.Point(691, 29);
            this.lblBuyOrder.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblBuyOrder.Name = "lblBuyOrder";
            this.lblBuyOrder.Size = new System.Drawing.Size(182, 25);
            this.lblBuyOrder.TabIndex = 33;
            this.lblBuyOrder.Text = "Order ID: 190000";
            // 
            // panOrderLine
            // 
            this.panOrderLine.AutoScroll = true;
            this.panOrderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panOrderLine.Location = new System.Drawing.Point(616, 66);
            this.panOrderLine.Name = "panOrderLine";
            this.panOrderLine.Size = new System.Drawing.Size(317, 460);
            this.panOrderLine.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.MaximumSize = new System.Drawing.Size(250, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tpShoppingCart);
            this.tabControl.Controls.Add(this.tpOption);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(934, 642);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 40;
            // 
            // tpShoppingCart
            // 
            this.tpShoppingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tpShoppingCart.Controls.Add(this.label1);
            this.tpShoppingCart.Controls.Add(this.tbSearch);
            this.tpShoppingCart.Controls.Add(this.panOrderLine);
            this.tpShoppingCart.Controls.Add(this.btnClear);
            this.tpShoppingCart.Controls.Add(this.btnSearch);
            this.tpShoppingCart.Controls.Add(this.btnCheckout);
            this.tpShoppingCart.Controls.Add(this.flpanProduct);
            this.tpShoppingCart.Controls.Add(this.lblBuyOrder);
            this.tpShoppingCart.Controls.Add(this.cboCategory);
            this.tpShoppingCart.Controls.Add(this.panel1);
            this.tpShoppingCart.Location = new System.Drawing.Point(4, 5);
            this.tpShoppingCart.Margin = new System.Windows.Forms.Padding(0);
            this.tpShoppingCart.Name = "tpShoppingCart";
            this.tpShoppingCart.Padding = new System.Windows.Forms.Padding(3);
            this.tpShoppingCart.Size = new System.Drawing.Size(926, 633);
            this.tpShoppingCart.TabIndex = 0;
            // 
            // tpOption
            // 
            this.tpOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tpOption.Controls.Add(this.btnBackCart);
            this.tpOption.Controls.Add(this.button2);
            this.tpOption.Controls.Add(this.button1);
            this.tpOption.Controls.Add(this.button3);
            this.tpOption.Location = new System.Drawing.Point(4, 5);
            this.tpOption.Name = "tpOption";
            this.tpOption.Padding = new System.Windows.Forms.Padding(3);
            this.tpOption.Size = new System.Drawing.Size(926, 633);
            this.tpOption.TabIndex = 1;
            this.tpOption.Text = "tabPage2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(52)))), ((int)(((byte)(19)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BetterLimitedProject.Properties.Resources.deposit;
            this.button2.Location = new System.Drawing.Point(641, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 433);
            this.button2.TabIndex = 40;
            this.button2.Text = "Deposit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(118)))), ((int)(((byte)(19)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BetterLimitedProject.Properties.Resources.delivery;
            this.button1.Location = new System.Drawing.Point(333, 117);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(244, 433);
            this.button1.TabIndex = 39;
            this.button1.Text = "Delivery";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(203)))), ((int)(((byte)(126)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::BetterLimitedProject.Properties.Resources.customerpickup;
            this.button3.Location = new System.Drawing.Point(31, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 433);
            this.button3.TabIndex = 38;
            this.button3.Text = "Customer Pickup";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBackCart
            // 
            this.btnBackCart.AutoSize = true;
            this.btnBackCart.BackColor = System.Drawing.Color.Transparent;
            this.btnBackCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackCart.FlatAppearance.BorderSize = 3;
            this.btnBackCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(52)))), ((int)(((byte)(19)))));
            this.btnBackCart.Location = new System.Drawing.Point(32, 31);
            this.btnBackCart.Name = "btnBackCart";
            this.btnBackCart.Size = new System.Drawing.Size(210, 51);
            this.btnBackCart.TabIndex = 41;
            this.btnBackCart.Text = "Back to Shopping Cart";
            this.btnBackCart.UseVisualStyleBackColor = false;
            this.btnBackCart.Click += new System.EventHandler(this.btnBackCart_Click);
            // 
            // SalesCreaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 642);
            this.Controls.Add(this.tabControl);
            this.Name = "SalesCreaOrderForm";
            this.Text = "CreaOrderForm";
            this.Load += new System.EventHandler(this.SalesCreaOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpShoppingCart.ResumeLayout(false);
            this.tpShoppingCart.PerformLayout();
            this.tpOption.ResumeLayout(false);
            this.tpOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpanProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBuyOrder;
        private System.Windows.Forms.Panel panOrderLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpShoppingCart;
        private System.Windows.Forms.TabPage tpOption;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBackCart;
    }
}