﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_User : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        logout.ServerClick += Logout_ServerClick;
    }
    private void Logout_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Session["typeid"] = null;
        Response.Redirect("~/Login/Login.aspx");
    }
}
