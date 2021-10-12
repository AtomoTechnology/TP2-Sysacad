﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Planes : System.Web.UI.Page
    {
        Plan current_plan;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["current_user"] == null)
                {
                    Response.Redirect("SignIn.aspx");
                }


                if (PaginaEnEstadoEdicion())
                {
                    current_plan = PlanLogic.GetInstance().GetOne(Convert.ToInt32(Request.QueryString["id"]));
                    txtDescPlan.Text = current_plan.DescPlan;
                    ddlEspecialidades.SelectedValue = current_plan.IdEspecialidad.ToString();
                    lblAccion.Text = "Edicion";
                    bntAddPlan.Text = "Actualizar";
                }

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
                current_plan.ID = Convert.ToInt32(Request.QueryString["id"]);
                current_plan.DescPlan = txtDescPlan.Text;
                current_plan.IdEspecialidad = Convert.ToInt32(ddlEspecialidades.SelectedValue);
                if (PaginaEnEstadoEdicion())
                {
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

        protected void txtDescPlan_TextChanged(object sender, EventArgs e)
        {
            this.Label1.Text = this.txtDescPlan.Text;
        }
    }
}