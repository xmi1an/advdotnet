using System;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    result r = new result();
    protected void btnOne_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "1";
    }
    protected void btnTwo_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "2";
    }
    protected void btnThree_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "3";
    }
    protected void btnFour_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "4";
    }
    protected void btnFive_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "5";
    }
    protected void btnSix_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "6";
    }
    protected void btnSeven_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "7";
    }
    protected void btnNine_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "9";
    }
    protected void btnZero_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "0";
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        if (txtanswer.Text == string.Empty)
        {
            Response.Write("<script>alert('No input values provided')</script>");
        }
        else
        {
            Session["Val"] = txtanswer.Text;
            Session["Sign"] = "add";
            txtanswer.Text = string.Empty;
        }
    }
    protected void Sub_Click(object sender, EventArgs e)
    {
        if (txtanswer.Text == string.Empty)
        {
            Response.Write("<script>alert('No inpt values provided')</script>");
        }
        else
        {
            Session["Val"] = txtanswer.Text;
            Session["Sign"] = "subtract";
            txtanswer.Text = string.Empty;
        }
    }
    protected void Multiply_Click(object sender, EventArgs e)
    {
        if (txtanswer.Text == string.Empty)

        {
            Response.Write("<script>alert('No input values provided')</script>");
        }
        else
        {
            Session["Val"] = txtanswer.Text;
            Session["Sign"] = "multiply";
            txtanswer.Text = string.Empty;
        }
    }
    protected void Divide_Click(object sender, EventArgs e)
    {
        if (txtanswer.Text == string.Empty)
        {
            Response.Write("<script>alert('No input values provided')</script>");
        }
        else
        {
            Session["Val"] = txtanswer.Text;
            Session["Sign"] = "divide";
            txtanswer.Text = string.Empty;
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (txtanswer.Text == string.Empty)
        {
            Response.Write("<script>alert('You did not specified inputs')</script>");
        }
        else
        {
            Session["Val1"] = txtanswer.Text;
            txtanswer.Text = string.Empty;
            if (Session["Sign"].ToString() == "add")
            {
                txtanswer.Text = r.add(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();
            }
            else if (Session["Sign"].ToString() == "subtract")
            {
                txtanswer.Text = r.subtract(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();
            }
            else if (Session["Sign"].ToString() == "multiply")
            {
                txtanswer.Text = r.multiply(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();
            }
            else if (Session["Sign"].ToString() == "divide")
            {
                txtanswer.Text = r.divide(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();
            }
            else
            {
                Response.Write("<script>alert('No operation was recorded')</script>");
            }
        }
    }
    protected void btnEight_Click(object sender, EventArgs e)
    {
        txtanswer.Text = txtanswer.Text + "8";
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtanswer.Text = string.Empty;
    }

}
public class result
{
    public int add(int value1, int value2)
    {
        return (value1 + value2);
    }
    public int subtract(int value1, int value2)
    {
        return (value1 - value2);
    }
    public int multiply(int value1, int value2)
    {
        return (value1 * value2);
    }
    public int divide(int value1, int value2)
    {
        return (value1 / value2);
    }
}