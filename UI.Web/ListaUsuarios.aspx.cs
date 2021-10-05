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

            if (Session["current_user"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
                var user = ((Usuario)Session["current_user"]);

            }
            Boolean editionState = this.PaginaEnEstadoEdicion();
            if (editionState)
            {
                this.lblAccion.Text = "edition";
                btnGuardar.Text = "Actualizar";
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
            currentUser.Email = txtEmail.Text;
            currentUser.FechaNac = Convert.ToDateTime(txtFechaNacimiento.Value);
            currentUser.Direccion = txtDirección.Text;
            currentUser.Telefono = txtTelefono.Text;
            currentUser.Legajo = Convert.ToInt32(txtNroDocumento.Text);
            currentUser.TipoPersona = Convert.ToInt32(tipoPersona.SelectedValue);
            currentUser.IdPlan = 16;
            currentUser.NombreUsuario = txtNombreUsuario.Text;
            currentUser.Clave = txtClave.Text;
            currentUser.Habilitado = true;


            //hacer lo mismo para todo ....
            currentUser.State = BusinessEntity.States.New;

            // llamar al metodo agregar Usuario
            UsuarioLogic.GetInstance().Save(currentUser);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}