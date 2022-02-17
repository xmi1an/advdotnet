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

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        try { 
        int a = int.Parse(TextBox1.Text);
        int b = int.Parse(TextBox2.Text);
        int res = a / b;
        
        Label1.Text = res.ToString();
        Label1.Visible = true;

        }
        catch (Exception exc)
        {
            Label1.Text = exc.Message;
            Label1.Visible = true;
        }


    }
}