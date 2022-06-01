using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimitedProject.Inventory;

namespace BetterLimitedProject
{
    public partial class InventoryForm : Form
    {
        private Button[] menulist;

        public InventoryForm()
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            menulist = new[] { btnHome, btnVwDelivery, btnArraDelivery, btnVwStock, btnPurGood, btnRestock, btnVwReceGood };
            menu_Navigate(btnHome);
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.logout_icon, new Size(16, 16));
            clearSubformLoader();
            InventoryHomeForm hmfrm = new InventoryHomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            InventoryHomeForm hmfrm = new InventoryHomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(hmfrm);
        }

        private void btnVwDelivery_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwDelivery);
            clearSubformLoader();
            InventoryVwDeliveryForm vwDeliveryForm = new InventoryVwDeliveryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwDeliveryForm);
        }

        private void btnArraDelivery_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnArraDelivery);
            clearSubformLoader();
            InventoryArraDeliveryForm arraDeliveryForm = new InventoryArraDeliveryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(arraDeliveryForm);
        }

        private void btnVwStock_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwStock);
            clearSubformLoader();
            InventoryVwStockForm vwStockForm = new InventoryVwStockForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwStockForm);
        }

        private void btnPurGood_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnPurGood);
            clearSubformLoader();
            InventoryPurGoodForm purGoodForm = new InventoryPurGoodForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(purGoodForm);
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnRestock);
            clearSubformLoader();
            InventoryRestockForm restockForm = new InventoryRestockForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(restockForm);
        }

        private void btnVwReceGood_Click(object sender, EventArgs e)
        {
            menu_Navigate(btnVwReceGood);
            clearSubformLoader();
            InventoryVwGoodForm vwGoodForm = new InventoryVwGoodForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadSubform(vwGoodForm);
        }
    }
}
