using System;
using System.Text;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            //saving the file in C Drive.
            FileUpload1.SaveAs("C://temp/" + FileUpload1.FileName);
         
            //saving the file in Website Directory.
            //FileUpload1.SaveAs(Server.MapPath("~/Files/") + FileUpload1.FileName);

        }
        else
        {
            lblmessage.Text = "No File Selected";
        }
    }
}