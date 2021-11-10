using DataAccessLayer.Entities;
using DataAccessLayer.Operation;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        public void clearAll()
        {
            comboBoxGender.SelectedIndex = -1;
            textPassword.Clear();
            textPhone.Clear();
            textAddress.Clear();
            textUserename.Clear();
            textEmail.Clear();
            textName.Clear();
        }

        [Obsolete]
        private void btnSignup_Click(object sender, EventArgs e)
        {
             ESignupData eSignupData = new ESignupData();
             OSignupData oSignupData = new OSignupData();
            //
             if (textPassword.Text == "" || textPhone.Text == "" || textAddress.Text == "" || textEmail.Text == "" || comboBoxGender.Text == "" || textUserename.Text == "" || textName.Text == "")
             {
                 MessageBox.Show("Fill up required form");
             }
             else
             {
                eSignupData.Address = textAddress.Text;
                //eSignupData.Dob = dateTimePicker1DOB.Value.ToString("DD-MM-YYYY");
                eSignupData.Email = textEmail.Text;
                eSignupData.Gender = comboBoxGender.Text;
                eSignupData.Name = textName.Text;
                eSignupData.Username = textUserename.Text;
                eSignupData.Password = textPassword.Text;
                eSignupData.Phone = textPhone.Text;

                int effectedRows = oSignupData.AddSignup(eSignupData);

                 if (effectedRows > 0)
                 {
                     MessageBox.Show("Employee addition successful");
                 }
                 else
                 {
                     MessageBox.Show("Employee addition failed");
                 }
             }
             clearAll();
        }
    }
}
