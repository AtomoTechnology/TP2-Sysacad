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
    public partial class InscripcionDesktop : ApplicationForm
    {
        Inscripcion currentInscripcion = new Inscripcion();

        public InscripcionDesktop()
        {
            InitializeComponent();
        }
        public InscripcionDesktop(ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            this.CargarAlumnosCursos();
        }
        public InscripcionDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            currentInscripcion = InscripcionLogic.GetInstance().GetOne(ID);
            if (currentInscripcion != null)
            {
                if (Modo == ModoForm.Baja)
                {
                    DialogResult res = MessageBox.Show("Estas seguro de anular la inscripcion ?", "Anular Inscripcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        InscripcionLogic.GetInstance().Delete(ID);
                    }

                }
                else
                {
                    this.MapearDeDatos();
                }
            }

        }

        public override void MapearDeDatos()
        {


            this.txtId.Text = currentInscripcion.ID.ToString();
            this.txtNota.Text = currentInscripcion.Nota.ToString();
            this.CargarAlumnosCursos();
            Curso cur = CursoLogic.GetInstance().GetOne(currentInscripcion.IdCurso);
            Usuario usr = UsuarioLogic.GetInstance().GetOne(currentInscripcion.IdAlumno);
            this.cbCursos.SelectedIndex = this.cbCursos.FindString(cur.DescMateria);
            this.cbAlumnos.SelectedIndex = this.cbAlumnos.FindString(usr.Legajo.ToString());
            this.cbCondicions.SelectedIndex = this.cbCondicions.FindString(currentInscripcion.Condicion);

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSaveInscripcion.Text = "Registar";
                    break;
                case ModoForm.Baja:

                    break;
                case ModoForm.Modificacion:
                    this.btnSaveInscripcion.Text = "Actualizar";

                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {


            switch (Modo)
            {
                case ModoForm.Alta:
                    currentInscripcion.IdAlumno = ((Business.Entities.Usuario)this.cbAlumnos.SelectedItem).ID;
                    currentInscripcion.IdCurso = ((Business.Entities.Curso)this.cbCursos.SelectedItem).ID;
                    currentInscripcion.Condicion = this.cbCondicions.SelectedItem.ToString();
                    currentInscripcion.CursoCupo = ((Business.Entities.Curso)this.cbCursos.SelectedItem).Cupo;
                    //currentInscripcion.Nota = Convert.ToInt32(this.txtNota.Text);
                    currentInscripcion.State = BusinessEntity.States.New;

                    break;
                case ModoForm.Baja:
                    break;
                case ModoForm.Modificacion:
                    currentInscripcion.IdAlumno = ((Business.Entities.Usuario)this.cbAlumnos.SelectedItem).ID;
                    currentInscripcion.IdCurso = ((Business.Entities.Curso)this.cbCursos.SelectedItem).ID;
                    currentInscripcion.Condicion = this.cbCondicions.SelectedItem.ToString();
                    currentInscripcion.Nota = Convert.ToInt32(this.txtNota.Text);
                    currentInscripcion.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }


        }
        public override void GuardarCambios()
        {

            this.MapearADatos();
            InscripcionLogic.GetInstance().Save(currentInscripcion);

        }
        public override bool Validar()
        {

            if (this.cbAlumnos.SelectedItem != null && this.cbCursos.SelectedItem != null && this.cbCondicions.SelectedItem != null)
            {
                return true;
            }
            else
            {
                this.Notificar(" Todos los campos con (*) son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCurso_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void CargarAlumnosCursos()
        {
            this.cbCursos.DataSource = CursoLogic.GetInstance().GetAll();
            this.cbCursos.DisplayMember = "DescMateria";
            this.cbCursos.ValueMember = "ID";
            this.cbAlumnos.DataSource = UsuarioLogic.GetInstance().GetAll();
            this.cbAlumnos.DisplayMember = "Legajo";
            this.cbAlumnos.ValueMember = "ID";

        }
    }

}
