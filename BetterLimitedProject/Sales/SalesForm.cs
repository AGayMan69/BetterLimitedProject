using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimitedProject.Sales;

namespace BetterLimitedProject
{
    public partial class SalesForm : Form
    {
        private Button[] menulist;

        public SalesForm()
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

        private void Sales_Load(object sender, EventArgs e)
        {
            menulist = new[] {btnHome, btnVwOrder, btnPayReser, btnCreaOrder, btnVwStock, btnDefect} ;
            menu_Navigate(btnHome);
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.logout_icon, new Size(16,16));
            clearSubformLoader();
            SalesVwStockForm hmfrm = new SalesVwStockForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnHome);
            clearSubformLoader();
            SalesHomeForm hmfrm = new SalesHomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnVwOrder_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwOrder);
            clearSubformLoader();
            SalesVwOrderForm vwOrderForm = new SalesVwOrderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwOrderForm);
        }

        private void btnCreaOrder_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnCreaOrder);
            clearSubformLoader();
            SalesCreaOrderForm creaOrderForm = new SalesCreaOrderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(creaOrderForm);
        }

        private void btnPayReser_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnPayReser);
            clearSubformLoader();
            SalesPayReserForm payReserForm = new SalesPayReserForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(payReserForm);
        }

        private void btnVwStock_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwStock);
            clearSubformLoader();
            SalesVwStockForm vwStockForm = new SalesVwStockForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwStockForm);
        }

        private void btnDefect_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnDefect);
            clearSubformLoader();
            SalesDefectForm defectForm = new SalesDefectForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(defectForm);
        }
    }
}
