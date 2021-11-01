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
    public partial class NewPassword : System.Web.UI.Page
    {
        Usuario usr;
        protected void Page_Load(object sender, EventArgs e)
        {
            usr = Methods.ValidatePermission("NewPassword");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateInput(txtPassword.Value)){
                this.errorChangePassword.Visible = true;
                errorChangePassword.Text = "Contrseña incorrecto";
            }
            else
            {
                UsuarioLogic.GetInstance().UpdatePassword(usr.ID, Methods.Encriptar(txtPassword.Value));
                Response.Redirect("MisDatos.aspx");
            }
        }
    }
}