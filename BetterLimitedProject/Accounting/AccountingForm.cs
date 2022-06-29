using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimitedProject.Accounting;

namespace BetterLimitedProject
{
    public partial class AccountingForm : Form
    {
        private Button[] menulist;

        public AccountingForm()
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

        private void AccountingForm_Load(object sender, EventArgs e)
        {

            menulist = new[] {btnVwOrder, btnVwGood, btnDashBoard} ;
            menu_Navigate(btnVwOrder);
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.logout_icon, new Size(16,16));
            clearSubformLoader();
            AccountingVwOrderForm hmfrm = new AccountingVwOrderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }


        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnDashBoard);
            clearSubformLoader();
            AccountingDashBoardForm dashBoardForm = new AccountingDashBoardForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(dashBoardForm);
        }

        private void btnVwOrder_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwOrder);
            clearSubformLoader();
            AccountingVwOrderForm vwOrderForm = new AccountingVwOrderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwOrderForm);
        }

        private void btnVwGood_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwGood);
            clearSubformLoader();
            Purchase.PurchaseVwGoodRecievedForm vwGoodForm = new Purchase.PurchaseVwGoodRecievedForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwGoodForm);
        }
    }
}
