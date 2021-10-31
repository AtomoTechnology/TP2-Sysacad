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
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            signInFailedBox.Visible = false ;

            if (Session["current_user"] != null)
            {
                Response.Redirect("Index.aspx");

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            Usuario user = UsuarioLogic.GetInstance().LogIn(txtUsuarname.Text, txtPassword.Value);
            if( user != null)
            {
                Session["current_user"] = user;
                Response.Redirect("Index.aspx");
            }
            else
            {
                signInFailedBox.Visible = true;              
                lblSignInFailed.Text = "Ouup!!! Nombre Usuario/Clave Incorrecto...";
                //Response.Write("No existe el usuario");
            }
        }
    }
}