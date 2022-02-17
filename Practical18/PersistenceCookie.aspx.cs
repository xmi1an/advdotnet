using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersistenceCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
// Persistence Cookie
// This types of cookies are permanently stored on user hard drive.
// Cookies which have an expiry date time are called persistence cookes.
// This types of cookies stored user hard drive permenently till the date time we set.

        // Example to create persistence cookie
        string sname =  Response.Cookies["name"].Value = "Peter";
        Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);

        Label1.Text = sname.ToString();
    }
}