using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text == "1234")
        {
            // Storing username to Session variable.
            Session["username"] = txtUsername.Text;

            // Storing username to Cookies variable.
            Response.Cookies["username"].Value = txtUsername.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(1);
            Response.Redirect("Home.aspx");
        }
    }
}