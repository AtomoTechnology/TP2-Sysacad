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
    public partial class PlanDesktop : ApplicationForm
    {
        Plan currentPlan = new Plan();
        public PlanDesktop()
        {
            InitializeComponent();
        }
        public PlanDesktop(ModoForm modo)
        {
            InitializeComponent();
            this.CargarEspecialidades();
            Modo = modo;


        }
        public PlanDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            this.CargarEspecialidades();
            Modo = modo;
            currentPlan = PlanLogic.GetInstance().GetOne(ID);
            if (currentPlan != null)
            {
                if (modo == ModoForm.Baja)
                {
                    DialogResult result = MessageBox.Show("Estas seguro de borrar el plan ?", "Borrar Plan", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        PlanLogic.GetInstance().Delete(ID);
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

            //this.txtId.Text = currentPlan.ID.ToString();
            this.txtDess.Text = currentPlan.DescPlan;
            this.CargarEspecialidades();
            Especialidad esp = EspecialidadLogic.GetInstance().GetOne(currentPlan.IdEspecialidad);
            this.cbEspecialidades.SelectedIndex = this.cbEspecialidades.FindString(esp.desc_especialidad);
            //this.cbEspecialidades.Text = currentPlan.IdEspecialidad.ToString();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSavePlan.Text = "Crear Plan";
                    break;
                case ModoForm.Baja:
                    this.btnSavePlan.Text = "Borrar Plan";
                    break;
                case ModoForm.Modificacion:
                    this.btnSavePlan.Text = "Modificar Plan";
                    this.lbTitle.Text = "Modificar Plan";
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
                    currentPlan.DescPlan = this.txtDess.Text;
                    currentPlan.IdEspecialidad = ((Especialidad)this.cbEspecialidades.SelectedItem).ID;
                    currentPlan.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    break;
                case ModoForm.Modificacion:
                    currentPlan.DescPlan = this.txtDess.Text;
                    currentPlan.IdEspecialidad = ((Especialidad)this.cbEspecialidades.SelectedItem).ID;
                    currentPlan.State = BusinessEntity.States.Modified;
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
            PlanLogic.GetInstance().Save(currentPlan);

        }
        public override bool Validar()
        {

            if (this.txtDess.Text != "" && this.cbEspecialidades.SelectedItem != null)
            {
                return true;
            }
            else
            {
                this.Notificar("Error", "Verifique los datos del formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {


        }
        public void CargarEspecialidades()
        {
            this.cbEspecialidades.DataSource = EspecialidadLogic.GetInstance().GetAll();
            this.cbEspecialidades.DisplayMember = "desc_especialidad";
            this.cbEspecialidades.ValueMember = "ID";
        }

        private void btnSavePlan_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }
    }
}
