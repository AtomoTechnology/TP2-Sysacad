using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Web.Helpers;

namespace UI.Web
{
    public partial class Users : System.Web.UI.Page
    {

        Usuario currentUser = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("Users");
            if (!IsPostBack)
            {
                error.Visible = false;
                if (Methods.PaginaEnEstadoEdicion())
                {
                    CargarUsuario(Convert.ToInt32(Request.QueryString["id"]));
                    password.Visible = false;
                    passwordConfirm.Visible = false;
                }
                else
                {
                    this.lblAccion.Text = "Alta";
                }

            }
        }
        private void CargarUsuario(int idUsuario)
        {
            currentUser = UsuarioLogic.GetInstance().GetOne(idUsuario);
            if (currentUser != null)
            {
                txtApellido.Text = currentUser.Apellido;
                txtNombre.Text = currentUser.Nombre;
                txtEmail.Text = currentUser.Email;
                txtFechaNacimiento.Value = currentUser.FechaNac.ToString();
                txtDirección.Text = currentUser.Direccion;
                txtTelefono.Text = currentUser.Telefono;
                txtNroDocumento.Text = currentUser.Legajo.ToString();
                tipoPersona.SelectedValue = currentUser.TipoPersona.ToString();
                ddlPlanes.SelectedValue = currentUser.IdPlan.ToString();
                txtNombreUsuario.Text = currentUser.NombreUsuario;
                txtClave.Text = currentUser.Clave;
                txtIdPersona.Value = currentUser.IdPersona.ToString();
                chkHabilitado.Checked = currentUser.Habilitado;
                this.lblAccion.Text = "Edicion Usuario ID : " + idUsuario;
                btnGuardar.Text = "Actualizar";
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string errors = "";
            bool ok = true;
            if (!Validations.ValidateInput(txtApellido.Text))
            {
                ok = false;
                errors += "Apellido Obligatorio  \n";
                errorApellido.Visible = true;
            }
            else
            {
                errorApellido.Visible = false;

            }
            if (!Validations.ValidateInput(txtNroDocumento.Text))
            {
                ok = false;
                errors += "Nro Documento Obligatorio\n";
                errorLegajo.Visible = true;
            }
            else
            {
                errorLegajo.Visible = false;
            }
            if (!Validations.ValidateInput(txtNombre.Text))
            {
                ok = false;
                errors += "Nombre Obligatorio\n";
                errorNombre.Visible = true;
            }
            else
            {
                errorNombre.Visible = false;
            }
            if (!Methods.PaginaEnEstadoEdicion())
            {
                if (!Validations.ValidateInput(txtClave.Text))
                {
                    ok = false;
                    errors += "Clave Obligatorio \n";
                    errorClave.Visible = true;
                }
                else
                {
                    errorClave.Visible = false;
                }
                if (!Validations.ValidateInput(txtConfirmarClave.Text) || txtConfirmarClave.Text != txtClave.Text)
                {
                    ok = false;
                    errors += "Confirmar clave Obligatorio\n";
                    errorConfirmClave.Visible = true;
                }
                else
                {
                    errorConfirmClave.Visible = false;
                }
            }

            if (!Validations.ValidateInput(txtFechaNacimiento.Value))
            {
                ok = false;
                errors += "Fecha de Nacimiento Obligatorio\n";
            }
            if (!Validations.ValidateInput(txtNombreUsuario.Text))
            {
                ok = false;
                errors += "Nombre de usuario Obligatorio\n";
                errorNombreUsuario.Visible = true;
            }
            else
            {
                errorNombreUsuario.Visible = false;
            }
            if (!Validations.ValidateEmail(txtEmail.Text))
            {
                ok = false;
                errors += "Email Obligatorio y debe ser valido\n";
                errorEmail.Visible = true;
            }
            else
            {
                errorEmail.Visible = false;
            }

            if (ok)
            {
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

                //hacer lo mismo para todo ....
                if (Methods.PaginaEnEstadoEdicion())
                {
                    currentUser.Habilitado = chkHabilitado.Checked;
                    currentUser.IdPersona = Convert.ToInt32(txtIdPersona.Value);
                    currentUser.ID = Convert.ToInt32(Request.QueryString["id"]);
                    currentUser.State = BusinessEntity.States.Modified;
                }
                else
                {
                    currentUser.Clave = Methods.Encriptar(txtClave.Text);
                    currentUser.Habilitado = true;
                    currentUser.State = BusinessEntity.States.New;
                }
                UsuarioLogic.GetInstance().Save(currentUser);
                Page.Response.Redirect("Users.aspx");
            }
        }
    }
}