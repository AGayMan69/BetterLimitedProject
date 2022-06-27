using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimitedProject.Purchase;

namespace BetterLimitedProject
{
    public partial class PurchaseForm : Form
    {
        private Button[] menulist;

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void menu_Navigate(Button btn)
        {
            panNavHightLight.Height = btn.Height;
            panNavHightLight.Top = btn.Top;
            panNavHightLight.Left = btn.Left;

            btn.BackColor = Color.FromArgb(15, 17, 24);
            btn.ForeColor = Color.FromArgb(20, 227, 140);
            foreach (var menuitem in menulist)
            {
                if (!(menuitem.Equals(btn)))
                {
                    menuitem.BackColor = Color.FromArgb(22, 25, 33);
                    menuitem.ForeColor = Color.FromArgb(219, 219, 219);
                }
            }
        }

        private void clearSubformLoader()
        {
            panSubFormLoader.Controls.Clear();
        }

        private void loadSubform(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panSubFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {

            menulist = new[] {btnReorder, btnGood} ;
            menu_Navigate(btnReorder);
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.logout_icon, new Size(16,16));
            clearSubformLoader();
            PurchaseVwReorder hmfrm = new PurchaseVwReorder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnReorder);
            clearSubformLoader();
            PurchaseVwReorder hmfrm = new PurchaseVwReorder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnGood);
            clearSubformLoader();
            PurchaseVwGoodRecievedForm vwPurchaseForm = new PurchaseVwGoodRecievedForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwPurchaseForm);
        }
    }
}
