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
    public partial class reorderControl : UserControl
    {
        internal PurchaseVwReorder _parent;
        internal int purchaseID;
        internal int reorderID;
        internal string status;
        internal DateTime creatTime;

        public reorderControl()
        {
            InitializeComponent();
        }

        public reorderControl(PurchaseVwReorder parent, int reorderId, string status, DateTime creatTime)
        {
            _parent = parent;
            reorderID = reorderId;
            this.status = status;
            this.creatTime = creatTime;
            InitializeComponent();
        }

        private void reorderControl_Load(object sender, EventArgs e)
        {
            lblApprove.Visible = false;
            lblReject.Visible = false;
            lblPENDING.Visible = false;
            lblID.Text = reorderID.ToString();
            lblCreate.Text = creatTime.ToString();
            btnApprove.Visible = false;
            btnReject.Visible = false;

            if (status == "PENDING")
            {
                lblPENDING.Visible = true;
                btnApprove.Visible = true;
                btnReject.Visible = true;
            } 
            else if (status == "APPROVED")
            {
                lblApprove.Visible = true;
                btnDetail.Location = new Point(btnDetail.Location.X + 120, btnDetail.Location.Y);
            } 
            else if (status == "REJECTED")
            {
                lblReject.Visible = true;
                btnDetail.Location = new Point(btnDetail.Location.X + 120, btnDetail.Location.Y);
            }
         }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var reorderResult = (from reorderRec in betterDB.reorders
                    where reorderRec.reorder_ID == reorderID
                    select reorderRec).FirstOrDefault();
                reorderResult.purchaseorders.FirstOrDefault().status = "APPROVED";
                reorderResult.purchaseorders.FirstOrDefault().approve_time = DateTime.Now;
                betterDB.SaveChanges();
            }

            MessageBox.Show("Reorder Approved");
            _parent.loadReorder();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var reorderResult = (from reorderRec in betterDB.reorders
                    where reorderRec.reorder_ID == reorderID
                    select reorderRec).FirstOrDefault();
                reorderResult.purchaseorders.FirstOrDefault().status = "REJECTED";
                betterDB.SaveChanges();
            }
            MessageBox.Show("Reorder Rejected");
            _parent.loadReorder();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DocumentViewer.showPurchaseOrder(purchaseID);
        }
    }
}
