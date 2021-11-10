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
    public partial class NuevoInscripto : System.Web.UI.Page
    {
        Inscripcion ins = new Inscripcion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("NuevoInscripto");
            if (!IsPostBack)
            {
                this.LoadAlumnosCursos();
                if (Methods.PaginaEnEstadoEdicion())
                {
                    ddlAlumno.Enabled = false;
                    ddlCurso.Enabled = false;
                    otherFields.Visible = true;
                    this.LoadFields(Convert.ToInt32(Request.QueryString["id"]));
                }
            }
        }

        private void LoadFields(int id)
        {
            ins = InscripcionLogic.GetInstance().GetOne(id);
            if (ins != null)
            {
                ddlAlumno.SelectedValue = ins.IdAlumno.ToString();
                ddlCurso.SelectedValue = ins.IdCurso.ToString();
                txtNota.Text = ins.Nota.ToString();
                ddlCondicion.SelectedValue = ins.Condicion;
                btnInscribir.Text = "Actualizar Curso";
                lblAction.Text = " Actualizar Inscripcion " + id;
            }
        }
        private void LoadAlumnosCursos()
        {          
            foreach (var item in UsuarioLogic.GetInstance().GetAll(3))
            {
                ListItem listItem = new ListItem();
                listItem.Value = item.IdPersona.ToString();
                listItem.Text =  item.NombreCompletoLegajo ;
                ddlAlumno.Items.Add(listItem);

            }           
            foreach (var item in CursoLogic.GetInstance().GetAllWithCupo())
            {
                ListItem listItem = new ListItem();
                listItem.Value =item.ID.ToString();
                listItem.Text = item.DescComision +  " | " + item.DescMateria + " | Cupo :  " + item.Cupo ;               
                ddlCurso.Items.Add(listItem);

            }
            var user = (Usuario)Session["current_user"];
            if( user!= null  && user.TipoPersona == 3)
            {
                //ddlAlumno.SelectedItem.Value = user.IdPersona.ToString();
                ddlAlumno.SelectedValue = user.IdPersona.ToString();
                ddlAlumno.Enabled = false;
            }

        }     
              
             

        protected void btnInscribir_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!Validations.ValidateInput(ddlAlumno.SelectedValue))
            {
                ok = false;
            }
            if (!Validations.ValidateInput(ddlCurso.SelectedValue))
            {
                ok = false;
            }

            if (ok)
            {
                ins.IdAlumno = Convert.ToInt32(ddlAlumno.SelectedValue);
                ins.IdCurso = Convert.ToInt32(ddlCurso.SelectedItem.Value);
                if (Methods.PaginaEnEstadoEdicion())
                {
                    ins.Condicion = ddlCondicion.SelectedItem.Value;
                    ins.Nota = Convert.ToInt32(txtNota.Text);
                    ins.ID = Convert.ToInt32(Request.QueryString["id"]);
                    ins.State = BusinessEntity.States.Modified;
                }
                else
                {
                    
                    ins.Condicion = "Cursando";
                    ins.State = BusinessEntity.States.New;
                }

                InscripcionLogic.GetInstance().Save(ins);
                Response.Redirect("Inscripciones.aspx");
            }
        }

        protected void ddlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {            
           ins.CursoCupo = CursoLogic.GetInstance().GetOne(Convert.ToInt32(ddlCurso.SelectedValue)).Cupo;           
        }
    }
}