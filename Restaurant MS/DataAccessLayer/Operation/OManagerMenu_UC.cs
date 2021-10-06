using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class OManagerMenu_UC
    {
        SqlConnection conn = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");

        public int AddFoodItem(EManagerMenu_UC eManagerMenu_UC)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MTable3(FoodCategory, FoodName, FoodPrice) values('" + eManagerMenu_UC.FoodCategory2 + "','" + eManagerMenu_UC.FoodName + "','" +eManagerMenu_UC.FoodPrice + "')", conn);
            int check = cmd.ExecuteNonQuery();
            conn.Close();
            return check;
        }
        public SqlDataAdapter ViewFoodItem()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from MTable3", conn);
            conn.Close();
            return sqlDataAdapter;
        }
        public int RemoveFoodItem(EManagerMenu_UC eManagerMenu_UC)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MTable3 where FoodName = '" + eManagerMenu_UC.FoodName + "'", conn);
            int check = cmd.ExecuteNonQuery();
            conn.Close();
            return check;
        }

        public int UpdateFoodItem(EManagerMenu_UC eManagerMenu_UC)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update MTable3 set FoodPrice = '" + eManagerMenu_UC.FoodPrice + "', FoodName = '" + eManagerMenu_UC.FoodName + "' where FoodCategory = '" + eManagerMenu_UC.FoodCategory2 + "'",  conn);
            int check = cmd.ExecuteNonQuery();
            conn.Close();
            return check;
        }

       







        /////
        ///public int Remove(EManageCustomer eManageCustomer)
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("delete from MTable1 where CustomerId = '" + eManageCustomer.CustomerId + "'", connection);
        //    int check = cmd.ExecuteNonQuery();
        //    connection.Close();
        //        return check;
        //    }

        //public int Update(EManageCustomer eManageCustomer)
        //{
        //    connection.Open();
        //    SqlCommand cmd = new SqlCommand("update MTable1 set CustomerName = '" + eManageCustomer.CustomerName + "',PhoneNo = '" + eManageCustomer.PhoneNo + "' where CustomerId = '" + eManageCustomer.CustomerId + "'", connection);
        //    int check = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    return check;
        //}
    }
}
