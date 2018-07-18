﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SellerHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Master.Logout = true;
            Master.Login = false;
            Master.Signup = false;
            Master.Profile = true;
            Master.lbl_Profile = Session["userName"].ToString();
        }

        protected void btnVerifiedProp_Click(object sender, EventArgs e)
        {

        }

        protected void btnDeactivatedProp_Click(object sender, EventArgs e)
        {

        }

        protected void btnAllProp_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddProp_Click(object sender, EventArgs e)
        {
            Response.Redirect("PostProperty.aspx");
        }
    }
}