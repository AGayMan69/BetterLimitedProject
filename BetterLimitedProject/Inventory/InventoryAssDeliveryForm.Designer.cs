
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
            this.calDeli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calDeli.Location = new System.Drawing.Point(28, 123);
            this.calDeli.MaxSelectionCount = 1;
            this.calDeli.Name = "calDeli";
            this.calDeli.TabIndex = 0;
            this.calDeli.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEvening);
            this.panel1.Controls.Add(this.btnAfternoon);
            this.panel1.Controls.Add(this.btnMorning);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.calDeli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(661, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 642);
            this.panel1.TabIndex = 1;
            // 
            // btnEvening
            // 
            this.btnEvening.FlatAppearance.BorderSize = 2;
            this.btnEvening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnEvening.Location = new System.Drawing.Point(28, 492);
            this.btnEvening.Name = "btnEvening";
            this.btnEvening.Size = new System.Drawing.Size(227, 32);
            this.btnEvening.TabIndex = 5;
            this.btnEvening.Text = "Evening";
            this.btnEvening.UseVisualStyleBackColor = true;
            this.btnEvening.Click += new System.EventHandler(this.btnEvening_Click);
            // 
            // btnAfternoon
            // 
            this.btnAfternoon.FlatAppearance.BorderSize = 2;
            this.btnAfternoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfternoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnAfternoon.Location = new System.Drawing.Point(28, 438);
            this.btnAfternoon.Name = "btnAfternoon";
            this.btnAfternoon.Size = new System.Drawing.Size(227, 32);
            this.btnAfternoon.TabIndex = 4;
            this.btnAfternoon.Text = "Afternoon";
            this.btnAfternoon.UseVisualStyleBackColor = true;
            this.btnAfternoon.Click += new System.EventHandler(this.btnAfternoon_Click);
            // 
            // btnMorning
            // 
            this.btnMorning.FlatAppearance.BorderSize = 2;
            this.btnMorning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnMorning.Location = new System.Drawing.Point(28, 384);
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.Size = new System.Drawing.Size(227, 32);
            this.btnMorning.TabIndex = 3;
            this.btnMorning.Text = "Morning";
            this.btnMorning.UseVisualStyleBackColor = true;
            this.btnMorning.Click += new System.EventHandler(this.btnMorning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(24, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Worker Duty";
            // 
            // panDutyLoader
            // 
            this.panDutyLoader.BackColor = System.Drawing.Color.White;
            this.panDutyLoader.Location = new System.Drawing.Point(51, 97);
            this.panDutyLoader.Name = "panDutyLoader";
            this.panDutyLoader.Size = new System.Drawing.Size(556, 507);
            this.panDutyLoader.TabIndex = 7;
            // 
            // InventoryAssDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 642);
            this.Controls.Add(this.panDutyLoader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryAssDeliveryForm";
            this.Text = "InventoryArraDeliveryForm";
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