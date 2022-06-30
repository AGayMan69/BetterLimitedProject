
namespace BetterLimitedProject.Inventory
{
    partial class InventoryAssDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAssDeliveryForm));
            this.calDeli = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEvening = new System.Windows.Forms.Button();
            this.btnAfternoon = new System.Windows.Forms.Button();
            this.btnMorning = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panDutyLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calDeli
            // 
            resources.ApplyResources(this.calDeli, "calDeli");
            this.calDeli.MaxSelectionCount = 1;
            this.calDeli.Name = "calDeli";
            this.calDeli.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEvening);
            this.panel1.Controls.Add(this.btnAfternoon);
            this.panel1.Controls.Add(this.btnMorning);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.calDeli);
            this.panel1.Name = "panel1";
            // 
            // btnEvening
            // 
            resources.ApplyResources(this.btnEvening, "btnEvening");
            this.btnEvening.FlatAppearance.BorderSize = 2;
            this.btnEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEvening.Name = "btnEvening";
            this.btnEvening.UseVisualStyleBackColor = true;
            this.btnEvening.Click += new System.EventHandler(this.btnEvening_Click);
            // 
            // btnAfternoon
            // 
            resources.ApplyResources(this.btnAfternoon, "btnAfternoon");
            this.btnAfternoon.FlatAppearance.BorderSize = 2;
            this.btnAfternoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnAfternoon.Name = "btnAfternoon";
            this.btnAfternoon.UseVisualStyleBackColor = true;
            this.btnAfternoon.Click += new System.EventHandler(this.btnAfternoon_Click);
            // 
            // btnMorning
            // 
            resources.ApplyResources(this.btnMorning, "btnMorning");
            this.btnMorning.FlatAppearance.BorderSize = 2;
            this.btnMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.UseVisualStyleBackColor = true;
            this.btnMorning.Click += new System.EventHandler(this.btnMorning_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panDutyLoader
            // 
            resources.ApplyResources(this.panDutyLoader, "panDutyLoader");
            this.panDutyLoader.BackColor = System.Drawing.Color.White;
            this.panDutyLoader.Name = "panDutyLoader";
            // 
            // InventoryAssDeliveryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panDutyLoader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryAssDeliveryForm";
            this.Load += new System.EventHandler(this.InventoryAssDeliveryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calDeli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEvening;
        private System.Windows.Forms.Button btnAfternoon;
        private System.Windows.Forms.Button btnMorning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panDutyLoader;
    }
}