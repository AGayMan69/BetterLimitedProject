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
    public partial class InventoryDeliveryDutyMorningForm : Form
    {
        internal InventoryAssDeliveryForm _parent;
        internal DateTime targetDate;
        internal DateTime targetDateUpper;
        private List<Panel> dutyPanels;

        public InventoryDeliveryDutyMorningForm()
        {
            InitializeComponent();
        }

        private void InventoryDeliveryDutyMorningForm_Load(object sender, EventArgs e)
        {
            dutyPanels = new List<Panel>();
            dutyPanels.Add(panDuty9);
            dutyPanels.Add(panDuty10);
            dutyPanels.Add(panDuty11);

            foreach (var panel in dutyPanels)
            {
                panel.Controls.Clear();
            }
            targetDate = targetDate.AddHours(9);
            targetDateUpper = targetDate.AddHours(3);
            using (var betterDB = new betterlimitedEntities())
            {
                var dutyControls = (from delRec in betterDB.deliveries
                    where delRec.delivery_date >= targetDate
                          && delRec.delivery_date <= targetDateUpper
                    select new InventoryDeliveryDutyControl()
                    {
                        deliveryID = delRec.delivery_ID,
                        delType = delRec.delivery_type.deliveryTypeName,
                        assignmentID = delRec.assignment_ID,
                        deliveryTime = delRec.delivery_date
                    });
                targetDate = targetDate.AddHours(-1);
                foreach (var panel in dutyPanels)
                {
                    targetDate = targetDate.AddHours(1);
                    targetDateUpper = targetDate.AddHours(1).AddTicks(-1);
                    var newControls = dutyControls.Where(control =>
                        control.deliveryTime >= targetDate && control.deliveryTime <= targetDateUpper);

                    foreach (var control in newControls)
                    {
                        control.Dock = DockStyle.Top;
                        control._parentMorning = this;
                        panel.Controls.Add(control);
                    }
                }
            }
        }
    }
}
