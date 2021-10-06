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
    public partial class ManagerMenu_UC : UserControl
    {

        SqlConnection conn = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");
        public ManagerMenu_UC()
        {
            InitializeComponent();
        }
        //??
        public void popolateGrid()
        {
            conn.Open();
            string query = "select * from MTable3";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1_ManagerMenu.DataSource = ds.Tables[0]; 
            conn.Close();
        }
        public void TextboxFilter()
        {
            conn.Open();
            string query = "select * from MTable3 where FoodName = '"+txtSearchName.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1_ManagerMenu.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void FoodCategoryFilter()
        {
            conn.Open();
            string query = "select * from MTable3 where FoodCategory = '" + comboBox1Search4Category.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1_ManagerMenu.DataSource = ds.Tables[0];
            conn.Close();
        }

        public void clearAll()
        {
            comboBox1FoodCategory2.SelectedIndex = -1;
            txtFoodName2.Clear();
            txtFoodPrice.Clear();
            

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

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();
            SqlDataAdapter sqlDataAdapter = oManagerMenu_UC.ViewFoodItem();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1_ManagerMenu.DataSource = dataTable;

           // comboBox1Search4Category.SelectedIndex = -1;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            EManagerMenu_UC eManagerMenu_UC = new EManagerMenu_UC();
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();

            if (txtFoodName2.Text == "" || txtFoodPrice.Text == "" || comboBox1FoodCategory2.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManagerMenu_UC.FoodCategory2 = comboBox1FoodCategory2.Text;
                eManagerMenu_UC.FoodName = txtFoodName2.Text;
                eManagerMenu_UC.FoodPrice = Convert.ToInt32(txtFoodPrice.Text);

                int effectedRows = oManagerMenu_UC.AddFoodItem(eManagerMenu_UC);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Food Item addition successful");
                }
                else
                {
                    MessageBox.Show("Food Item addition failed");
                }
            }
            clearAll();
        }

        private void btnRemoveFoodItem_Click(object sender, EventArgs e)
        {
            EManagerMenu_UC eManagerMenu_UC = new EManagerMenu_UC();
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();

            if (txtFoodName2.Text == "" )
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
               // eManagerMenu_UC.FoodCategory2 = comboBox1FoodCategory2.Text;
                eManagerMenu_UC.FoodName = txtFoodName2.Text;
               // eManagerMenu_UC.FoodPrice = Convert.ToInt32(txtFoodPrice.Text);

                int effectedRows = oManagerMenu_UC.RemoveFoodItem(eManagerMenu_UC);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Food Item successfully removed");
                }
                else
                {
                    MessageBox.Show("Failed to remove Food Item");
                }
            }
            clearAll();
        }

        private void btnUpdateFoodItem_Click(object sender, EventArgs e)
        {
            EManagerMenu_UC eManagerMenu_UC = new EManagerMenu_UC();
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();

            if (txtFoodName2.Text == "" || txtFoodPrice.Text == "" || comboBox1FoodCategory2.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManagerMenu_UC.FoodCategory2 = comboBox1FoodCategory2.Text;
                eManagerMenu_UC.FoodName = txtFoodName2.Text;
                eManagerMenu_UC.FoodPrice = Convert.ToInt32(txtFoodPrice.Text);

                int effectedRows = oManagerMenu_UC.UpdateFoodItem(eManagerMenu_UC);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Food Item successfully updated");
                }
                else
                {
                    MessageBox.Show("Failed to update Food Item");
                }
            }
            clearAll();
        }

        //???
        private void ManagerMenu_UC_Load(object sender, EventArgs e)
        {
            popolateGrid();
        }
        //????
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            popolateGrid();
            txtSearchName.Text = "";
        }

        private void comboBox1Search4Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategoryFilter();
        }

        private void comboBox1FoodCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
