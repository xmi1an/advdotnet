using System;
using System.Data.SqlClient;
public partial class Registration : System.Web.UI.Page
{
    static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mi1an\source\repos\SEM6\advdotnet\Practical22\App_Data\Database.mdf;Integrated Security=True";
    SqlConnection con = new SqlConnection(cs);
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string query = "insert into users(fname, lname, bdate,email,dept,gender,phno,username,password) values('" + txtFname.Text + "', '" + txtLname.Text + "', '" + BdayCalendar.SelectedDate + "', '" + txtEmail.Text + "', '" + DeptDD.SelectedItem.Value + "', '" + GenderRadioButton.SelectedValue + "', '" + txtPno.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "' )";

        SqlCommand cmd = new SqlCommand(query, con);
        int check = cmd.ExecuteNonQuery();
        if (check > 0)
        {
            lblAction.Text = "Data Inserted";
        }
    }
}