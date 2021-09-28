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
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        Usuario currentUser = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            Boolean editionState = this.PaginaEnEstadoEdicion();
            if (editionState)
            {
                this.lblAccion.Text = "edition";
            }
            else
            {
                this.lblAccion.Text = "Alta";
            }
        }
        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            currentUser.Apellido = txtApellido.Text;
            currentUser.Nombre = txtNombre.Text;
            //hacer lo mismo para todo ....
            currentUser.State = BusinessEntity.States.New;

            // llamar al metodo agregar Usuario
            UsuarioLogic.GetInstance().Save(currentUser);
        }
    }
}