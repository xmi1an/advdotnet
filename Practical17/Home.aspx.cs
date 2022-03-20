using System;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Welcome " + Session["username"].ToString();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("login.aspx");
    }
}