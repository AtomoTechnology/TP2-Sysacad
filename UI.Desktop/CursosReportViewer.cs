using Business.Logic;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class CursosReportViewer : Form
    {
        public CursosReportViewer()
        {
            InitializeComponent();
        }

        private void CursosReportViewer_Load(object sender, EventArgs e)
        {
            var result = InscripcionLogic.GetInstance().ReporteCursos();
            ReportDataSource rds = new ReportDataSource("ReporteCursos", result);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReportCursosViewer.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
