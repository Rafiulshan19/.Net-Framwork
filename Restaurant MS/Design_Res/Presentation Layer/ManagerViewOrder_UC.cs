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
    public partial class ManagerViewOrder_UC : UserControl
    {
        public ManagerViewOrder_UC()
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

        public void clearAll()
        {
            ComboBoxFoodCategory.SelectedIndex = -1;
            txtFoodItem.Clear();
            txtPrice.Clear();
            //txtFoodItem.Clear();

        }


        private void ManagerViewOrder_UC_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        protected int n, total = 0;
        public int amount;
        
       private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString() );
            }
            catch
            {
                MessageBox.Show("Something's wrong");
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
        }
            catch
            {
                MessageBox.Show("Something's wrong");
            }
            total -=  amount;
            lbtotal.Text = "Tk. " + total;
        }

        

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtFoodItem.Text == "" || txtPrice.Text == "" || ComboBoxFoodCategory.Text == "" )
            {
                MessageBox.Show("Fill the required form");
            }
            else
            {
                n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = ComboBoxFoodCategory.Text;
                dataGridView2.Rows[n].Cells[1].Value = txtFoodItem.Text;
                dataGridView2.Rows[n].Cells[2].Value = txtPrice.Text;

                total += int.Parse(txtPrice.Text);
                lbtotal.Text = "Tk. " + total;
            }
           
            clearAll();
        }
    }
}
