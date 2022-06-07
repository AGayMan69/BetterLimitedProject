using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Sales
{
    public partial class SalesEditStockForm : Form
    {
        internal int productID;
        public SalesEditStockForm()
        {
            InitializeComponent();
        }

        private void SalesEditStockForm_Load(object sender, EventArgs e)
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
                nupRestockLevel.Value = productResult.restock_level;
                cbPhaseout.Checked = (productResult.phaseout_stat == 1) ? true : false;

                var stockResult = (from stockRec in betterDB.retail_store_product
                                   where stockRec.store_ID == 1
                                         && stockRec.product_ID == productID
                                   select stockRec).AsNoTracking().FirstOrDefault();

                tbStock.Text = stockResult.qty.ToString();
                lblStore.Text = (stockResult.store_ID == 1) ? "Kowloon" : "Tsuen Wan";
                lblAddress.Text = stockResult.retail_store.address;
                lblRestockDate.Text = stockResult.store_date.ToString();

                tbSector.Text = stockResult.sector_ID.ToString();
                tbStock.Text = stockResult.qty.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text == "")
            {
                MessageBox.Show("Name can not be empty!!");
                return;
            }

            if (tbPrice.Text == "")
            {
                MessageBox.Show("Please input a price!");
                return;
            }

            int price;
            try
            {
                price = Int32.Parse(tbPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid price");
                return;
            }

            if (price < 1)
            {
                MessageBox.Show("Invalid price");
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
                productResult.price = price;
                productResult.restock_level = (int)nupRestockLevel.Value;
                productResult.category_ID = cboCategory.SelectedIndex + 1;
                using (var ms = new MemoryStream())
                {
                    pbProduct.Image.Save(ms, pbProduct.Image.RawFormat);
                    productResult.product_image = ms.ToArray();
                }
                productResult.phaseout_stat = (cbPhaseout.Checked) ? 1 : 0;
                var stockResult = (from stockRec in betterDB.retail_store_product
                    where stockRec.product_ID == productID
                          && stockRec.store_ID == 1
                    select stockRec).FirstOrDefault();
                stockResult.qty = stock;
                stockResult.sector_ID = sector;
                stockResult.store_date = DateTime.Now;

                betterDB.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pbProduct_DoubleClick(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Image |*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbProduct.Image = Image.FromFile(openFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Image");
                    return;
                }
            }
        }
    }
}
