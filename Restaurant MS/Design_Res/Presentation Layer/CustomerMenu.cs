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
    public partial class CustomerMenu : UserControl
    {
        SqlConnection co = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");

        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUser customerUser = new CustomerUser();
            customerUser.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        public void clearAll()
        {
            comboBox1Category.SelectedIndex = -1;
            txtFoodName.Clear();
        }

       
        public void FoodItemFilter()
        {
            co.Open();
            string query = "select * from MTable3 where FoodName = '" + txtFoodName.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, co);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Menu.DataSource = ds.Tables[0];
            co.Close();
        }
        public void FoodCategoryFilter()
        {
                co.Open();
                string query = "select * from MTable3 where FoodCategory = '" + comboBox1Category.SelectedItem.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, co);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView_Menu.DataSource = ds.Tables[0];
                co.Close();
            
        }


        private void btnViewFoodItems_Click(object sender, EventArgs e)
        {
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();
            SqlDataAdapter sqlDataAdapter = oManagerMenu_UC.ViewFoodItem();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_Menu.DataSource = dataTable;

            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FoodItemFilter();
        }

        private void comboBox1Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategoryFilter();
        }
    }
}
