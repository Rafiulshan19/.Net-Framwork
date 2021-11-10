using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string user)
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnFatchData_Click(object sender, EventArgs e)
        {
            //OrderFrom orderFrom = new OrderFrom(this, post);
            FatchDataForm fatchDataForm = new FatchDataForm();
            fatchDataForm.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
           // adminManageEmployee1.Visible = true;
            //adminManageEmployee1.BringToFront();
        }
    }
}
