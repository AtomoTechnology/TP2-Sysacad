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

        private void LoadInscripciones()
        {
            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll();
            dgvInscripciones.DataBind();
        }
    }
}