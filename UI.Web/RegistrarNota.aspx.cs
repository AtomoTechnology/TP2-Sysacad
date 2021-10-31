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
    public partial class RegistrarNota : System.Web.UI.Page
    {
        Usuario usr;
        protected void Page_Load(object sender, EventArgs e)
        {
             usr = Methods.ValidatePermission("RegistrarNota");
            if (!IsPostBack)
            {
                this.gvInscripciones.AutoGenerateColumns = false;
                this.ddlComisiones.DataSource = ComisionLogic.GetInstance().GetAll();
                ddlComisiones.DataBind();
                this.ddlMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
                ddlMaterias.DataBind();
                this.LoadGridIns(usr);
             
            }
        }
        private void LoadGridIns(Usuario usr)
        {
            this.gvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(usr.IdPersona, null);
            gvInscripciones.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.gvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(usr.IdPersona, null, Convert.ToInt32(ddlComisiones.SelectedValue), Convert.ToInt32(ddlMaterias.SelectedValue));
            gvInscripciones.DataBind();
        }
    }

    
}