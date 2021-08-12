using Business.Entities;
using Business.Logic;
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
    public partial class ReporteCursos : Form
    {
        public ReporteCursos()
        {
            InitializeComponent();
            this.dgvReporteCursos.AutoGenerateColumns = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarReporteCursos();
        }
        private void ListarReporteCursos()
        {
            this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos();
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            this.ListarReporteCursos();
        }
    }

    
}
