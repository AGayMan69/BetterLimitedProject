using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimitedProject
{
    public partial class ImageTestingForm : Form
    {
        private string fileName;
        private int uploadID;

        public ImageTestingForm()
        {
            InitializeComponent();
        }

        private void ImageTestingForm_Load(object sender, EventArgs e)
        {
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            using (var betterDb = new betterlimitedEntities()) 
            {
                var productImage = (from row in betterDb.products
                    select row).FirstOrDefault();
                byte[] imageData;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                productImage.product_image = imageData;
                betterDb.SaveChanges();
                MessageBox.Show("Upload successfully");
            }
        }

        private void pbTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Image files | *.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                fileName = openfile.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            using (var betterDb = new betterlimitedEntities())
            {
                var productImage = (from row in betterDb.products
                    where row.product_ID.Equals(1)
                    select row).FirstOrDefault();
                using (MemoryStream ms = new MemoryStream(productImage.product_image))
                {
                    Image bro  = Image.FromStream(ms, false, true);
                    pbTest.Image = bro;
                }
            }

            //string constr = "SERVER=127.0.01;DATABASE=test;UID=root;PASSWORD=;";
            //MySqlConnection conn = new MySqlConnection(constr);
            //conn.Open();

            //MySqlCommand cmd = new MySqlCommand("Select * from product where product_ID = '1'", conn);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    byte[] img = (byte[])(reader["product_image"]);
            //    MemoryStream ms = new MemoryStream(img);
            //    Image image = Image.FromStream(ms);
            //    pbTest.Image = image;
            //}
            //else
            //{
            //    MessageBox.Show("image not found");
            //}
        }
    }
}
