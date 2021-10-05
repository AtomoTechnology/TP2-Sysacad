using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_persona"] != null)
            {
                Response.Redirect("index.aspx");

            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = UsuarioLogic.GetInstance().LogIn(txtUsername.Value, txtPassword.Value);
            if (user != null)
            {
                Session["current_user"] = user;
                Response.Redirect("index.html");
                //Session.RemoveAll();
            }
            else
            {
                Response.Write("No existe el usuario");
            }
        }
    }
}