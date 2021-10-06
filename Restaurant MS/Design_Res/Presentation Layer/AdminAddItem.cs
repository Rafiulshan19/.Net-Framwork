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

namespace Design_Res.Presentation_Layer
{
    public partial class AdminAddItem : UserControl
    {
        public AdminAddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            EManagerMenu_UC eManagerMenu_UC = new EManagerMenu_UC();
            OManagerMenu_UC oManagerMenu_UC = new OManagerMenu_UC();

            if (txtItem.Text == "" || txtPrice.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fill up required form");
            }
            else
            {
                eManagerMenu_UC.FoodCategory2 = comboBox1.Text;
                eManagerMenu_UC.FoodName = txtItem.Text;
                eManagerMenu_UC.FoodPrice = Convert.ToInt32(txtPrice.Text);

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
            //clearAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtItem.Clear();
            txtPrice.Clear();
        }
    }
}
