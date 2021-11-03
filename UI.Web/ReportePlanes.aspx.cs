using Business.Logic;
using Microsoft.Reporting.WebForms;
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
            if (!IsPostBack)
            {
            this.LoadReportePlanes();

            }
        }
        private void LoadReportePlanes()
        {
            //dgvReportePlanes.DataSource = PlanLogic.GetInstance().ReportePlanes();
            //dgvReportePlanes.DataBind();
            var dt = PlanLogic.GetInstance().ReportePlanes();
            this.ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("ReportePlanes",dt);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.Web.ReportViewerPlanes.rdlc";
            this.ReportViewer1.LocalReport.DataSources.Add(rds);
            this.ReportViewer1.LocalReport.Refresh();
            //var result = PlanLogic.GetInstance().ReportePlanes();

            //ReportDataSource rds = new ReportDataSource("DataSet1", result);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReportPlanesViewer.rdlc";
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.reportViewer1.RefreshReport();

        }
    }
}