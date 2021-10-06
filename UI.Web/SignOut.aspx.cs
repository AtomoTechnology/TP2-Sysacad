using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class SignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Session["current_user"] != null)
            {
                Session.Remove("current_user");
                Session["current_user"] = null;
                //Response.Redirect("SignIn.aspx");
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }
        }
    }
}