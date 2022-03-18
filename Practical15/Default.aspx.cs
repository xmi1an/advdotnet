using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        count = int.Parse(HiddenField1.Value);
        count += 1;
        Response.Write("Hit Count : " + count);
        HiddenField1.Value = count.ToString();
    }
}