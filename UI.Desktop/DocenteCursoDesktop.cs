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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        Dictado currentDictado = new Dictado();
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }
        public DocenteCursoDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            this.txtIdCurso.Text = ID.ToString();
        }
        public override void MapearDeDatos() { }
        public override void MapearADatos() {

            switch (Modo)
            {
                case ModoForm.Alta:
                    currentDictado.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                    currentDictado.IdDocente = Convert.ToInt32(this.txtIdDocente.Text);
                    currentDictado.Cargo = Convert.ToInt32(this.cbCargo.SelectedItem);
                    currentDictado.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    break;
                case ModoForm.Modificacion:
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }
        }
        public override void GuardarCambios() {
            this.MapearADatos();
            DictadoLogic.GetInstance().Save(currentDictado);
        }
        public override bool Validar()
        {
            if (txtIdCurso.Text != "" && txtIdDocente.Text != "" && cbCargo.SelectedItem != null)
            {
                return true;
            }
            else
            {
                this.Notificar("Todos los campos con * son obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDocente_Click(object sender, EventArgs e)
        {
            Docentes docentes = new Docentes();
            docentes.GiveIdDocente += Docentes_GiveIdDocente;
            docentes.ShowDialog();
        }

        private void Docentes_GiveIdDocente(int ID)
        {
            this.txtIdDocente.Text = ID.ToString();
        }

        private void pbCursos_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }
    }
}
