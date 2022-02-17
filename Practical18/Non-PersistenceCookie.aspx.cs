using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Non_PersistenceCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sname = Response.Cookies["name"].Value = "Peter";

        Label1.Text = sname.ToString();
    }
}