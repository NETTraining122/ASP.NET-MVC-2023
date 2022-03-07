using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AjaxCall2
{
    [WebService(Namespace = "https://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class WebService1 : System.Web.Services.WebService {

        public class user99
        {
        public string Name;
        public string City;
    }

    [WebMethod]
    public user99 EmployeeGet(string Name) {

        user99 objEmployee = new user99();    

        string sConnString = "Data Source=PC\\SQLEXPRESS;Initial Catalog=NCSDb;Integrated Security=True";

        SqlConnection myConn = new SqlConnection(sConnString);
        SqlCommand objComm = new SqlCommand("SELECT *FROM user99 " +
                        "WHERE Name LIKE '%'+@LookUP+'%'", myConn);
        myConn.Open();

        objComm.Parameters.AddWithValue("@LookUP", Name);
        SqlDataReader sdr = objComm.ExecuteReader();

        if (sdr.Read())
        {
            objEmployee.Name = sdr["Name"].ToString();
            objEmployee.City = sdr["City"].ToString();
          
        }
        myConn.Close(); 
        sdr.Close(); 
        return objEmployee;
    }
}
}