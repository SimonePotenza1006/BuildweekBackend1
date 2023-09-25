using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicobox
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB1"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Utenti WHERE Username = @Username and Password = @Password" , conn);
            cmd.Parameters.AddWithValue("Username", LoginUsername.Text);
            cmd.Parameters.AddWithValue("Password", LoginPassword.Text);
            conn.Open();
            SqlDataReader sqlreader;
            sqlreader = cmd.ExecuteReader();
            string username = "";
            string password = "";
            while (sqlreader.Read())
            {
                username = sqlreader["Username"].ToString();
                password = sqlreader["Password"].ToString();
            }

            conn.Close();
            if(username != "" && password != "" )
            {
                Session["User"] = username;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB1"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Utenti Values (@Username, @Password)";
            cmd.Parameters.AddWithValue("Username", SignupUsername.Text);
            cmd.Parameters.AddWithValue("Password", SignupPassword.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Default.aspx");

        }
    }
}