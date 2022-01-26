using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void login_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text == "1234")
        {
            // Storing email to Session variable  
            Session["username"] = txtUsername.Text;
        }
        // Checking Session variable is not empty  
        if (Session["username"] != null)
        {
            // Displaying stored email  
            Label3.Text = "This username is stored to the session.";
            Label4.Text = Session["username"].ToString();
        }
    }

}