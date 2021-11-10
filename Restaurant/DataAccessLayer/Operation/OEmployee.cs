using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Operation
{
    class OEmployee
    {
        //OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        /*
        OracleConnection sqlConnection = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = tcp)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = ORCL))); User Id = SYSTEM; Password=shan8034;");


        public int AddEmployee(EAdminManageEmployee eAdminManageEmployee)
        {
            OracleConnection.Open();
            OracleCommand cmd = new OracleCommand("insert into EMPLOYEE(UserType, UserID, Username, Password, PhoneNo) values('" + eAdminManageEmployee.UserType + "','" + eAdminManageEmployee.UserID + "','" + eAdminManageEmployee.UserName + "','" + eAdminManageEmployee.Password + "','" + eAdminManageEmployee.PhoneNo + "')", sqlConnection);
            int check = cmd.ExecuteNonQuery();
            OracleConnection.Close();
            return check;
        }
        */

    }
}
