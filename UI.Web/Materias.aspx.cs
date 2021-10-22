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
    public partial class Materias : System.Web.UI.Page
    {
        Materia materia = new Materia();
        public int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set { this.ViewState["SelectedID"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                errorsBox.Visible = false;
                this.LoadData();

                if (Request.QueryString["id"] != null)
                {
                    FillFields(Request.QueryString["id"]);
                }
            }
        }
        protected void dgvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.dgvMaterias.SelectedValue;
            ModalBox.Visible = true;
        }

        private void FillFields(string v)
        {
            materia = MateriaLogic.GetInstance().GetOne(Convert.ToInt32(v));
            if (materia != null)
            {
                txtDesc.Value = materia.DescMateria;
                txtHsSemanales.Value = materia.HsSemanales.ToString();
                txtHsTotales.Value = materia.HsTotales.ToString();
                ddlPlanes.SelectedValue = materia.IdPlan.ToString();
                lblAction.Text = "Editar Materia " + v;
                addMateria.Text = "Actualizar";
            }
        }

        private void LoadData()
        {
            dgvMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
            dgvMaterias.DataBind();
            ddlPlanes.DataSource = PlanLogic.GetInstance().GetAll();
            ddlPlanes.DataBind();
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
        protected void addMateria_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string errors = "";
            if (!Validations.ValidateInput(txtDesc.Value))
            {
                ok = false;
                errors += "Descripcion obligatorio | ";
            }
            if (!Validations.ValidateInput(txtHsSemanales.Value))
            {
                ok = false;
                errors += "Hs Semanales obligatorio | ";
            }
            if (!Validations.ValidateInput(txtHsTotales.Value))
            {
                ok = false;
                errors += "HS Totales obligatorio ";
            }

            if (ok)
            {
                materia.DescMateria = txtDesc.Value;
                materia.HsSemanales = Convert.ToInt32(txtHsSemanales.Value);
                materia.HsTotales = Convert.ToInt32(txtHsTotales.Value);
                materia.IdPlan = Convert.ToInt32(ddlPlanes.SelectedValue);

                if (PaginaEnEstadoEdicion())
                {
                    materia.ID = Convert.ToInt32(Request.QueryString["id"]);
                    materia.State = BusinessEntity.States.Modified;
                }
                else
                {
                    materia.State = BusinessEntity.States.New;
                }

                MateriaLogic.GetInstance().Save(materia);                
                Response.Redirect("Materias.aspx");
            }
            else
            {
                errorsBox.Visible = true;
                errorsBox.InnerText = errors;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {        

            if (SelectedID != 0 )
            {
                MateriaLogic.GetInstance().Delete(SelectedID);
                ModalBox.Visible = false;
                Response.Redirect("Materias.aspx");
            }
        }

        protected void bntCancer_Click(object sender, EventArgs e)
        {
            ModalBox.Visible = false;
        }
    }
}