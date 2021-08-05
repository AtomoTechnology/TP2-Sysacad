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
    public partial class ComisionDesktop : ApplicationForm
    {
        Comision currentComision = new Comision();

        public ComisionDesktop()
        {
            InitializeComponent();

        }
        public ComisionDesktop(ModoForm modo)
        {
            InitializeComponent();
            this.CargarPlan();
            Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            currentComision = ComisionLogic.GetInstance().GetOne(ID);
            if (currentComision != null)
            {
                if (Modo == ModoForm.Baja)
                {
                    DialogResult result = MessageBox.Show("Quieres Borrar esta comision?", "Borrar Comision", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        ComisionLogic.GetInstance().Delete(ID);
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

            this.txtId.Text = currentComision.ID.ToString();
            this.txtDess.Text = currentComision.DescComision;
            this.txtAnioEspecialidad.Text = currentComision.AnioEspecialidad.ToString();
            Plan p = PlanLogic.GetInstance().GetOne(currentComision.IdPlan);
            this.CargarPlan();
            this.cbPlan.SelectedIndex = this.cbPlan.FindString(p.DescPlan);

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSaveComision.Text = "Crear";
                    this.lbTitle.Text = "Agregar una comision";
                    break;
                case ModoForm.Baja:
                    break;
                case ModoForm.Modificacion:
                    this.btnSaveComision.Text = "Guardar";
                    this.lbTitle.Text = "Modificar una comision";
                    break;
                case ModoForm.Consulta:
                    this.btnSaveComision.Enabled = false;
                    this.lbTitle.Text = "Consulta una comision";
                    break;
                default:
                    this.btnSaveComision.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    currentComision.DescComision = this.txtDess.Text;
                    currentComision.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                    currentComision.IdPlan = ((Business.Entities.Plan)(this.cbPlan.SelectedItem)).ID;
                    currentComision.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    currentComision.DescComision = this.txtDess.Text;
                    currentComision.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                    currentComision.IdPlan = ((Business.Entities.Plan)(this.cbPlan.SelectedItem)).ID;
                    currentComision.State = BusinessEntity.States.Delete;
                    break;
                case ModoForm.Modificacion:
                    currentComision.DescComision = this.txtDess.Text;
                    currentComision.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                    currentComision.IdPlan = ((Business.Entities.Plan)(this.cbPlan.SelectedItem)).ID;
                    currentComision.State = BusinessEntity.States.Modified;
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
            ComisionLogic.GetInstance().Save(currentComision);

        }
        public override bool Validar()
        {
            if (this.txtDess.Text != "" && this.txtAnioEspecialidad.Text != "" && this.cbPlan.SelectedItem != null)
            {
                return true;
            }
            else
            {
                this.Notificar("Verifique todos los campos ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveComision_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }
        public void CargarPlan()
        {
            this.cbPlan.DataSource = new PlanLogic().GetAll();
            this.cbPlan.DisplayMember = "DescPlan";
            this.cbPlan.ValueMember = "ID";
        }

    }
}
