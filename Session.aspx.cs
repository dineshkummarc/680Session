using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string username = Login1.UserName;
        string pwd = Login1.Password;

        string s;
        s = WebConfigurationManager.ConnectionStrings["ChartDatabaseConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(s);
        con.Open();
        string sqlUserName;
        sqlUserName = "SELECT user_name,password FROM Login WHERE user_name ='" + username + "' AND password ='" + pwd + "'";
        SqlCommand cmd = new SqlCommand(sqlUserName, con);

        string CurrentName;
        CurrentName = (string)cmd.ExecuteScalar();

        if (CurrentName != null)
        {
            Session["UserAuthentication"] = username;
            Session.Timeout = 1;
            Response.Redirect("Default2.aspx");
        }
        else
        {
            Session["UserAuthentication"] = "";
        }
    }
}
