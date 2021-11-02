using BoldReports.Models.ReportViewer;
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
    public partial class ReportePlanes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("ReportePlanes"); 
            this.LoadReportePlanes();
        }
        private void LoadReportePlanes()
        {
            dgvReportePlanes.DataSource = PlanLogic.GetInstance().ReportePlanes();
            dgvReportePlanes.DataBind();

            var result = PlanLogic.GetInstance().ReportePlanes();
            //ReportDataSource rds = new ReportDataSource("ReporteCursos", result);
            //this.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReportCursosViewer.rdlc";
            //this.ReportViewer1.LocalReport.DataSources.Clear();
            //this.ReportViewer1.LocalReport.DataSources.Add(rds);
            //this.ReportViewer1.RefreshReport();
            ReportViewer1.DataSource = result;
            ReportViewer1.DataBind();
            //this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}