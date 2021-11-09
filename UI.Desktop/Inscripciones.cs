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
        private bool RegistrarNota = false;
        public Insccipciones()
        {

            InitializeComponent();
            this.dgvInscripciones.AutoGenerateColumns = false;
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.Columns[8].Visible = false;
            this.dgvInscripciones.Columns[9].Visible = false;



        }
        public Insccipciones(bool registrar)
        {
            InitializeComponent();
            this.dgvInscripciones.AutoGenerateColumns = false;
            this.RegistrarNota = registrar;
        }


        private void Insccipciones_Load(object sender, EventArgs e)
        {
            if (Sesion.currentUser.TipoPersona != 1)
            {
                this.tsMaterias.Visible = false;
            }
            this.ListarInscripciones();
            //load cbMaterias y cbComision 
            cbComision.DataSource = ComisionLogic.GetInstance().GetAll();
            this.cbComision.DisplayMember = "DescComision";
            this.cbComision.ValueMember = "ID";
            cbMateria.DataSource = MateriaLogic.GetInstance().GetAll();
            this.cbMateria.DisplayMember = "DescMateria";
            this.cbMateria.ValueMember = "ID";
        }

        private void ListarInscripciones()
        {
            if (RegistrarNota)
            {
                if (Sesion.currentUser.TipoPersona == 2)
                {
                    this.btnRegistrarNota.Visible = true;
                    this.btnUpdate.Visible = false;
                    this.btnClose.Visible = true;
                    this.dgvInscripciones.Columns[8].Visible = true;
                    this.dgvInscripciones.Columns[9].Visible = true;
                    this.dgvInscripciones.Columns[0].Visible = false;
                    this.dgvInscripciones.ReadOnly = false;
                    pnlFiltroIns.Visible = true;

                    this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(Sesion.currentUser.IdPersona, null);
                }
                else
                {
                    this.btnRegistrarNota.Visible = false;
                    this.btnUpdate.Visible = false;
                    this.btnClose.Visible = true;
                    this.dgvInscripciones.Columns[8].Visible = false;
                    this.dgvInscripciones.Columns[9].Visible = false;
                    this.dgvInscripciones.Columns[0].Visible = false;
                    if (Sesion.currentUser.TipoPersona == 3)
                    {

                        this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(null, Sesion.currentUser.IdPersona);
                    }
                    else
                    {
                        this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll();

                    }
                }

            }
            else
            {
                this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll();

            }
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
            InscripcionDesktop insDesk = new InscripcionDesktop(((Business.Entities.Inscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
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

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvInscripciones.Rows.Count; i++)
            {
                Inscripcion insUpdate = new Inscripcion();
                insUpdate.ID = ((Business.Entities.Inscripcion)this.dgvInscripciones.Rows[i].DataBoundItem).ID;
                insUpdate.Nota = ((Business.Entities.Inscripcion)this.dgvInscripciones.Rows[i].DataBoundItem).InsertarNota;
                insUpdate.Condicion = ((Business.Entities.Inscripcion)this.dgvInscripciones.Rows[i].DataBoundItem).InsertarCondicion;
                insUpdate.State = BusinessEntity.States.Modified;
                InscripcionLogic.GetInstance().Save(insUpdate);
            }
            MessageBox.Show("Notas registradas con  exito!");
        }

        private void btnFiltrarIns_Click(object sender, EventArgs e)
        {

            this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(Sesion.currentUser.IdPersona, null, ((Business.Entities.Comision)this.cbComision.SelectedItem).ID, ((Business.Entities.Materia)this.cbMateria.SelectedItem).ID);

        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            this.dgvInscripciones.DataSource = InscripcionLogic.GetInstance().GetAll(Sesion.currentUser.IdPersona, null);

        }
    }
}
