using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeC_
{
    public partial class HiddenState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hiddentext.Value = DateTime.Now.ToString();
            Label1.Text = "Hidden field Value "+hiddentext.Value;
        }
    }
}