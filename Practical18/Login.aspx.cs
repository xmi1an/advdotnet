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
            string User_Name = Response.Cookies["userName"].Value = txtUsername.Text;
            Response.Write(User_Name);
        }
    }
}