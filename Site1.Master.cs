using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicobox
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    Logout.Visible = true;
                }
                else
                {
                    Login.Visible = true;
                }

                if ((string)Session["User"] == "Admin")
                {
                    Admin.Visible = true;
                }
                else
                {
                    Admin.Visible = false;
                }
            }

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}