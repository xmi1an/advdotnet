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
        string User_Name = Response.Cookies["userName"].Value = "Annathurai"; ;
        string User_Color = Response.Cookies["userColor"].Value = "Black";


        Response.Write(User_Name);
        Response.Write(User_Color);

    }
}