using System;
using System.Data.SqlClient;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mi1an\source\repos\SEM6\advdotnet\Practical12\App_Data\Database.mdf;Integrated Security=True";
    SqlConnection con = new SqlConnection(cs);
    protected void Page_Load(object sender, EventArgs e)
    {
            con.Open();
            string query = "SELECT * from users";

            SqlCommand cmdr = new SqlCommand(query, con);
            SqlDataReader reader = cmdr.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();
       
            reader.Close();

    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
            string query = "insert into users(name, city, country) values('" + txtName.Text + "',  '" + txtCity.Text + "', '" + txtCountry.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
                lblCheck.Text = "Data Inserted";
            lblCheck.Visible = true;
            }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string query = "UPDATE users SET name='" + txtName.Text + "', city='" + txtCity.Text + "', country='" + txtCountry.Text + "' WHERE Name='" + txtName.Text + "'";
        SqlCommand cmd = new SqlCommand(query, con);
        int check = cmd.ExecuteNonQuery();
        if (check > 0)
        {
            lblCheck.Text = "Data Updated";
            lblCheck.Visible = true;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string query = "DELETE FROM users WHERE name = ('"+txtName.Text+"') ";
        SqlCommand cmd = new SqlCommand(query, con);
        int check = cmd.ExecuteNonQuery();
        if (check > 0)
        {
            lblCheck.Text = "Data Deleted";
            lblCheck.Visible = true;
        }
    }
}