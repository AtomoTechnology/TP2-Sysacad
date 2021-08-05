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
    public partial class Planes : Form
    {

        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }


        private void btnClosePlanes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.ListarPlanes();
        }

        private void ListarPlanes()
        {

            this.dgvPlanes.DataSource = PlanLogic.GetInstance().GetAll();
        }

        private void btnUpdatePlanes_Click(object sender, EventArgs e)
        {
            this.ListarPlanes();
        }



        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            PlanDesktop pd = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            pd.ShowDialog();
            this.ListarPlanes();
        }

        private void btnEditEsp_Click(object sender, EventArgs e)
        {
            PlanDesktop pd = new PlanDesktop(((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            pd.ShowDialog();
            this.ListarPlanes();
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            PlanDesktop pd = new PlanDesktop(((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            //pd.ShowDialog();
            this.ListarPlanes();
        }
    }
}
