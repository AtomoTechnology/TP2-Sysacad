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
    public partial class CursoDesktop : ApplicationForm
    {
        Curso currentCurso = new Curso();
        public CursoDesktop()
        {
            InitializeComponent();
        }
        public CursoDesktop(ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
        }
        public CursoDesktop(int ID , ModoForm modo )
        {
            InitializeComponent();
            Modo = modo;
            currentCurso = CursoLogic.GetInstance().GetOne(ID);
            if(currentCurso != null)
            {
                this.MapearDeDatos();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void MapearDeDatos() {

            this.txtId.Text = (currentCurso.ID).ToString();
            this.txtAnioCalendario.Text = currentCurso.AnioCalendario.ToString();
            this.txtCupo.Text = currentCurso.Cupo.ToString();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSaveCurso.Text = "Crear";
                    this.lbTitle.Text = "Agregar Curso";
                    break;
                case ModoForm.Baja:
                    this.btnSaveCurso.Text = "Borrar";
                    this.lbTitle.Text = " ¿ Estas seguro ? ";
                    this.lbTitle.ForeColor = Color.Red;
                    this.btnSaveCurso.BackColor = Color.Red;
                    this.cbComisiones.Enabled = false;
                    this.cbMaterias.Enabled = false;
                    this.txtAnioCalendario.Enabled = false;
                    this.txtCupo.Enabled = false;
                    break;
                case ModoForm.Modificacion:
                    this.btnSaveCurso.Text = "Guardar";
                    this.lbTitle.Text = "Modificar Curso";
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }


        }
        public override void MapearADatos() {
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.currentCurso.IdComision = ((Business.Entities.Comision)this.cbComisiones.SelectedItem).ID;
                    this.currentCurso.IdMateria = ((Business.Entities.Materia)this.cbMaterias.SelectedItem).ID;
                    this.currentCurso.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                    this.currentCurso.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    this.currentCurso.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.currentCurso.IdComision = ((Business.Entities.Comision)this.cbComisiones.SelectedItem).ID;
                    this.currentCurso.IdMateria = ((Business.Entities.Materia)this.cbMaterias.SelectedItem).ID;
                    this.currentCurso.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                    this.currentCurso.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    this.currentCurso.State = BusinessEntity.States.Delete;
                    break;
                case ModoForm.Modificacion:
                    this.currentCurso.IdComision = ((Business.Entities.Comision)this.cbComisiones.SelectedItem).ID;
                    this.currentCurso.IdMateria = ((Business.Entities.Materia)this.cbMaterias.SelectedItem).ID;
                    this.currentCurso.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                    this.currentCurso.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    this.currentCurso.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }

        }
        public override void GuardarCambios() {

            this.MapearADatos();
            CursoLogic.GetInstance().Save(currentCurso);
        
        }
        public override bool Validar() { 
            if(this.cbComisiones.SelectedValue != null && this.cbMaterias.SelectedItem != null && this.txtAnioCalendario.Text != "" && this.txtCupo.Text != null)
            {
                return true;
            }
            else
            {
                this.Notificar("Todos los campos son requeridos ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        
        }
        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            this.cbComisiones.DataSource = ComisionLogic.GetInstance().GetAll();
            this.cbComisiones.DisplayMember = "DescComision";
            this.cbComisiones.ValueMember = "ID";
            this.cbMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
            this.cbMaterias.DisplayMember = "DescMateria";
            this.cbMaterias.ValueMember = "ID";
        }

        private void btnSaveCurso_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }
    }
}
