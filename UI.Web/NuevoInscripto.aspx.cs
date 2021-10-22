using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class NuevoInscripto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadAlumnosCursos();
        }

        private void LoadAlumnosCursos()
        {
            ddlAlumno.DataSource = UsuarioLogic.GetInstance().GetAll( 3 );
            ddlAlumno.DataBind();
            ddlAlumno.DataTextField = "Legajo";
            ddlAlumno.DataValueField = "ID";
            ddlCurso.DataSource = CursoLogic.GetInstance().GetAll();
            ddlCurso.DataBind();
            ddlCurso.DataTextField = "ID";
            ddlCurso.DataValueField = "ID";
           
        }
    }
}