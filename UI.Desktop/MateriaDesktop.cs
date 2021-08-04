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
    public partial class MateriaDesktop : ApplicationForm
    {
        private MateriaLogic ml;
        private Materia currentMateria = new Materia();
        public MateriaDesktop()
        {
            InitializeComponent();
        }
     

        public MateriaDesktop( ModoForm modo )
        {
            InitializeComponent();
            this.FillCbPlan();
            Modo = modo;
        }
        public MateriaDesktop(int ID , ModoForm modo)
        {
            InitializeComponent();
            ml = new MateriaLogic();
            Modo = modo;
            currentMateria = ml.GetOne(ID);
            if(currentMateria != null)
            {
                this.MapearDeDatos();
            }

        }
        public override void MapearDeDatos() {
            this.txtId.Text = currentMateria.ID.ToString();
            this.txtDess.Text= currentMateria.DescMateria;
            this.txtHsSemanales.Text = currentMateria.HsSemanales.ToString();
            this.txtHstotales.Text = currentMateria.HsTotales.ToString();
            this.cbPlan.SelectedItem = currentMateria.IdPlan.ToString();
            var p = PlanLogic.GetInstance().GetOne(currentMateria.IdPlan);
            this.FillCbPlan();
            this.cbPlan.SelectedIndex =  this.cbPlan.FindString(p.DescPlan);
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnSaveMateria.Text = "Crear";
                    break;
                case ModoForm.Baja:
                    this.btnSaveMateria.Text = "Borrar";
                    this.btnSaveMateria.BackColor = Color.Red;
                    this.txtDess.ReadOnly = true;
                    this.txtHsSemanales.ReadOnly = true;
                    this.txtHstotales.ReadOnly = true;
                    this.cbPlan.Enabled  = false;
                    this.lbTitle.Text = "Borrar Materia";
                    break;
                case ModoForm.Modificacion:
                    this.btnSaveMateria.Text = "Guardar";
                    this.lbTitle.Text = "Modificar Materia";
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    this.btnSaveMateria.Text = "Guardar";
                    break;
            }

        }
        public override void MapearADatos() {

            switch (Modo)
            {
                case ModoForm.Alta:
                    currentMateria.DescMateria = this.txtDess.Text;
                    currentMateria.HsSemanales = Convert.ToInt32(this.txtHsSemanales.Text);
                    currentMateria.HsTotales = Convert.ToInt32(this.txtHstotales.Text);
                    currentMateria.IdPlan = ((Business.Entities.Plan)this.cbPlan.SelectedItem).ID;
                    currentMateria.State = BusinessEntity.States.New;

                    break;
                case ModoForm.Baja:
                    currentMateria.DescMateria = this.txtDess.Text;
                    currentMateria.HsSemanales = Convert.ToInt32(this.txtHsSemanales.Text);
                    currentMateria.HsTotales = Convert.ToInt32(this.txtHstotales.Text);
                    currentMateria.IdPlan = ((Business.Entities.Plan)this.cbPlan.SelectedItem).ID;
                    currentMateria.State = BusinessEntity.States.Delete;
                    break;
                case ModoForm.Modificacion:
                    currentMateria.DescMateria = this.txtDess.Text;
                    currentMateria.HsSemanales = Convert.ToInt32(this.txtHsSemanales.Text);
                    currentMateria.HsTotales = Convert.ToInt32(this.txtHstotales.Text);
                    currentMateria.IdPlan = ((Business.Entities.Plan)this.cbPlan.SelectedItem).ID;
                    currentMateria.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    break;
                default:
                    break;
            }
        }
        public override void GuardarCambios() {
            this.MapearADatos();
            ml = new MateriaLogic();
            ml.Save(currentMateria);
            
        }
        public override bool Validar() { 
            if(this.txtDess.Text != "" && this.txtHsSemanales.Text != ""  && txtHstotales.Text != "" && cbPlan.SelectedItem != null)
            {
                return true;
            }
            else
            {
                this.Notificar("Verifiques los datos !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
        
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCbPlan()
        {
            this.cbPlan.DataSource = PlanLogic.GetInstance().GetAll();
            this.cbPlan.DisplayMember = "DescPlan";
            this.cbPlan.ValueMember = "ID";
        }
        private void btnSaveMateria_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }
    }
}
