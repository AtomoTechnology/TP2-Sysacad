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
    public partial class MisCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["current_user"] != null)
            {

                 var user = (Usuario)Session["current_user"];
                gvMisCursos.DataSource = DictadoLogic.GetInstance().GetAll(user.IdPersona);
                gvMisCursos.DataBind();
            }
        }
    }
}