using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeC_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            String name = Request.QueryString["UserName"];
            if(name == null || name.Length == 0)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
                Label1.Text = "Welcome " + name;
            }
            
        }

        protected void LOGOUT(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");

        }
    }
}