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

namespace BetterLimitedProject.Purchase
{
    public partial class PurchaseVwReorder : Form
    {
        private bool loading;
        public PurchaseVwReorder()
        {
            InitializeComponent();
        }

        private void PurchaseVwReorder_Load(object sender, EventArgs e)
        {
            loading = true;
            cboStatus.SelectedIndex = 0;
            loading = false;
            loadReorder();
        }

        internal void loadReorder()
        {
            if (loading)
            {
                return;
            }

            pnlReorderLoader.Controls.Clear();
            IQueryable<reorderControl> controlList;
            string targetStatus = cboStatus.SelectedItem.ToString();
            //MessageBox.Show(targetStatus);
            using (var betterDB = new betterlimitedEntities())
            {
                controlList = (from reorderRec in betterDB.reorders
                    where reorderRec.purchaseorders.FirstOrDefault().status.Contains(targetStatus)
                    select new reorderControl()
                    {
                       reorderID =  reorderRec.reorder_ID,
                       purchaseID = reorderRec.purchaseorders.FirstOrDefault().purchase_order_ID,
                        status = reorderRec.purchaseorders.FirstOrDefault().status,
                        creatTime = reorderRec.creation_time
                    });
                pnlReorderLoader.Hide();
                foreach (var control in controlList)
                {
                    control._parent = this;
                    control.Dock = DockStyle.Top;
                    pnlReorderLoader.Controls.Add(control);
                }
                pnlReorderLoader.Show();
            }

        }

        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            loadReorder();
        }
    }
}
