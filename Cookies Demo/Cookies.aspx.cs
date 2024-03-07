using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeC_
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user");
            cookie["username"] = TextBox1.Text;
            cookie.Expires = DateTime.Now.AddDays(2); // DateTime method makes cookie persistent 
            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm4.aspx");
        }
    }
}