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
    public partial class CustomerUser : Form
    {
        //Customer

        public CustomerUser()
        {
            InitializeComponent();
        }

        public CustomerUser(string user)
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            customerPlaceOrder1.Visible = true;
            customerPlaceOrder1.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            customerMenu1.Visible = true;
            customerMenu1.BringToFront();
        }

        private void welcome1_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            welcome1.BringToFront();
        }
    }
}
