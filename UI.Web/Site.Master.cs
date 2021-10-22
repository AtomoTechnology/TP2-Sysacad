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
        static Page resquest = new Page();
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
        public void Hello(string he)
        {

        }
        public static bool PaginaEnEstadoEdicion()
        {
            if (resquest.Request.QueryString["id"] != null)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}