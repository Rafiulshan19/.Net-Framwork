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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "shan" && passwordTextBox.Text == "123")
            {
                MessageBox.Show("Login successful");
                ManagerForm managerForm = new ManagerForm("Manager");
                managerForm.Show();
                this.Hide();
            }
            else if (userNameTextBox.Text == "Nayeem" && passwordTextBox.Text == "789")
            {
                MessageBox.Show("Login successful");
                WaiterForm customerForm = new WaiterForm("Waiter");
                customerForm.Show();
                this.Hide();
            }
            else if (userNameTextBox.Text == "Mamun" && passwordTextBox.Text == "000")
            {
                MessageBox.Show("Login successful");
                AdminForm admin = new AdminForm("Admin");
                admin.Show();
                this.Hide();
            }
            else
            {
                checkLabel.Visible = true;
                return;
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }

        private void checkLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
