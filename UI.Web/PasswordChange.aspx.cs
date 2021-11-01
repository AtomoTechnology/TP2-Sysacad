using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Web.Helpers;

namespace UI.Web
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        Usuario usr;
        protected void Page_Load(object sender, EventArgs e)
        {
            usr =  Methods.ValidatePermission("PasswordChange");

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if(! Validations.ValidateInput(txtPassword.Value))
            {
                this.errorChangePassword.Visible = true;
                errorChangePassword.Text = "escribe la contrasena paea seguir!!!";
            }
            else
            {
              Usuario  exist =   UsuarioLogic.GetInstance().LogIn(usr.NombreUsuario,Methods.Encriptar(txtPassword.Value));
                if(exist != null)
                {
                    Response.Redirect("NewPassword.aspx");
                }
                else
                {
                    this.errorChangePassword.Visible = true;
                    errorChangePassword.Text = "Contrseña incorrecto";

                }
            }
        }
    }
}