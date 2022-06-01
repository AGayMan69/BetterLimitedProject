
namespace BetterLimitedProject
{
    partial class Sales
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
            this.panSide = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panLogo = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnVwOrder = new System.Windows.Forms.Button();
            this.btnCreaOrder = new System.Windows.Forms.Button();
            this.btnPayReser = new System.Windows.Forms.Button();
            this.btnVwStock = new System.Windows.Forms.Button();
            this.panSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.panSide.TabIndex = 3;
            this.panSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
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
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnVwStock);
            this.panelMenu.Controls.Add(this.btnPayReser);
            this.panelMenu.Controls.Add(this.btnCreaOrder);
            this.panelMenu.Controls.Add(this.btnVwOrder);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 140);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(314, 450);
            this.panelMenu.TabIndex = 44;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
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
            // 
            // btnVwOrder
            // 
            this.btnVwOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.btnVwOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVwOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVwOrder.FlatAppearance.BorderSize = 0;
            this.btnVwOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVwOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnVwOrder.Location = new System.Drawing.Point(0, 65);
            this.btnVwOrder.Name = "btnVwOrder";
            this.btnVwOrder.Size = new System.Drawing.Size(314, 65);
            this.btnVwOrder.TabIndex = 46;
            this.btnVwOrder.Text = "View Order";
            this.btnVwOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVwOrder.UseVisualStyleBackColor = false;
            // 
            // btnCreaOrder
            // 
            this.btnCreaOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.btnCreaOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreaOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreaOrder.FlatAppearance.BorderSize = 0;
            this.btnCreaOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnCreaOrder.Location = new System.Drawing.Point(0, 130);
            this.btnCreaOrder.Name = "btnCreaOrder";
            this.btnCreaOrder.Size = new System.Drawing.Size(314, 65);
            this.btnCreaOrder.TabIndex = 47;
            this.btnCreaOrder.Text = "Create Order";
            this.btnCreaOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreaOrder.UseVisualStyleBackColor = false;
            // 
            // btnPayReser
            // 
            this.btnPayReser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.btnPayReser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPayReser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayReser.FlatAppearance.BorderSize = 0;
            this.btnPayReser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayReser.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayReser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnPayReser.Location = new System.Drawing.Point(0, 195);
            this.btnPayReser.Name = "btnPayReser";
            this.btnPayReser.Size = new System.Drawing.Size(314, 65);
            this.btnPayReser.TabIndex = 48;
            this.btnPayReser.Text = "Pay Reservation";
            this.btnPayReser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayReser.UseVisualStyleBackColor = false;
            // 
            // btnVwStock
            // 
            this.btnVwStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.btnVwStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVwStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVwStock.FlatAppearance.BorderSize = 0;
            this.btnVwStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVwStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.btnVwStock.Location = new System.Drawing.Point(0, 260);
            this.btnVwStock.Name = "btnVwStock";
            this.btnVwStock.Size = new System.Drawing.Size(314, 65);
            this.btnVwStock.TabIndex = 49;
            this.btnVwStock.Text = "View Stock";
            this.btnVwStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVwStock.UseVisualStyleBackColor = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panSide);
            this.Name = "Sales";
            this.Text = "Sales";
            this.panSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panSide;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPayReser;
        private System.Windows.Forms.Button btnCreaOrder;
        private System.Windows.Forms.Button btnVwOrder;
        private System.Windows.Forms.Button btnVwStock;
    }
}