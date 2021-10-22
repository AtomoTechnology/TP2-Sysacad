using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class ReporteCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadReporteCursos();
        }
        private void LoadReporteCursos()
        {
            this.dgvReporteCursos.AutoGenerateColumns = false;
            this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos();
            this.dgvReporteCursos.DataBind();
        }
       
    }
}