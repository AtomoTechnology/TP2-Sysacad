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
    public partial class MateriasInscriptas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usr = Methods.ValidatePermission("MateriasInscriptas");
            if (!IsPostBack)
            {
                this.gvMateriasInscriptas.AutoGenerateColumns = false;
                this.gvMateriasInscriptas.DataSource = InscripcionLogic.GetInstance().GetAll(null, usr.IdPersona, null, null);
                this.gvMateriasInscriptas.DataBind();
            }
        }
    }
}