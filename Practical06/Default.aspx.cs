using System;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mi1an\source\repos\SEM6\advdotnet\Practical06\App_Data\MyDatabase.mdf;Integrated Security=True";
    SqlConnection con = new SqlConnection(cs);
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        
        string query = "SELECT * FROM tbl_login WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ";
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader rdr = cmd.ExecuteReader();
        
        if (rdr.Read())
        {
            Response.Redirect("~/Welcome.aspx");
        }
 
        else
        {
            Response.Write("No User Found!");
        }
    }
}