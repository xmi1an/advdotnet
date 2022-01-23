using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = 5, b = 0;
        int sum = a / b;
        Response.Write(sum);
       
    }
}