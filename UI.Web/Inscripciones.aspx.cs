using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Inscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadInscripciones();
           
        }
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
        private void LoadInscripciones()
        {
            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll();
            dgvInscripciones.DataBind();
        }

        protected void dgvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.dgvInscripciones.SelectedValue;
            ModalBox.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID != 0)
            {
                InscripcionLogic.GetInstance().Delete(SelectedID);
                ModalBox.Visible = false;
                Response.Redirect("Inscripciones.aspx");
            }
        }

        protected void bntCancer_Click(object sender, EventArgs e)
        {
            var i = ddlplanes.IDPlan;
            ModalBox.Visible = false;
        }
    }
}