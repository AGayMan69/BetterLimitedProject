
namespace BetterLimitedProject
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.panSubFormLoader = new System.Windows.Forms.Panel();
            this.panSide = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVwPurchase = new System.Windows.Forms.Button();
            this.btnVwStock = new System.Windows.Forms.Button();
            this.panNavHightLight = new System.Windows.Forms.Panel();
            this.btnArraDelivery = new System.Windows.Forms.Button();
            this.btnVwDelivery = new System.Windows.Forms.Button();
            this.panLogo = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panSide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panSubFormLoader
            // 
            resources.ApplyResources(this.panSubFormLoader, "panSubFormLoader");
            this.panSubFormLoader.Name = "panSubFormLoader";
            // 
            // panSide
            // 
            resources.ApplyResources(this.panSide, "panSide");
            this.panSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panSide.Controls.Add(this.panelMenu);
            this.panSide.Controls.Add(this.panLogo);
            this.panSide.Controls.Add(this.btnLogout);
            this.panSide.Name = "panSide";
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Controls.Add(this.btnVwPurchase);
            this.panelMenu.Controls.Add(this.btnVwStock);
            this.panelMenu.Controls.Add(this.panNavHightLight);
            this.panelMenu.Controls.Add(this.btnArraDelivery);
            this.panelMenu.Controls.Add(this.btnVwDelivery);
            this.panelMenu.Name = "panelMenu";
            // 
            // btnVwPurchase
            // 
            resources.ApplyResources(this.btnVwPurchase, "btnVwPurchase");
            this.btnVwPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwPurchase.FlatAppearance.BorderSize = 0;
            this.btnVwPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwPurchase.Name = "btnVwPurchase";
            this.btnVwPurchase.UseVisualStyleBackColor = false;
            this.btnVwPurchase.Click += new System.EventHandler(this.btnVwPurchase_Click);
            // 
            // btnVwStock
            // 
            resources.ApplyResources(this.btnVwStock, "btnVwStock");
            this.btnVwStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwStock.FlatAppearance.BorderSize = 0;
            this.btnVwStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwStock.Name = "btnVwStock";
            this.btnVwStock.UseVisualStyleBackColor = false;
            this.btnVwStock.Click += new System.EventHandler(this.btnVwStock_Click);
            // 
            // panNavHightLight
            // 
            resources.ApplyResources(this.panNavHightLight, "panNavHightLight");
            this.panNavHightLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.panNavHightLight.Name = "panNavHightLight";
            // 
            // btnArraDelivery
            // 
            resources.ApplyResources(this.btnArraDelivery, "btnArraDelivery");
            this.btnArraDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnArraDelivery.FlatAppearance.BorderSize = 0;
            this.btnArraDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnArraDelivery.Name = "btnArraDelivery";
            this.btnArraDelivery.UseVisualStyleBackColor = false;
            this.btnArraDelivery.Click += new System.EventHandler(this.btnArraDelivery_Click);
            // 
            // btnVwDelivery
            // 
            resources.ApplyResources(this.btnVwDelivery, "btnVwDelivery");
            this.btnVwDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwDelivery.FlatAppearance.BorderSize = 0;
            this.btnVwDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwDelivery.Name = "btnVwDelivery";
            this.btnVwDelivery.UseVisualStyleBackColor = false;
            this.btnVwDelivery.Click += new System.EventHandler(this.btnVwDelivery_Click);
            // 
            // panLogo
            // 
            resources.ApplyResources(this.panLogo, "panLogo");
            this.panLogo.Controls.Add(this.ptbLogo);
            this.panLogo.Name = "panLogo";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ptbLogo
            // 
            resources.ApplyResources(this.ptbLogo, "ptbLogo");
            this.ptbLogo.Image = global::BetterLimitedProject.Properties.Resources.logo;
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.TabStop = false;
            // 
            // InventoryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panSubFormLoader);
            this.Controls.Add(this.panSide);
            this.Name = "InventoryForm";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panSide.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSubFormLoader;
        private System.Windows.Forms.Panel panSide;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panNavHightLight;
        private System.Windows.Forms.Button btnArraDelivery;
        private System.Windows.Forms.Button btnVwDelivery;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVwStock;
        private System.Windows.Forms.Button btnVwPurchase;
    }
}