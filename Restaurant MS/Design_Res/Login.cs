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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "shan" && txtPassword.Text == "123" )
            {
                MessageBox.Show("Login successful");
                ManagerUser managerUser = new ManagerUser("Manager");
                managerUser.Show();
                this.Hide();
            }
            else if(txtUsername.Text == "Nayeem" && txtPassword.Text == "789")
            {
                MessageBox.Show("Login successful");
                // ManagerUser managerUser = new ManagerUser("Manager");
                CustomerUser customerUser = new CustomerUser("Customer");
                customerUser.Show();
                // managerUser.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "Mamun" && txtPassword.Text == "000")
            {
                MessageBox.Show("Login successful");
                Admin admin = new Admin("Admin");
                admin.Show();
                //ManagerUser managerUser = new ManagerUser("Manager");
                //managerUser.Show();
                this.Hide();
            }
            else
            {
                 MessageBox.Show("Invalid Username or Password");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
