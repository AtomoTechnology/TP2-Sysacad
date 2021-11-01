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
    public partial class MisDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario  usr = Methods.ValidatePermission("MisDatos");
            if (!IsPostBack)
            {             
                if (Session["current_user"] != null)
                {
                    this.FillData(UsuarioLogic.GetInstance().GetOne(usr.ID));
                }
            }
        }


        private void FillData(Usuario usuario)
        {
            if (usuario != null)
            {
                txtApellido.Value = usuario.Apellido;
                txtNombre.Value = usuario.Nombre;
                txtUsuario.Value = usuario.NombreUsuario;
                txtTelefono.Value = usuario.Telefono;
                txtLegajo.Value = usuario.Legajo.ToString();
                txtDireccion.Value = usuario.Direccion;
                txtEmail.Value = usuario.Email;
                txtPassword.Value = "..........";
                lblNombreCompleto.Text = usuario.Apellido + "   " + usuario.Nombre;
                if (usuario.TipoPersona == 3)
                {
                    userBoxmateria1.Visible = true;
                    userBoxmateria2.Visible = true;
                    itemMateria.Visible = true;
                    List<Inscripcion> ins = InscripcionLogic.GetInstance().GetMateriasAprobadasAlumnos(usuario.IdPersona);
                    if (ins.Count > 0)
                    {
                        lblCantMatApro.Text = ins.Count.ToString();
                        gvMaterias.AutoGenerateColumns = false;
                        lblCantidadMateriasAprobadass.Text = ins.Count.ToString();
                        gvMaterias.DataSource = ins;
                        gvMaterias.DataBind();
                    }
                    else
                    {

                        lblCantidadMateriasAprobadass.Text = "0";
                        lblCantMatApro.Text ="0" ;
                    }

                }
                else
                {
                    userBoxmateria1.Visible = false;
                    userBoxmateria2.Visible = false;
                   
                }
            }

        }

        protected void btnVerEmail_Click(object sender, EventArgs e)
        {

        }
    }
}