﻿using Business.Logic;
using System;
using Business.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Esp : System.Web.UI.Page
    {
        Especialidad esp = new Especialidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["current_user"] == null)
                {
                    Response.Redirect("SignIn.aspx");
                }

                if (Request.QueryString["id"] != null)
                {
                    if (Request.QueryString["type"] != null)
                    {
                        EspecialidadLogic.GetInstance().DeleteOne(Convert.ToInt32(Request.QueryString["id"]));
                        Response.Redirect("Especialidades.aspx");

                    }
                    else
                    {
                        esp = EspecialidadLogic.GetInstance().GetOne(Convert.ToInt32(Request.QueryString["id"]));
                        lblId.Text = "Editar/Borrar especialidad con id = " + esp.ID;
                        if (esp != null)
                        {
                            txtDesc.Value = esp.desc_especialidad;

                        }
                    }
                }
            }

        }

        protected void btnUpdateEsp_Click(object sender, EventArgs e)
        {
            esp.desc_especialidad = txtDesc.Value;
            esp.ID = Convert.ToInt32(Request.QueryString["id"]);
            esp.State = BusinessEntity.States.Modified;
            EspecialidadLogic.GetInstance().Save(esp);

        }
    }
}