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

namespace BetterLimitedProject.Sales
{
    public partial class SalesRestockForm : Form
    {
        internal byte[] imageBlob;
        internal string name;
        internal DateTime restockTime;
        internal int reStockAmount;


        public SalesRestockForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            reStockAmount = (int) nudRestockAmount.Value;
            if (reStockAmount != 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please input restock amount!!");
            }
        }

        private void SalesRestockForm_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(imageBlob);
            pbProduct.Image = Image.FromStream(ms);
            lblProduct.Text = name;
            lblLastRestock.Text = $"Last Restock : {restockTime.ToString()}";
        }
    }
}
