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
    public partial class AsignarDocente : System.Web.UI.Page
    {
        Dictado dictado = new Dictado(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("AsignarDocente");
            if (!IsPostBack)
            {
                gvAsignaciones.DataSource = DictadoLogic.GetInstance().GetAll();
                gvAsignaciones.DataBind();
                if( Request.QueryString["id"] != null)
                {
                    txtIdCurso.Value = Request.QueryString["id"];
                }
                foreach (var item in UsuarioLogic.GetInstance().GetAll(2))
                {
                    ListItem listItem = new ListItem();
                    listItem.Value = item.IdPersona.ToString();
                    listItem.Text = item.NombreCompletoLegajo;
                    ddlDocente.Items.Add(listItem);

                }
                lblAction.Text = "Asignar Curso " + Request.QueryString["id"];

            }
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            bool ok = true; 
            if(! Validations.ValidateInput( ddlDocente.SelectedValue ))
            {
                ok = false;
            }
            if( !Validations.ValidateInput( txtIdCurso.Value ))
            {
                ok = false;
            }

            if( !Validations.ValidateInput( ddlCargo.SelectedValue ))
            {
                ok = false;
            }

            if (ok)
            {
                dictado.IdCurso = Convert.ToInt32(txtIdCurso.Value);
                dictado.IdDocente = Convert.ToInt32(ddlDocente.SelectedValue);
                dictado.Cargo = Convert.ToInt32(ddlCargo.SelectedItem.Value);
                var dic = DictadoLogic.GetInstance().GetOne(dictado);
                if( dic== null)
                {                                       
                    dictado.State = BusinessEntity.States.New;
                    DictadoLogic.GetInstance().Save(dictado);
                    Response.Redirect("Cursos.aspx");
                }
                else
                {
                    lblError.Text = "Este docente ya está asignado a este curso con el mismo cargo!!!";
                    lblError.Visible = true;
                }
            }
        }
    }
}