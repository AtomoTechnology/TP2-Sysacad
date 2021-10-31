using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Web.Helpers
{
    public class Methods
    {
        public static  bool PaginaEnEstadoEdicion()
        {
            
            if (HttpContext.Current.Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Usuario ValidatePermission(string path)
        {
            if (HttpContext.Current.Session["current_user"] == null)
            {
                HttpContext.Current.Response.Redirect("SignIn.aspx");
                return null;
            }
            else
            {
                var user = ((Usuario)HttpContext.Current.Session["current_user"]);
                if( user.TipoPersona == 3 )
                {
                    if( path != "MisDatos" && path != "NuevoInscripto" && path != "UserMateria")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                else if(user.TipoPersona == 2)
                {
                    if (path != "MisDatos" && path != "MisCursos" && path != "RegistrarNota")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                else
                {
                    if (path == "UserMateria")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                return user;
            }
        }
    }
}