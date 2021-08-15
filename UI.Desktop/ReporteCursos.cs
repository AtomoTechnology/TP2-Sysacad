using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "" && Regex.IsMatch(txtBuscar.Text, @"^\d+$"))
            {

                this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos(Convert.ToInt32(this.txtBuscar.Text));
            }
            else
            {
                MessageBox.Show("Hay que ingresar el id del curso a buscar y tiene que ser un digito del [1,+∞] ");
            }

        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( this.rdbMayorNota.Checked)
            {
                this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos(null, " ins.nota desc ");
            }
        }

        private void rdbMenorNota_CheckedChanged(object sender, EventArgs e)
        {
            if( this.rdbMenorNota.Checked)
            {
                this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos(null, " ins.nota asc ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem != null)
            {
                this.dgvReporteCursos.DataSource = InscripcionLogic.GetInstance().ReporteCursos(null, null, this.comboBox1.Text );
            }
        }
    }


}
