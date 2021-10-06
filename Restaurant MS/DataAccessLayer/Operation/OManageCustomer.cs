using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class OManageCustomer
    {
        SqlConnection connection = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");
        public int Add(EManageCustomer eManageCustomer)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into MTable1(CustomerId, CustomerName, PhoneNo) values('" + eManageCustomer.CustomerId + "','" + eManageCustomer.CustomerName + "','"+eManageCustomer.PhoneNo+ "')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        public SqlDataAdapter Show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from MTable1", connection);
            connection.Close();
            return sqlDataAdapter;
        }
        ///???????????????
        public int Remove(EManageCustomer eManageCustomer)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from MTable1 where CustomerId = '" + eManageCustomer.CustomerId + "'", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int Update(EManageCustomer eManageCustomer)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update MTable1 set CustomerName = '" + eManageCustomer.CustomerName + "',PhoneNo = '" + eManageCustomer.PhoneNo + "' where CustomerId = '" + eManageCustomer.CustomerId  + "'", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }

       
    }
}
