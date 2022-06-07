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
    public partial class InventoryAssDeliveryForm : Form
    {
        enum TimeSession
        {
            Morning,
            Afternoon,
            Evening
        }

        private TimeSession session;

        public InventoryAssDeliveryForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            loadDuty();
        }

        internal void loadDuty()
        {
            panDutyLoader.Controls.Clear();
            DateTime target = calDeli.SelectionRange.Start;
            if (session == TimeSession.Morning)
            {
                var dutyForm = new InventoryDeliveryDutyMorningForm();
                dutyForm._parent = this;
                dutyForm.targetDate = target;
                setForm(dutyForm);
                panDutyLoader.Controls.Add(dutyForm);
                dutyForm.Show();
            } 
            else if (session == TimeSession.Afternoon)
            {
                var dutyForm = new InventoryDeliveryDutyAfternoonForm() {TopLevel = false, Dock = DockStyle.Fill};
                dutyForm._parent = this;
                dutyForm.targetDate = target;
                setForm(dutyForm);
                panDutyLoader.Controls.Add(dutyForm);
                dutyForm.Show();
            }
            else
            {
                var dutyForm = new InventoryDeliveryDutyEveningForm() {TopLevel = false, Dock = DockStyle.Fill};
                dutyForm._parent = this;
                dutyForm.targetDate = target;
                setForm(dutyForm);
                panDutyLoader.Controls.Add(dutyForm);
                dutyForm.Show();
            }
        }

        private void setForm(Form frm)
        {
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
        }

        private void InventoryAssDeliveryForm_Load(object sender, EventArgs e)
        {
            session = TimeSession.Morning;
            btnMorning.BackColor = Color.FromArgb(0, 39, 79);
            btnMorning.ForeColor = Color.White;
            loadDuty();
        }

        private void btnMorning_Click(object sender, EventArgs e)
        {
            session = TimeSession.Morning;
            resetBtnColor();
            clickedBtnColor(btnMorning);
            loadDuty();
        }

        private void btnAfternoon_Click(object sender, EventArgs e)
        {
            session = TimeSession.Afternoon;
            resetBtnColor();
            clickedBtnColor(btnAfternoon);
            loadDuty();
        }

        private void btnEvening_Click(object sender, EventArgs e)
        {
            session = TimeSession.Evening;
            resetBtnColor();
            clickedBtnColor(btnEvening);
            loadDuty();
        }

        private void resetBtnColor()
        {
            btnMorning.BackColor = Color.White;
            btnMorning.ForeColor = Color.FromArgb(0, 39, 79);
            btnAfternoon.BackColor = Color.White;
            btnAfternoon.ForeColor = Color.FromArgb(0, 39, 79);
            btnEvening.BackColor = Color.White;
            btnEvening.ForeColor = Color.FromArgb(0, 39, 79);
        }

        private void clickedBtnColor(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 39, 79);
            btn.ForeColor = Color.White;
        }
    }
}
