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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarCursos();
        }
        private void ListarCursos()
        {
            this.dgvCursos.DataSource = CursoLogic.GetInstance().GetAllWithCupo();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            if( Sesion.currentUser.TipoPersona != 1 && Sesion.currentUser.TipoPersona == 3)
            {
                this.btnAddCurso.Visible = false;
                this.btnEditCurso.Visible = false;
                this.btnAsignarDocente.Visible = false;
                this.btnDeleteCurso.Visible = false;
            }
            this.ListarCursos();
        }

        private void btnAddCurso_Click(object sender, EventArgs e)
        {
            CursoDesktop cursoDesk = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            cursoDesk.ShowDialog();
            this.ListarCursos();
        }

        private void btnEditCurso_Click(object sender, EventArgs e)
        {
            CursoDesktop cursoDesk = new CursoDesktop(((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            cursoDesk.ShowDialog();
            this.ListarCursos();
        }

        private void tbnDeleteCurso_Click(object sender, EventArgs e)
        {
            CursoDesktop cursoDesk = new CursoDesktop(((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            cursoDesk.ShowDialog();
            this.ListarCursos();
        }

        private void btnAsignarDocente_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dictado = new DocenteCursoDesktop(((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Alta);
            dictado.ShowDialog();           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InscripcionDesktop insDesk = new InscripcionDesktop(((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem), ApplicationForm.ModoForm.Alta);
            insDesk.ShowDialog();
            this.ListarCursos();
        }
    }
}
