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
    public partial class InventoryDeliveryDutyControl : UserControl
    {
        internal int deliveryID;
        internal string delType;
        internal int? assignmentID;
        internal DateTime? deliveryTime;
        internal InventoryDeliveryDutyMorningForm _parentMorning;
        internal InventoryDeliveryDutyAfternoonForm _parentAfternoon;
        internal InventoryDeliveryDutyEveningForm _parentEvening;

        private Dictionary<string, Color> delTypeColor;

        public InventoryDeliveryDutyControl()
        {
            InitializeComponent();
        }

        private void InventoryDeliveryDutyControl_Load(object sender, EventArgs e)
        {
            delTypeColor = new Dictionary<string, Color>();
            delTypeColor.Add("Customer", Color.FromArgb(73, 219, 149));
            delTypeColor.Add("Replenish", Color.FromArgb(181, 113, 11));
            delTypeColor.Add("Defect", Color.FromArgb(253, 113, 82));

            lblDelID.Text = deliveryID.ToString();
            btnAssign.Visible = false;
            lblAss.Visible = false;
            lblUnAss.Visible = false;
            if (assignmentID == null)
            {
                btnAssign.Visible = true;
                lblUnAss.Visible = true;
            }
            else
            {
                lblAss.Visible = true;
            }

            lblType.Text = delType;
            lblType.BackColor = delTypeColor[delType];
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            InventoryAssWorkerForm assForm = new InventoryAssWorkerForm();
            assForm.deliveryID = deliveryID;
            var dialogueResult = assForm.ShowDialog();
            if (dialogueResult == DialogResult.OK)
            {
                if (_parentMorning != null)
                {
                    _parentMorning._parent.loadDuty();
                } 
                else if (_parentAfternoon != null)
                {
                    _parentAfternoon._parent.loadDuty();
                } 
                else if (_parentEvening != null)
                {
                    _parentEvening._parent.loadDuty();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (var betterDB = new betterlimitedEntities())
            {
                var delResult = (from delRec in betterDB.deliveries
                    where delRec.delivery_ID == deliveryID
                    select delRec).FirstOrDefault();
                betterDB.deliveries.Remove(delResult);
                betterDB.SaveChanges();
            }
        }
    }
}
