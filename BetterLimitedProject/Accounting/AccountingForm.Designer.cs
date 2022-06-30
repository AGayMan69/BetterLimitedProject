
namespace BetterLimitedProject
{
    partial class AccountingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingForm));
            this.panSubFormLoader = new System.Windows.Forms.Panel();
            this.panSide = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panNavHightLight = new System.Windows.Forms.Panel();
            this.btnVwGood = new System.Windows.Forms.Button();
            this.btnVwOrder = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.panNavHightLight);
            this.panelMenu.Controls.Add(this.btnVwGood);
            this.panelMenu.Controls.Add(this.btnVwOrder);
            this.panelMenu.Controls.Add(this.btnDashBoard);
            this.panelMenu.Name = "panelMenu";
            // 
            // panNavHightLight
            // 
            resources.ApplyResources(this.panNavHightLight, "panNavHightLight");
            this.panNavHightLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.panNavHightLight.Name = "panNavHightLight";
            // 
            // btnVwGood
            // 
            resources.ApplyResources(this.btnVwGood, "btnVwGood");
            this.btnVwGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwGood.FlatAppearance.BorderSize = 0;
            this.btnVwGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwGood.Name = "btnVwGood";
            this.btnVwGood.UseVisualStyleBackColor = false;
            this.btnVwGood.Click += new System.EventHandler(this.btnVwGood_Click);
            // 
            // btnVwOrder
            // 
            resources.ApplyResources(this.btnVwOrder, "btnVwOrder");
            this.btnVwOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwOrder.FlatAppearance.BorderSize = 0;
            this.btnVwOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwOrder.Name = "btnVwOrder";
            this.btnVwOrder.UseVisualStyleBackColor = false;
            this.btnVwOrder.Click += new System.EventHandler(this.btnVwOrder_Click);
            // 
            // btnDashBoard
            // 
            resources.ApplyResources(this.btnDashBoard, "btnDashBoard");
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
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
            // AccountingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panSubFormLoader);
            this.Controls.Add(this.panSide);
            this.Name = "AccountingForm";
            this.Load += new System.EventHandler(this.AccountingForm_Load);
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
        private System.Windows.Forms.Button btnVwOrder;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVwGood;
    }
}