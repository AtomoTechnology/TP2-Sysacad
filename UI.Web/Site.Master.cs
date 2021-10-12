using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ValidateAcess();
        }
        protected void ValidateAcess(string path = "")
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("SignIn.aspx");
            }

        }
    }
}