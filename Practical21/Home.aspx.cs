using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "In Session Variable : " + Session["username"].ToString();
        Label2.Text = "In Cookies Variable : " + Request.Cookies["username"].Value.ToString();
    }
}