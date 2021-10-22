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
    public partial class Cursos : System.Web.UI.Page
    {
        Curso curso = new Curso();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.LoadCursos();
                if(PaginaEnEstadoEdicion())
                {
                    this.LoadFields(Convert.ToInt32(Request.QueryString["id"]));
                }
            }

        }

        private void LoadFields(int v)
        {
             curso = CursoLogic.GetInstance().GetOne(v);
            if((curso != null))
            {
                txtAnioCalendario.Text = curso.AnioCalendario.ToString();
                txtCupo.Text = curso.Cupo.ToString();
                ddlComisiones.SelectedValue = curso.IdComision.ToString();
                ddlMateria.SelectedValue = curso.IdMateria.ToString();
                btnAgregarCurso.Text = "Actaulizar";
                lblAction.Text = "Editar curso " + curso.ID;
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
        private void LoadCursos()
        {
            dgvCursos.DataSource = CursoLogic.GetInstance().GetAll();
            dgvCursos.DataBind();
            ddlComisiones.DataSource = ComisionLogic.GetInstance().GetAll();
            ddlComisiones.DataBind();
            ddlMateria.DataSource = MateriaLogic.GetInstance().GetAll();
            ddlMateria.DataBind();
        }

        protected void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!Validations.ValidateInput(txtAnioCalendario.Text))
            {
                ok = false;
                lblAnioCalendarioError.Visible = true;
            }
            else
            {
                lblAnioCalendarioError.Visible = false;

            }
            if (!Validations.ValidateInput(txtCupo.Text))
            {
                ok = false;
                lblCupoError.Visible = true;
            }
            else
            {
                lblCupoError.Visible = false;

            }
            if (ok)
            {
                curso.AnioCalendario = Convert.ToInt32(txtAnioCalendario.Text);
                curso.Cupo = Convert.ToInt32(txtCupo.Text);
                curso.IdComision = Convert.ToInt32(ddlComisiones.SelectedValue);
                curso.IdMateria = Convert.ToInt32(ddlMateria.SelectedValue);
                if(PaginaEnEstadoEdicion())
                {
                    curso.ID = Convert.ToInt32(Request.QueryString["id"]);
                    curso.State = BusinessEntity.States.Modified;
                }
                else
                {
                    curso.State = BusinessEntity.States.New;
                }

                CursoLogic.GetInstance().Save(curso);
                Response.Redirect("Cursos.aspx");
            }
        }
    }
}