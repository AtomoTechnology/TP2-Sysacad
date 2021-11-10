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
    public partial class ddlplanes : System.Web.UI.UserControl
    {
        private int idPlan;

        public int IDPlan
        {
            get { return Convert.ToInt32(ddlPlan.SelectedValue); }
            set { idPlan = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            ddlPlan.DataSource = PlanLogic.GetInstance().GetAll();
            ddlPlan.DataBind();
        }
    }
}