using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlServerCe;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("fffffff");
        connect_database();

    }
    private void connect_database()
    {
        Response.Write("connect to DB");
        string conn = @"Data Source = C:\DARMIS\test-person-rao\App_Data\Database.sdf;Persist Security Info=False;";
        SqlCeConnection cn = new SqlCeConnection(conn);
        try
        {
            cn.Open();
            Response.Write("Connection is ok");
            string fName = "Mary";
            string lName = "Overstreet";
            string gender = "F";
            int code = 2;
            string dob = "05/05/1965";
            DateTime datedob = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
            
           string sqlquery = ("INSERT INTO person (first_name, last_name, state_id, gender, dob)" + 
                   "Values(@first_name, @last_name, @state_id, @gender, @dob)");

SqlCeCommand cmd = new SqlCeCommand(sqlquery, cn);
cmd.Parameters.AddWithValue("@first_name", fName);
cmd.Parameters.AddWithValue("@last_name", lName);
cmd.Parameters.AddWithValue("@state_id", code);
cmd.Parameters.AddWithValue("@gender", gender);
cmd.Parameters.AddWithValue("@dob", dob);
cmd.ExecuteNonQuery();
               Response.Write("record xxx inserted");
             

        }
        catch (SqlCeException ex)
        {
            Response.Write("Connection failed");
            Response.Write(ex.Message);
            
        }
        cn.Close();
    }
    private void connect_databaseII()
    {
        Response.Write("connect to DB");
        string conn = @"Data Source = C:\DARMIS\test-person-rao\App_Data\Database.sdf;Persist Security Info=False;";
        SqlCeConnection cn = new SqlCeConnection(conn);
        try
        {
            cn.Open();
            Response.Write("Connection is ok");
            string fName = "John";
            string lName = "Doe";
            string gender = "M";
            string code = "EE";
            string dob = "01/01/1955";

            string sqlquery = ("INSERT INTO states (state_code)" +
                    "Values(@state_code)");

            SqlCeCommand cmd = new SqlCeCommand(sqlquery, cn);
            //cmd.Parameters.AddWithValue("@client", clientName);
            //cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@state_code", code);
            //cmd.Parameters.AddWithValue("@tel", telNo);
            cmd.ExecuteNonQuery();
            Response.Write("record EE inserted");


        }
        catch (SqlCeException ex)
        {
            Response.Write("Connection failed");
            Response.Write(ex.Message);

        }
        cn.Close();
    }
}