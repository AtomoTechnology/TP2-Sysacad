using Business.Entities;
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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.listarEspecialidades();
        }
        public void listarEspecialidades()
        {
            Business.Logic.EspecialidadLogic el = new Business.Logic.EspecialidadLogic();
            this.dgvEspecialidades.DataSource = el.GetAll();
        }
    
  
        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEsp_Click_1(object sender, EventArgs e)
        {
            EspecialidadForm esp = new EspecialidadForm();
            esp.ShowDialog();
            this.listarEspecialidades();
        }

        private void tlpEspecialidades_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            this.listarEspecialidades();
        }

        private void btnEditEsp_Click_1(object sender, EventArgs e)
        {

            EspecialidadForm especialidadForm = new EspecialidadForm(((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            especialidadForm.ShowDialog();
            this.listarEspecialidades();
        }

        private void tbnDeleteEsp_Click(object sender, EventArgs e)
        {
            EspecialidadForm especialidadForm = new EspecialidadForm(((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            this.listarEspecialidades();
        }
    }
}
