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
    public partial class ManageCustomer : UserControl
    {

        SqlConnection conn = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");
        public void popolateGrid2()
        {
            conn.Open();
            string query = "select * from MTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1_ManagerMenu.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void TextboxFilter2()
        {
            conn.Open();
            string query = "select * from MTable1 where CustomerName = '" + txtSearch4Customer.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }


        OManageCustomer om = new OManageCustomer();
        //String query;

        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerUser managerUser = new ManagerUser();
            managerUser.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            EManageCustomer eManageCustomer = new EManageCustomer();
            OManageCustomer oManageCustomer = new OManageCustomer();

            if(txtCustomerId.Text == "" || txtCustomerName.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManageCustomer.CustomerId = txtCustomerId.Text;
                eManageCustomer.CustomerName = txtCustomerName.Text;
                eManageCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);

                int effectedRows = oManageCustomer.Add(eManageCustomer);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Customer addition successful");
                }
                else
                {
                    MessageBox.Show("Customer addition failed");
                }
            }
            
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            OManageCustomer oManageCustomer = new OManageCustomer();
            SqlDataAdapter sqlDataAdapter = oManageCustomer.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            EManageCustomer eManageCustomer = new EManageCustomer();
            OManageCustomer oManageCustomer = new OManageCustomer();

            if (txtCustomerId.Text == "" || txtCustomerName.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManageCustomer.CustomerId = txtCustomerId.Text;
                eManageCustomer.CustomerName = txtCustomerName.Text;
                eManageCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);

                int effectedRows = oManageCustomer.Remove(eManageCustomer);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Customer successfully removed");
                }
                else
                {
                    MessageBox.Show("Failed to remove Customer");
                }
            }

        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            EManageCustomer eManageCustomer = new EManageCustomer();
            OManageCustomer oManageCustomer = new OManageCustomer();

            if (txtCustomerId.Text == "" || txtCustomerName.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManageCustomer.CustomerId = txtCustomerId.Text;
                eManageCustomer.CustomerName = txtCustomerName.Text;
                eManageCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);

                int effectedRows = oManageCustomer.Update(eManageCustomer);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Customer's information updated");
                }
                else
                {
                    MessageBox.Show("Failed to update Customer's information");
                }
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtPhoneNo.Text = "";
        }


        private void btnSearch4Customer_Click(object sender, EventArgs e)
        {
            TextboxFilter2();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            popolateGrid2();
            txtSearch4Customer.Text = "";
        }
    }
}
