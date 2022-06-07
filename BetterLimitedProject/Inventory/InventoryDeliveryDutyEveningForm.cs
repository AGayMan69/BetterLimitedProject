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
    public partial class InventoryDeliveryDutyEveningForm : Form
    {
        internal InventoryAssDeliveryForm _parent;
        internal DateTime targetDate;
        internal DateTime targetDateUpper;
        private List<Panel> dutyPanels;

        public InventoryDeliveryDutyEveningForm()
        {
            InitializeComponent();
        }

        private void InventoryDeliveryDutyEveningForm_Load(object sender, EventArgs e)
        {
            dutyPanels = new List<Panel>();
            dutyPanels.Add(panDuty18);
            dutyPanels.Add(panDuty19);
            dutyPanels.Add(panDuty20);
            dutyPanels.Add(panDuty21);


            foreach (var panel in dutyPanels)
            {
                panel.Controls.Clear();
            }

            targetDate = targetDate.AddHours(18);
            targetDateUpper = targetDate.AddHours(4);
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
                        control._parentEvening = this;
                        panel.Controls.Add(control);
                    }
                }
            }
        }
    }
}
