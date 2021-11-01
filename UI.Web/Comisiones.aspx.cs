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
    public partial class Comisiones : System.Web.UI.Page 
    {
        Comision comision = new Comision();
        protected void Page_Load(object sender, EventArgs e) 
        {
            Methods.ValidatePermission("Comisiones");
            if( !IsPostBack)
            {
                if (Methods.PaginaEnEstadoEdicion())
                {
                   comision =  ComisionLogic.GetInstance().GetOne(Convert.ToInt32(Request.QueryString["id"]));
                    txtDesc.Value = comision.DescComision;
                    txtAno.Value = comision.AnioEspecialidad.ToString();
                    ddlPlanes.SelectedValue = comision.IdPlan.ToString();
                    this.lblAccionHead.Text = "Editar Comision " + comision.ID ;
                    btnAddComision.Text = "Actualizar";

                }
            }
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

                if(Methods.PaginaEnEstadoEdicion())
                {
                    comision.ID =Convert.ToInt32(Request.QueryString["id"]);
                    comision.State = BusinessEntity.States.Modified;

                }
                else
                {
                    comision.State = BusinessEntity.States.New;

                }
                ComisionLogic.GetInstance().Save(comision);
                Response.Redirect("Comisiones.aspx");
            }
            else
            {
                errorBox.Visible = true;
                errorBox.InnerText = error;
            }
        }

        protected void gvComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComisionLogic.GetInstance().Delete(Convert.ToInt32(gvComisiones.SelectedValue));
            Response.Redirect("Comisiones.aspx");

        }
    }
}