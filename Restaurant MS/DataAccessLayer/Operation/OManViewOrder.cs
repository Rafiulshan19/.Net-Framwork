using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class OManViewOrder
    {
        SqlConnection con = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");
        public int Add(EManViewOrder eManViewOrder)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MTable2(FoodCategory, FoodItem, Price) values('" + eManViewOrder.FoodCategory + "','" + eManViewOrder.FoodItem + "','" + eManViewOrder.Price + "')", con);
            int check =cmd.ExecuteNonQuery();
            con.Close();
            return check;
        }
        public SqlDataAdapter Show()
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from MTable2", con);
            con.Close();
            return sqlDataAdapter;
        }
        public int Remove(EManViewOrder eManViewOrder)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from MTable2 where FoodItem = '" + eManViewOrder.FoodItem + "'", con);
            int check = cmd.ExecuteNonQuery();
            con.Close();
            return check;
        }
    }
}
