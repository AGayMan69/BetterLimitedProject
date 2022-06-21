using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Sales
{
    public partial class SalesDefectForm : Form
    {

        public SalesDefectForm()
        {
            InitializeComponent();
        }

        private void SalesDefectForm_Load(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var productResults = from itemRec in betterDB.products
                                     select itemRec.name;
                foreach (var item in productResults)
                {
                    cboProduct.Items.Add(item);
                }

                cboProduct.SelectedIndex = 0;
                cboTier.SelectedIndex = 0;
                tbDescription.Text = "";
                nudQty.Value = 1;
            }
        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlProduct.Controls.Clear();
            if (cboProduct.SelectedIndex == 0)
            {
                return;
            }
            SalesDefectItemControl itemControl = new SalesDefectItemControl(){Dock = DockStyle.Fill};
            itemControl.productName = cboProduct.SelectedItem.ToString();
            pnlProduct.Controls.Add(itemControl);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an item!!");
                return;
            }

            if (tbDescription.Text == "")
            {
                MessageBox.Show("Please fill in the description");
                return;
            }

            MessageBox.Show($"Name: {cboProduct.SelectedIndex}");
            MessageBox.Show($"Description: {tbDescription.Text}");
            MessageBox.Show($"Qty: {nudQty.Value}");
            MessageBox.Show($"Tier: {cboTier.SelectedIndex +1}");
            using (var betterDB = new betterlimitedEntities())
            {
                // Generating new delivery id
                string strYear = DateTime.Now.Year.ToString();
                int year = Int32.Parse(strYear.Remove(0, 2));
                int tempID = year * (int)Math.Pow(10, 5);

                int newDeliveryID;
                var latestDelivery = (from deliveryRec in betterDB.deliveries
                                      where deliveryRec.delivery_ID >= tempID
                                      orderby deliveryRec.delivery_ID descending
                                      select deliveryRec).AsNoTracking().FirstOrDefault();

                if (latestDelivery == null)
                {
                    newDeliveryID = tempID;
                }
                else
                {
                    newDeliveryID = latestDelivery.delivery_ID + 1;
                }

                MessageBox.Show($"ID: {newDeliveryID}");
                var itemweight = (from itemRec in betterDB.products
                                  where itemRec.product_ID == cboProduct.SelectedIndex
                                  select itemRec.weight).FirstOrDefault();
                delivery newDelivery = new delivery();
                newDelivery.delivery_ID = newDeliveryID;
                newDelivery.type = 4;
                newDelivery.status = "Pending";
                newDelivery.creation_time = DateTime.Now;
                newDelivery.net_weight = itemweight;
                defect newDefect = new defect();
                int newDefectID;
                var latestDefect = (from defectRec in betterDB.defects
                                      where defectRec.defect_ID >= tempID
                                      orderby defectRec.defect_ID descending
                                      select defectRec).AsNoTracking().FirstOrDefault();

                if (latestDefect == null)
                {
                    newDefectID = tempID;
                }
                else
                {
                    newDefectID = latestDefect.defect_ID + 1;
                }

                newDefect.defect_ID = newDefectID;
                newDefect.delivery_ID = newDeliveryID;
                newDefect.product_ID = cboProduct.SelectedIndex;
                newDefect.description = tbDescription.Text;
                newDefect.qty = Convert.ToInt32(nudQty.Value);
                newDefect.damage_tier = Int32.Parse(cboTier.SelectedItem.ToString());

                betterDB.deliveries.Add(newDelivery);
                betterDB.defects.Add(newDefect);
                betterDB.SaveChanges();
                SalesDefectForm_Load(null, EventArgs.Empty);
            }
        }
    }
}
