using DataAccessLayer.Entities;
using DataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Res.Presentation_Layer
{
    public partial class AdminManageEmployee : UserControl
    {
        public AdminManageEmployee()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            comboBox1_txtUserType.SelectedIndex = -1;
            txtPassword.Clear();
            txtPhoneNo.Clear();
            txtUserID.Clear();
            txtUserName.Clear();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            EAdminManageEmployee eAdminManageEmployee = new EAdminManageEmployee();
            OAdminManageEmployee oAdminManageEmployee = new OAdminManageEmployee();

            if (txtPassword.Text == "" || txtPhoneNo.Text == "" || txtUserName.Text == "" || txtUserID.Text == "" || comboBox1_txtUserType.Text == "" )
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eAdminManageEmployee.UserType = comboBox1_txtUserType.Text;
                eAdminManageEmployee.UserID = txtUserID.Text;
                eAdminManageEmployee.UserName = txtUserName.Text;
                eAdminManageEmployee.Password = txtPassword.Text;
                eAdminManageEmployee.PhoneNo = txtPhoneNo.Text;

                int effectedRows = oAdminManageEmployee.AddEmployee(eAdminManageEmployee);

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

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
           
            OAdminManageEmployee oAdminManageEmployee = new OAdminManageEmployee();
            SqlDataAdapter sqlDataAdapter = oAdminManageEmployee.ShowEmployee();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            EAdminManageEmployee eAdminManageEmployee = new EAdminManageEmployee();
            OAdminManageEmployee oAdminManageEmployee = new OAdminManageEmployee();

            if ( txtUserID.Text == "" || comboBox1_txtUserType.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eAdminManageEmployee.UserType = comboBox1_txtUserType.Text;
                eAdminManageEmployee.UserID = txtUserID.Text;
                //eAdminManageEmployee.UserName = txtUserName.Text;
                //eAdminManageEmployee.Password = txtPassword.Text;
                //eAdminManageEmployee.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);

                int effectedRows = oAdminManageEmployee.DeleteEmployee(eAdminManageEmployee);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Employee successfully deleted");
                }
                else
                {
                    MessageBox.Show("Employee failed to delete");
                }
            }
            clearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void btnUpdateEmployee_Click(object sender, EventArgs e)
        //{
        //    EAdminManageEmployee eAdminManageEmployee = new EAdminManageEmployee();
        //    OAdminManageEmployee oAdminManageEmployee = new OAdminManageEmployee();

        //    if (txtPassword.Text == "" || txtPhoneNo.Text == "" || txtUserName.Text == "" || txtUserID.Text == "" || comboBox1_txtUserType.Text == "")
        //    {
        //        MessageBox.Show("Fill up required form");
        //    }
        //    else
        //    {
        //        eAdminManageEmployee.UserType = comboBox1_txtUserType.Text;
        //        eAdminManageEmployee.UserID = txtUserID.Text;
        //        eAdminManageEmployee.UserName = txtUserName.Text;
        //        eAdminManageEmployee.Password = txtPassword.Text;
        //        eAdminManageEmployee.PhoneNo = txtPhoneNo.Text;

        //        int effectedRows = oAdminManageEmployee.UpdateEmployee(eAdminManageEmployee);

        //        if (effectedRows > 0)
        //        {
        //            MessageBox.Show("Employee's information update successful");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Employee's information update failed");
        //        }
        //    }
        //    clearAll();
        //}
    }
}
