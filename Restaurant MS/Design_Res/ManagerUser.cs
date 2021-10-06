using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Res
{
    public partial class ManagerUser : Form
    {
        //Manager

        public ManagerUser()
        {
            InitializeComponent();
        }

        public ManagerUser(string user)
        {
            InitializeComponent();
        }


        private void btnLogout1_Click(object sender, EventArgs e)
        {
        }

        

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            manageCustomer1.Visible = true;
            manageCustomer1.BringToFront();
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            managerMenu_UC1.Visible = true;
            managerMenu_UC1.BringToFront();

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            managerViewOrder_UC1.Visible = true;
            managerViewOrder_UC1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void welcome1_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            welcome1.BringToFront();
        }

        private void welcome1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
