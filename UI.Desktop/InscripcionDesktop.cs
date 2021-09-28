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
        private int? idMateriaActual = null;

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
        public InscripcionDesktop( Curso curso , ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            if(curso != null)
            {
                //currentInscripcion.IdCurso = curso.ID;
                //currentInscripcion.DescComision = curso.DescComision;
                //currentInscripcion.DescMateria = curso.DescMateria;
                //Curso cur = CursoLogic.GetInstance().GetOne(currentInscripcion.IdCurso);
                //Usuario usr = UsuarioLogic.GetInstance().GetOne(currentInscripcion.IdAlumno);
                this.cbComisiones.Text = curso.DescComision;
                this.cbMaterias.Text = curso.DescMateria;
                this.CargarCursos();
                this.cbCursos.SelectedIndex = this.cbCursos.FindString(curso.ID.ToString());
                this.CargarAlumnos();
                //this.cbAlumnos.SelectedIndex = this.cbAlumnos.FindString(usr.Legajo.ToString());
                //this.MapearDeDatos();
            }
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
            //this.txtNota.Text = currentInscripcion.Nota.ToString();
            this.CargarAlumnosCursos();
            Curso cur = CursoLogic.GetInstance().GetOne(currentInscripcion.IdCurso);
            Usuario usr = UsuarioLogic.GetInstance().GetOne(currentInscripcion.IdAlumno);
            this.cbCursos.SelectedIndex = this.cbCursos.FindString(cur.DescMateria);
            this.cbAlumnos.SelectedIndex = this.cbAlumnos.FindString(usr.Legajo.ToString());
            //this.cbCondicions.SelectedIndex = this.cbCondicions.FindString(currentInscripcion.Condicion);

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
                    currentInscripcion.IdAlumno = ((Business.Entities.Usuario)this.cbAlumnos.SelectedItem).IdPersona;
                    currentInscripcion.IdCurso = ((Business.Entities.Curso)this.cbCursos.SelectedItem).ID;
                    currentInscripcion.Condicion = "Cursando";
                    currentInscripcion.CursoCupo = ((Business.Entities.Curso)this.cbCursos.SelectedItem).Cupo;
                    //currentInscripcion.Nota = Convert.ToInt32(this.txtNota.Text);
                    currentInscripcion.State = BusinessEntity.States.New;

                    break;
                case ModoForm.Baja:
                    break;
                case ModoForm.Modificacion:
                    currentInscripcion.IdAlumno = ((Business.Entities.Usuario)this.cbAlumnos.SelectedItem).IdPersona;
                    currentInscripcion.IdCurso = ((Business.Entities.Curso)this.cbCursos.SelectedItem).ID;
                    currentInscripcion.Condicion = "Cursando";
                    //currentInscripcion.Nota = Convert.ToInt32(this.txtNota.Text);
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

            if (this.cbAlumnos.SelectedItem != null && this.cbCursos.SelectedItem != null)
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
            //this.cbCursos.DataSource = CursoLogic.GetInstance().GetAll();
            //this.cbCursos.DisplayMember = "DescMateria";
            //this.cbCursos.ValueMember = "ID";
            this.cbMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
            this.cbMaterias.DisplayMember = "DescMateria";
            this.cbMaterias.ValueMember = "ID";
            //this.cbMaterias.SelectedIndex = -1;
            this.CargarAlumnos();
       

        }
        private void CargarAlumnos()
        {
            this.cbAlumnos.DataSource = UsuarioLogic.GetInstance().GetAll();
            this.cbAlumnos.DisplayMember = "Legajo";
            this.cbAlumnos.ValueMember = "ID";
            if( Sesion.currentUser.TipoPersona == 3)
            {

                this.cbAlumnos.SelectedIndex = this.cbAlumnos.FindString(Sesion.currentUser.Legajo.ToString());
            }
            else
            {

                this.cbAlumnos.SelectedIndex = -1;
            }
        }

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cbComisiones.Text = ((Business.Entities.Curso)this.cbCursos.SelectedItem).ID.ToString(); 
        }

        private void cbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                this.idMateriaActual = ((Business.Entities.Materia)this.cbMaterias.SelectedItem).ID;
                this.cbComisiones.DataSource = CursoLogic.GetInstance().GetAll(idMateriaActual, null, null);
                this.cbComisiones.DisplayMember = "DescComision";
                this.cbComisiones.ValueMember = "ID";
            
        }

        private void cbComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                int idComision = ((Business.Entities.Curso)this.cbComisiones.SelectedItem).IdComision;
                this.cbCursos.DataSource = CursoLogic.GetInstance().GetAll(idMateriaActual, idComision, null);
                this.cbCursos.DisplayMember = "ID";
                this.cbCursos.ValueMember = "ID";
            

        }
        private void CargarCursos()
        {
            this.cbCursos.DataSource = CursoLogic.GetInstance().GetAll();
            this.cbCursos.DisplayMember = "ID";
            this.cbCursos.ValueMember = "ID";
        }
    }

}
