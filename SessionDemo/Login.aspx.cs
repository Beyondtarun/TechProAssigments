using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeC_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LOGIN(object sender, EventArgs e)
        {
            if(Textbox2.Text.ToString() == "pass" && Textbox1.Text != null) {
                Session["UserName"] = Textbox1.Text.ToUpper();
                Response.Redirect("WebForm2.aspx?UserName=" + Textbox1.Text.ToString()) ;

            }
            else
            {
                Label1.Text = "WRONG PASSWORD"; 
            }

        }
    }
}