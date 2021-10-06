using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class OAdminManageEmployee
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=SHAN\\SQLEXPRESS;Initial Catalog=DBConnectionQ;Integrated Security=True");
        
        public int AddEmployee(EAdminManageEmployee eAdminManageEmployee)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into EmpTable(UserType, UserID, Username, Password, PhoneNo) values('" + eAdminManageEmployee.UserType + "','" + eAdminManageEmployee.UserID + "','" + eAdminManageEmployee.UserName + "','"+eAdminManageEmployee.Password+"','"+eAdminManageEmployee.PhoneNo+"')", sqlConnection);
            int check = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return check;
        }

        public SqlDataAdapter ShowEmployee()
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from EmpTable", sqlConnection);
            sqlConnection.Close();
            return sqlDataAdapter;
        }

        public int DeleteEmployee(EAdminManageEmployee eAdminManageEmployee)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("delete from EmpTable where UserID = '" + eAdminManageEmployee.UserID + "'", sqlConnection);
            int check = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return check;
        }

        //public int UpdateEmployee(EAdminManageEmployee eAdminManageEmployee)
        //{
        //    sqlConnection.Open();
        //    SqlCommand cmd = new SqlCommand("update EmpTable set UserName = '" + eAdminManageEmployee.UserName + "',PhoneNo = '" + eAdminManageEmployee.PhoneNo + "',Password= '"+eAdminManageEmployee.Password+"',UserType = '"+eAdminManageEmployee.UserType+"' where CustomerId = '" + eAdminManageEmployee.UserID + "'", sqlConnection);
        //    int check = cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    return check;
        //}
       
    }
}
