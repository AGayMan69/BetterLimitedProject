using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;
            dtpHireDate.MaxDate = DateTime.Today;
            using (var betterDb = new betterlimitedEntities())
            {
                var departments = (from list in betterDb.departments
                                   select list.department_name);
                foreach (var department in departments.ToList())
                {
                    cboDepartment.Items.Add(department);
                }
            }

            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Image = (Image)new Bitmap(BetterLimitedProject.Properties.Resources.login_icon, new Size(16,16));

        }

        private void cboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboDepartment.SelectedItem.ToString());
            string targetDepartment = cboDepartment.SelectedItem.ToString();
            // generating position according to the 
            using (var betterDb = new betterlimitedEntities())
            {
                var positions = (from position in betterDb.positions
                    join department in betterDb.departments
                        on position.department_ID equals department.department_ID
                    where department.department_name.Equals(targetDepartment)
                                 select position.position_title);
                foreach (var position in positions.ToList())
                {
                    cboPosition.Items.Add(position);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text))
            {

            }
        }
    }
}
