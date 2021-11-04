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
    public partial class RegistrarNota : System.Web.UI.Page
    {
        Usuario usr;
        protected void Page_Load(object sender, EventArgs e)
        {
             usr = Methods.ValidatePermission("RegistrarNota");
            if (!IsPostBack)
            {
                this.gvInscripciones.AutoGenerateColumns = false;
                this.ddlComisiones.DataSource = ComisionLogic.GetInstance().GetAll();
                ddlComisiones.DataBind();
                this.ddlMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
                ddlMaterias.DataBind();
                this.LoadGridIns(usr);
             
            }
            //this.btnRegistrarNota_Click(sender,e );
        }
        private void LoadGridIns(Usuario usr)
        {
            this.gvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(usr.IdPersona, null);
            gvInscripciones.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.gvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(usr.IdPersona, null, Convert.ToInt32(ddlComisiones.SelectedValue), Convert.ToInt32(ddlMaterias.SelectedValue));
            gvInscripciones.DataBind();
        }        

        protected void btnRegistrarNota_Click1(object sender, EventArgs e)
        {
            int[] notas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] condiciones = { "Regular", "Libre", "Aprobada" };
            Random rnd = new Random();
            Random rndCondition = new Random();


            for (int i = 0; i < this.gvInscripciones.Rows.Count; i++)
            {
                Inscripcion insUpdate = new Inscripcion();
                insUpdate.ID = Convert.ToInt32(this.gvInscripciones.Rows[i].Cells[0].Text);
                insUpdate.Nota = notas[rnd.Next(10)];
                insUpdate.Condicion = condiciones[rnd.Next(3)];
                insUpdate.State = BusinessEntity.States.Modified;
                InscripcionLogic.GetInstance().Save(insUpdate);
                //var tb1 = this.gvInscripciones.Rows[i].Cells[1].Text;
                // var tb2 = this.gvInscripciones.Rows[i].Cells[2].Text;
                //  insUpdate.Nota = ((Business.Entities.Inscripcion)this.gvInscripciones.Rows[i].DataBoundItem).InsertarNota;
                // insUpdate.Condicion = ((Business.Entities.Inscripcion)this.gvInscripciones.Rows[i].DataBoundItem).InsertarCondicion;
            }
            //MessageBox.Show();
            Response.Redirect("RegistrarNota.aspx");
        }
    }

    
}