
namespace BetterLimitedProject.Sales
{
    partial class SalesRestockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRestockForm));
            this.lblProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lblLastRestock = new System.Windows.Forms.Label();
            this.nudRestockAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestockAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.lblProduct.AutoEllipsis = true;
            this.errorProvider1.SetError(this.lblProduct, resources.GetString("lblProduct.Error"));
            this.errorProvider1.SetIconAlignment(this.lblProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblProduct.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblProduct, ((int)(resources.GetObject("lblProduct.IconPadding"))));
            this.lblProduct.Name = "lblProduct";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.errorProvider1.SetError(this.menuStrip1, resources.GetString("menuStrip1.Error"));
            this.errorProvider1.SetIconAlignment(this.menuStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("menuStrip1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.menuStrip1, ((int)(resources.GetObject("menuStrip1.IconPadding"))));
            this.menuStrip1.Name = "menuStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(227)))), ((int)(((byte)(140)))));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pbProduct
            // 
            resources.ApplyResources(this.pbProduct, "pbProduct");
            this.pbProduct.BackColor = System.Drawing.Color.White;
            this.errorProvider1.SetError(this.pbProduct, resources.GetString("pbProduct.Error"));
            this.errorProvider1.SetIconAlignment(this.pbProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbProduct.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pbProduct, ((int)(resources.GetObject("pbProduct.IconPadding"))));
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.TabStop = false;
            // 
            // lblLastRestock
            // 
            resources.ApplyResources(this.lblLastRestock, "lblLastRestock");
            this.errorProvider1.SetError(this.lblLastRestock, resources.GetString("lblLastRestock.Error"));
            this.errorProvider1.SetIconAlignment(this.lblLastRestock, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLastRestock.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblLastRestock, ((int)(resources.GetObject("lblLastRestock.IconPadding"))));
            this.lblLastRestock.Name = "lblLastRestock";
            // 
            // nudRestockAmount
            // 
            resources.ApplyResources(this.nudRestockAmount, "nudRestockAmount");
            this.errorProvider1.SetError(this.nudRestockAmount, resources.GetString("nudRestockAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.nudRestockAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("nudRestockAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.nudRestockAmount, ((int)(resources.GetObject("nudRestockAmount.IconPadding"))));
            this.nudRestockAmount.Name = "nudRestockAmount";
            // 
            // SalesRestockForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.nudRestockAmount);
            this.Controls.Add(this.lblLastRestock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalesRestockForm";
            this.Load += new System.EventHandler(this.SalesRestockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestockAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLastRestock;
        private System.Windows.Forms.NumericUpDown nudRestockAmount;
    }
}