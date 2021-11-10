using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace Restaurant
{
    public partial class FatchDataForm : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public FatchDataForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            /* con.Open();
             MessageBox.Show("Connected");
             con.Close();*/
            OracleDataAdapter ad = new OracleDataAdapter("SELECT * FROM EMPLOYEE", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SELECT E_NAME FROM EMPLOYEE", con);
            con.Open();
            OracleDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string ename = reader["E_NAME"].ToString();
                comboBox1.Items.Add(ename);
            }
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
