using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryEditStockForm : Form
    {
        internal int productID;
        public InventoryEditStockForm()
        {
            InitializeComponent();
        }

        private void InventoryEditStockForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var productResult = (from proRec in betterDB.products
                                     where proRec.product_ID == productID
                                     select proRec).AsNoTracking().FirstOrDefault();
                // loading product image
                MemoryStream ms = new MemoryStream(productResult.product_image);
                pbProduct.Image = Image.FromStream(ms);
                tbProductName.Text = productResult.name;
                tbPrice.Text = productResult.price.ToString();

                var cateResult = (from cateRec in betterDB.categories
                                  select cateRec);

                cboCategory.Items.Clear();
                foreach (var cate in cateResult)
                {
                    cboCategory.Items.Add(cate.category_name);
                }

                cboCategory.SelectedIndex = productResult.category_ID - 1;
                nupRestockLevel.Value = productResult.irestock_level;
                cbPhaseout.Checked = (productResult.phaseout_stat == 1) ? true : false;

                var inventoryStockResult = (from invenStockRec in betterDB.warehouse_product
                                   where invenStockRec.warehouse_ID == 1
                                         && invenStockRec.product_ID == productID
                                   select invenStockRec).AsNoTracking().FirstOrDefault();

                tbStock.Text = inventoryStockResult.qty.ToString();
                lblStore.Text = (inventoryStockResult.warehouse_ID == 1) ? "Kowloon" : "Guangdong";
                lblAddress.Text = inventoryStockResult.warehouse.address;
                lblRestockDate.Text = inventoryStockResult.store_date.ToString();
                lblZipCode.Text = inventoryStockResult.warehouse.zip_code.ToString();

                tbSector.Text = inventoryStockResult.sector_ID.ToString();
                tbStock.Text = inventoryStockResult.qty.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text == "")
            {
                MessageBox.Show("Name can not be empty!!");
                return;
            }

            if (tbSector.Text == "")
            {
                MessageBox.Show("Please input sector!");
                return;
            }
            int sector;
            try
            {
                sector = Int32.Parse(tbSector.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid sector");
                return;
            }

            if (sector < 1 || sector > 200)
            {
                MessageBox.Show("Invalid sector");
                return;
            }
            if (tbStock.Text == "")
            {
                MessageBox.Show("Please input stock!!");
                return;
            }
            int stock;
            try
            {
                stock = Int32.Parse(tbStock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid stock");
                return;
            }

            if (stock < 1 || stock > 200)
            {
                MessageBox.Show("Invalid stock");
                return;
            }

            // Update the stockline
            using (var betterDB = new betterlimitedEntities())
            {
                var productResult = (from proRec in betterDB.products
                    where proRec.product_ID == productID
                    select proRec).FirstOrDefault();
                productResult.name = tbProductName.Text;
                productResult.irestock_level = (int)nupRestockLevel.Value;
                productResult.category_ID = cboCategory.SelectedIndex + 1;
                using (var ms = new MemoryStream())
                {
                    pbProduct.Image.Save(ms, pbProduct.Image.RawFormat);
                    productResult.product_image = ms.ToArray();
                }
                var invenstoryStockResult = (from invenStockRec in betterDB.warehouse_product
                    where invenStockRec.product_ID == productID
                          && invenStockRec.warehouse_ID == 1
                    select invenStockRec).FirstOrDefault();
                invenstoryStockResult.qty = stock;
                invenstoryStockResult.sector_ID = sector;
                invenstoryStockResult.store_date = DateTime.Now;

                betterDB.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
