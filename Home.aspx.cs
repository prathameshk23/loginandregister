﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginandregister
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                String strUser = Session["User"].ToString();
                Label1.Text = strUser;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("LoginPage.aspx");
        }
    }
}