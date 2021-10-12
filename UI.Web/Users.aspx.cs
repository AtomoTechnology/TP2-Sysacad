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
    public partial class Users : System.Web.UI.Page
    {

        Usuario currentUser = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["current_user"] == null)
                {
                    Response.Redirect("SignIn.aspx");

                }
                else
                {
                    var user = ((Usuario)Session["current_user"]);

                }
                Boolean editionState = this.PaginaEnEstadoEdicion();
                if (editionState)
                {
                    currentUser = UsuarioLogic.GetInstance().GetOne(Convert.ToInt32(Request.QueryString["id"]));
                    if (currentUser != null)
                    {
                        txtApellido.Text = currentUser.Apellido;
                        txtNombre.Text = currentUser.Nombre;
                        txtEmail.Text = currentUser.Email;
                        txtFechaNacimiento.Value = currentUser.FechaNac.Date.ToString();
                        txtDirección.Text = currentUser.Direccion;
                        txtTelefono.Text = currentUser.Telefono;
                        txtNroDocumento.Text = currentUser.Legajo.ToString();
                        tipoPersona.SelectedValue = currentUser.TipoPersona.ToString();
                        ddlPlanes.SelectedValue = currentUser.IdPlan.ToString();
                        txtNombreUsuario.Text = currentUser.NombreUsuario;
                        txtClave.Text = currentUser.Clave;
                        txtIdPersona.Value = currentUser.IdPersona.ToString();
                        this.lblAccion.Text = "edition";
                        btnGuardar.Text = "Actualizar";
                    }

                }
                else
                {
                    this.lblAccion.Text = "Alta";
                }

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
            //    if (txtApellido.Text.Equals("") || txtClave.Text.Equals(""))
            //    {
            //        error.Text = " Asegurese que todos los campos con * tiene información";
            //    }
            //    else
            //{
            currentUser.Apellido = txtApellido.Text;
            currentUser.Nombre = txtNombre.Text;
            currentUser.Email = txtEmail.Text;
            currentUser.FechaNac = Convert.ToDateTime(txtFechaNacimiento.Value);
            currentUser.Direccion = txtDirección.Text;
            currentUser.Telefono = txtTelefono.Text;
            currentUser.Legajo = Convert.ToInt32(txtNroDocumento.Text);
            currentUser.TipoPersona = Convert.ToInt32(tipoPersona.SelectedValue);
            currentUser.IdPlan = Convert.ToInt32(ddlPlanes.SelectedValue);
            currentUser.NombreUsuario = txtNombreUsuario.Text;
            currentUser.Clave = txtClave.Text;
            currentUser.IdPersona = Convert.ToInt32(txtIdPersona.Value);
           
            currentUser.Habilitado = true;
            //hacer lo mismo para todo ....
            if (PaginaEnEstadoEdicion())
            {
                currentUser.ID = Convert.ToInt32(Request.QueryString["id"]);
                currentUser.State = BusinessEntity.States.Modified;

            }
            else
            {
                currentUser.State = BusinessEntity.States.New;

            }

            // llamar al metodo agregar Usuario
            UsuarioLogic.GetInstance().Save(currentUser);
            Page.Response.Redirect("Users.aspx");
            //}
        }
    }
}