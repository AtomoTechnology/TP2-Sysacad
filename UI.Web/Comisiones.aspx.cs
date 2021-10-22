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
    public partial class Comisiones : System.Web.UI.Page 
    {
        Comision comision = new Comision();
        protected void Page_Load(object sender, EventArgs e) 
        {
            
        }

        protected void btnAddComision_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string error = "";
            if (!Validations.ValidateInput(txtDesc.Value))
            {
                ok = false;
                error += "Descripcion vacio | ";
            }
            if (!Validations.ValidateInput(txtAno.Value))
            {
                ok = false;
                error += "Año vacio  ";

            }
            if (ok)
            {
                comision.DescComision = txtDesc.Value;
                comision.AnioEspecialidad = Convert.ToInt32(txtAno.Value);
                comision.IdPlan = Convert.ToInt32(ddlPlanes.SelectedValue);
                comision.State = BusinessEntity.States.New;
                ComisionLogic.GetInstance().Save(comision);
                Response.Redirect("Comisiones.aspx");
            }
            else
            {
                errorBox.InnerText = error;
            }
        }
    }
}