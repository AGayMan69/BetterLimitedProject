using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject.Inventory
{
    public partial class InventoryDeliveryControl : UserControl
    {
        internal int deliveryID;
        internal string status;
        internal string delType;
        internal DateTime creaTime;
        internal DateTime? approvTime;
        internal DateTime? deliveryTime;
        internal Dictionary<string, Label> statusLbl;
        internal InventoryVwDeliveryForm _parent;

        public InventoryDeliveryControl()
        {
            InitializeComponent();
        }

        private void InventoryDeliveryControl_Load(object sender, EventArgs e)
        {
            statusLbl = new Dictionary<string, Label>();
            statusLbl.Add("Approved", lblStatusApproved);
            statusLbl.Add("Pending", lblStatusPending);
            statusLbl.Add("Completed", lblStatusCompleted);
            statusLbl.Add("Cancel", lblStatusCancel);

            foreach (var label in statusLbl)
            {
                label.Value.Visible = false;
            }

            btnArrange.Visible = false;
            btnEdit.Visible = false;


            statusLbl[status].Visible = true;

            if (status == "Approved")
            {
                btnEdit.Visible = true;
            } 
            else if (status == "Pending")
            {
                btnArrange.Visible = true;
            }

            lblDeliveryID.Text = deliveryID.ToString();
            lblType.Text = delType;
            lblCreationTime.Text = creaTime.ToString("g");
            if (deliveryTime != null)
            {
                lblDeliveryTime.Text = ((DateTime)deliveryTime).ToString("g");
            }
            else
            {
                lblDeliveryTime.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _parent.delDelivery(deliveryID, delType);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.editDelivery(deliveryID, delType);
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            _parent.arrDelivery(deliveryID, delType);
        }
    }
}
