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
    public partial class EspecialidadForm : ApplicationForm
    {
        Especialidad currentEsp = new Especialidad();
        public EspecialidadForm()
        {
            InitializeComponent();
        }
        public EspecialidadForm(ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
        }
        public EspecialidadForm(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            currentEsp = EspecialidadLogic.GetInstance().GetOne(ID);
            if (currentEsp != null)
            {
                if (modo == ModoForm.Baja)
                {
                    var result = MessageBox.Show("Estas seguro que quieres borra el registro", "Borra especialidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        EspecialidadLogic.GetInstance().DeleteOne(ID);
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

            //this.tbId.Text = currentEsp.ID.ToString();
            this.tbDescripcion.Text = currentEsp.desc_especialidad;
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSaveEsp.Text = "Crear";
                    break;
                case ModoForm.Baja:
                    //this.tbId.Enabled = false;
                    this.btnSaveEsp.Text = "Borrar";
                    break;
                case ModoForm.Modificacion:
                    //this.tbId.Enabled = false;
                    this.btnSaveEsp.Text = "Guardar";
                    this.label3.Text = "Actualizar Especialidad";
                    break;
                case ModoForm.Consulta:
                    this.btnSaveEsp.Text = "Aceptar";
                    break;
                default:
                    this.btnSaveEsp.Text = "Aceptar";
                    break;
            }

        }
        public override void MapearADatos()
        {


            switch (Modo)
            {
                case ModoForm.Alta:
                    currentEsp.desc_especialidad = this.tbDescripcion.Text;
                    currentEsp.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:

                    break;
                case ModoForm.Modificacion:
                    //currentEsp.ID = Convert.ToInt32(this.tbId.Text);
                    currentEsp.desc_especialidad = this.tbDescripcion.Text;
                    currentEsp.State = BusinessEntity.States.Modified;
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
            EspecialidadLogic el = new EspecialidadLogic();
            el.Save(currentEsp);

        }
        public override bool Validar()
        {
            if (this.tbDescripcion.Text.Length != 0)
            {

                return true;
            }
            else
            {
                this.Notificar("Verifique los datos del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void btnSaveEsp_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {

                this.GuardarCambios();
                this.Close();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
