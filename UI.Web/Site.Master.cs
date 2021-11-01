using Business.Entities;
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
            if(Session["current_user"] != null)
            {
                Usuario usr = (Usuario)Session["current_user"];
                username.Text = usr.NombreUsuario;
                    switch (usr.TipoPersona)
                    {
                    case 1:
                        menuAdmin.Visible = true;
                        menuAdmin2.Visible = true;
                        break;
                    case 2:
                        menuDocente.Visible = true;
                        break;
                    case 3:
                        menuAlumno.Visible = true;
                        break;
                        default:
                            break;
                    }
            }
        }
      
       
       
    }
}