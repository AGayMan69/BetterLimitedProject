
namespace BetterLimitedProject.Purchase
{
    partial class PurchaseVwGoodRecievedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseVwGoodRecievedForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlReceiveGDLoader = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pnlReceiveGDLoader);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Name = "panel3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Name = "label11";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel4.Name = "panel4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // pnlReceiveGDLoader
            // 
            resources.ApplyResources(this.pnlReceiveGDLoader, "pnlReceiveGDLoader");
            this.pnlReceiveGDLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlReceiveGDLoader.Name = "pnlReceiveGDLoader";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cboDate
            // 
            resources.ApplyResources(this.cboDate, "cboDate");
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            resources.GetString("cboDate.Items"),
            resources.GetString("cboDate.Items1"),
            resources.GetString("cboDate.Items2"),
            resources.GetString("cboDate.Items3")});
            this.cboDate.Name = "cboDate";
            this.cboDate.SelectedValueChanged += new System.EventHandler(this.cboDate_SelectedValueChanged);
            // 
            // PurchaseVwGoodRecievedForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Name = "PurchaseVwGoodRecievedForm";
            this.Load += new System.EventHandler(this.PurchaseVwGoodRecievedForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlReceiveGDLoader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDate;
    }
}