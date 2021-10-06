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
    public partial class Admin : Form
    {
        //ADMIN
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string user)
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            //managerViewOrder_UC1.Visible = true;
            //managerViewOrder_UC1.BringToFront();
            adminManageEmployee1.Visible = true;
            adminManageEmployee1.BringToFront();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            adminAddItem1.Visible = true;
            adminAddItem1.BringToFront();
        }
    }
}
