using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer.Entities;
using System.Data;

namespace DataAccessLayer.Operation
{
    public class OSignupData
    {
        //[Obsolete]
        // OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        [Obsolete]
        OracleConnection oracleConnection = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = tcp)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = ORCL))); User Id = SYSTEM; Password=shan8034;");

        
        [Obsolete]
        public int AddSignup(ESignupData eSignup)
        {
            oracleConnection.Open();
            OracleCommand cmd = new OracleCommand("INSERT INTO REGISTRATION(NAME, Username, EMAIL, GENDER, DOB, PHONE, ADDRESS, Password) values('" + eSignup.Name + "','" + eSignup.Username + "','" + eSignup.Email + "','" + eSignup.Gender + "','" + eSignup.Dob + "','" + eSignup.Phone + "','" + eSignup.Address + "','" + eSignup.Password+"')", oracleConnection);
            int check = cmd.ExecuteNonQuery();
            oracleConnection.Close();
            return check;
        }

    }
}
