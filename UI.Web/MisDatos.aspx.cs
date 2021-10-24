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
    public partial class MisDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack)
            {
                if( Session["current_user"] != null)
                {                    
                    this.FillData(UsuarioLogic.GetInstance().GetOne(((Usuario)Session["current_user"]).ID));                    
                }
            }
        }


        private void FillData( Usuario usuario)
        {
           
        }
    }
}