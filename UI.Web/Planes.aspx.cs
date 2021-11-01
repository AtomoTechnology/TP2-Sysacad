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
    public partial class Planes : System.Web.UI.Page
    {
        Plan current_plan;
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("Planes");
            if (!IsPostBack)
            {
                if (Methods.PaginaEnEstadoEdicion())
                {
                    current_plan = PlanLogic.GetInstance().GetOne(Convert.ToInt32(Request.QueryString["id"]));
                    txtDescPlan.Text = current_plan.DescPlan;
                    ddlEspecialidades.SelectedValue = current_plan.IdEspecialidad.ToString();
                    lblAccion.Text = "Edicion Plan " + current_plan.ID;
                    bntAddPlan.Text = "Actualizar";
                }

            }
        }
        protected void bntAddPlan_Click(object sender, EventArgs e)
        {
            Boolean ok = true;
            if (txtDescPlan.Text == "")
            {
                txtDescPlan.Style.Add(HtmlTextWriterStyle.BorderColor, "red");
                ok = false;
            }
            else
            {
                txtDescPlan.Style.Remove(HtmlTextWriterStyle.BorderColor);
                txtDescPlan.Style.Add(HtmlTextWriterStyle.BorderColor, "green");
            }

            if (ok)
            {
                current_plan = new Plan();
                current_plan.DescPlan = txtDescPlan.Text;
                current_plan.IdEspecialidad = Convert.ToInt32(ddlEspecialidades.SelectedValue);
                if (Methods.PaginaEnEstadoEdicion())
                {
                    current_plan.ID = Convert.ToInt32(Request.QueryString["id"]);
                    current_plan.State = BusinessEntity.States.Modified;
                }
                else
                {
                    current_plan.State = BusinessEntity.States.New;
                }
                PlanLogic.GetInstance().Save(current_plan);
                Response.Redirect("Planes.aspx");
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanLogic.GetInstance().Delete(Convert.ToInt32(GridView1.SelectedValue));
            Response.Redirect("Planes.aspx");

        }
    }
}