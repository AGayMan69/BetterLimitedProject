
namespace BetterLimitedProject
{
    partial class PurchaseForm
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
            this.panSubFormLoader = new System.Windows.Forms.Panel();
            this.panSide = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panNavHightLight = new System.Windows.Forms.Panel();
            this.btnHdlDefect = new System.Windows.Forms.Button();
            this.btnVwPurchase = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panLogo = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panSide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panSubFormLoader
            // 
            this.panSubFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSubFormLoader.Location = new System.Drawing.Point(314, 0);
            this.panSubFormLoader.Name = "panSubFormLoader";
            this.panSubFormLoader.Size = new System.Drawing.Size(950, 681);
            this.panSubFormLoader.TabIndex = 8;
            // 
            // panSide
            // 
            this.panSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panSide.Controls.Add(this.panelMenu);
            this.panSide.Controls.Add(this.panLogo);
            this.panSide.Controls.Add(this.btnLogout);
            this.panSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSide.Location = new System.Drawing.Point(0, 0);
            this.panSide.Name = "panSide";
            this.panSide.Size = new System.Drawing.Size(314, 681);
            this.panSide.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panNavHightLight);
            this.panelMenu.Controls.Add(this.btnHdlDefect);
            this.panelMenu.Controls.Add(this.btnVwPurchase);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 140);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(314, 450);
            this.panelMenu.TabIndex = 44;
            // 
            // panNavHightLight
            // 
            this.panNavHightLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.panNavHightLight.Location = new System.Drawing.Point(0, 6);
            this.panNavHightLight.Name = "panNavHightLight";
            this.panNavHightLight.Size = new System.Drawing.Size(10, 65);
            this.panNavHightLight.TabIndex = 4;
            // 
            // btnHdlDefect
            // 
            this.btnHdlDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnHdlDefect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHdlDefect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHdlDefect.FlatAppearance.BorderSize = 0;
            this.btnHdlDefect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHdlDefect.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdlDefect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnHdlDefect.Location = new System.Drawing.Point(0, 130);
            this.btnHdlDefect.Name = "btnHdlDefect";
            this.btnHdlDefect.Size = new System.Drawing.Size(314, 65);
            this.btnHdlDefect.TabIndex = 47;
            this.btnHdlDefect.Text = "Handle Defect";
            this.btnHdlDefect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHdlDefect.UseVisualStyleBackColor = false;
            this.btnHdlDefect.Click += new System.EventHandler(this.btnHdlDefect_Click);
            // 
            // btnVwPurchase
            // 
            this.btnVwPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnVwPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVwPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVwPurchase.FlatAppearance.BorderSize = 0;
            this.btnVwPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVwPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnVwPurchase.Location = new System.Drawing.Point(0, 65);
            this.btnVwPurchase.Name = "btnVwPurchase";
            this.btnVwPurchase.Size = new System.Drawing.Size(314, 65);
            this.btnVwPurchase.TabIndex = 46;
            this.btnVwPurchase.Text = "View Purchase Order";
            this.btnVwPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVwPurchase.UseVisualStyleBackColor = false;
            this.btnVwPurchase.Click += new System.EventHandler(this.btnVwPurchase_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(314, 65);
            this.btnHome.TabIndex = 45;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panLogo
            // 
            this.panLogo.Controls.Add(this.ptbLogo);
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Padding = new System.Windows.Forms.Padding(30);
            this.panLogo.Size = new System.Drawing.Size(314, 140);
            this.panLogo.TabIndex = 43;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Image = global::BetterLimitedProject.Properties.Resources.logo;
            this.ptbLogo.Location = new System.Drawing.Point(30, 30);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(254, 80);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(314, 91);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panSubFormLoader);
            this.Controls.Add(this.panSide);
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
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
        private System.Windows.Forms.Button btnHdlDefect;
        private System.Windows.Forms.Button btnVwPurchase;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLogout;
    }
}