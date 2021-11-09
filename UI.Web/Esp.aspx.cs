using Business.Logic;
using System;
using Business.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Web.Helpers;

namespace UI.Web
{
    public partial class Esp : System.Web.UI.Page
    {
        Especialidad esp = new Especialidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("Esp");
            if (!IsPostBack)
            {               
                errorDesc.Visible = false;
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
                            btnUpdateEsp.Text = "Actualizar";

                        }
                    }
                }
            }

        }

        protected void btnUpdateEsp_Click(object sender, EventArgs e)
        {
            if (!Validations.ValidateInput(txtDesc.Value))
            {
                errorDesc.Visible = true;
                errorDesc.Text = "Descripcion obligatoria";
            }
            else
            {
                errorDesc.Visible = false;
                esp.desc_especialidad = txtDesc.Value;
                if(Methods.PaginaEnEstadoEdicion())
                {
                    esp.ID = Convert.ToInt32(Request.QueryString["id"]);
                    esp.State = BusinessEntity.States.Modified;

                }
                else
                {
                    esp.State = BusinessEntity.States.New;
                }
                EspecialidadLogic.GetInstance().Save(esp);
                Response.Redirect("Especialidades.aspx");

            }

        }
    }
}