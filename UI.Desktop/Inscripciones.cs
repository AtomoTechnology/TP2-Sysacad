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
    public partial class Insccipciones : Form
    {
        public Insccipciones()
        {
            InitializeComponent();
            this.dgvInscripciones.AutoGenerateColumns = false;
        }

        private void Insccipciones_Load(object sender, EventArgs e)
        {
            this.ListarInscripciones();
        }

        private void ListarInscripciones()
        {
            this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarInscripciones();
        }

        private void btnAddInscripcion_Click(object sender, EventArgs e)
        {
            InscripcionDesktop insDesk = new InscripcionDesktop(ApplicationForm.ModoForm.Alta);
            insDesk.ShowDialog();
            this.ListarInscripciones();
        }

        private void btnEditInscripcion_Click(object sender, EventArgs e)
        {
            InscripcionDesktop insDesk = new InscripcionDesktop( ((Business.Entities.Inscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID , ApplicationForm.ModoForm.Modificacion);
            insDesk.ShowDialog();
            this.ListarInscripciones();
        }

        private void tbnDeleteInscripcion_Click(object sender, EventArgs e)
        {
            InscripcionDesktop insDesk = new InscripcionDesktop(((Business.Entities.Inscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            //insDesk.ShowDialog();
            this.ListarInscripciones();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
