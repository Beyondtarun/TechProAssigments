﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringDemoCSharp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Request.QueryString["firstname"];
            string lastname = Request.QueryString["lastname"];
            Label1.Text = "Hi , Welcome " + firstname + " " + lastname;
        }

    }
}


