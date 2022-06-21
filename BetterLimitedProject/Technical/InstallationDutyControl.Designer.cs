
namespace BetterLimitedProject.Technical
{
    partial class InstallationDutyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnAss = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblInstallation = new System.Windows.Forms.Label();
            this.lblAss = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnAss
            // 
            this.lblUnAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblUnAss.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnAss.ForeColor = System.Drawing.Color.White;
            this.lblUnAss.Image = global::BetterLimitedProject.Properties.Resources.warningicon;
            this.lblUnAss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnAss.Location = new System.Drawing.Point(5, 10);
            this.lblUnAss.Name = "lblUnAss";
            this.lblUnAss.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblUnAss.Size = new System.Drawing.Size(146, 41);
            this.lblUnAss.TabIndex = 7;
            this.lblUnAss.Text = "    Unassigned";
            this.lblUnAss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(482, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 61);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(397, 10);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 41);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblInstallation
            // 
            this.lblInstallation.AutoSize = true;
            this.lblInstallation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblInstallation.Location = new System.Drawing.Point(169, 22);
            this.lblInstallation.Name = "lblInstallation";
            this.lblInstallation.Size = new System.Drawing.Size(57, 17);
            this.lblInstallation.TabIndex = 9;
            this.lblInstallation.Text = "2200000";
            // 
            // lblAss
            // 
            this.lblAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.lblAss.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAss.ForeColor = System.Drawing.Color.White;
            this.lblAss.Image = global::BetterLimitedProject.Properties.Resources.checkicon;
            this.lblAss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAss.Location = new System.Drawing.Point(5, 10);
            this.lblAss.Name = "lblAss";
            this.lblAss.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAss.Size = new System.Drawing.Size(146, 41);
            this.lblAss.TabIndex = 8;
            this.lblAss.Text = "   Assigned";
            this.lblAss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblType.Location = new System.Drawing.Point(263, 22);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 17);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Class I";
            // 
            // InstallationDutyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblUnAss);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblInstallation);
            this.Controls.Add(this.lblAss);
            this.Name = "InstallationDutyControl";
            this.Size = new System.Drawing.Size(520, 61);
            this.Load += new System.EventHandler(this.InstallationDutyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnAss;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblInstallation;
        private System.Windows.Forms.Label lblAss;
        private System.Windows.Forms.Label lblType;
    }
}
