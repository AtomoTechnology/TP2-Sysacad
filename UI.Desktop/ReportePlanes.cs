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
    public partial class ReportePlanes : Form
    {
        public ReportePlanes()
        {
            InitializeComponent();
            this.dgvReportePlanes.AutoGenerateColumns = false;
        }
        private void ListarReportePlanes()
        {
            this.dgvReportePlanes.DataSource = PlanLogic.GetInstance().ReportePlanes();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.ListarReportePlanes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportePlanes_Load(object sender, EventArgs e)
        {
            this.ListarReportePlanes();
            this.cbOpciones2.Enabled = false;
            this.btnBuscar.Enabled = false;
        }

        private void cbOpcion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbOpcion1.Text != "")
            {
                this.cbOpciones2.Enabled = true;


                if (this.cbOpcion1.SelectedItem != null && this.cbOpcion1.Text == "Plan")
                {
                    this.cbOpciones2.DataSource = PlanLogic.GetInstance().GetAll();
                    this.cbOpciones2.DisplayMember = "DescPlan";
                    this.cbOpciones2.ValueMember = "ID";
                }
                else if (this.cbOpcion1.SelectedItem != null && this.cbOpcion1.Text == "Materia")
                {
                    this.cbOpciones2.DataSource = MateriaLogic.GetInstance().GetAll();
                    this.cbOpciones2.DisplayMember = "DescMateria";
                    this.cbOpciones2.ValueMember = "ID";
                }
            }
            else
            {
                this.cbOpciones2.SelectedIndex = -1;
                this.cbOpciones2.Enabled = false;
            }
        }

        private void cbOpciones2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbOpciones2.SelectedItem != null)
            {

                this.btnBuscar.Enabled = true;
            }
            else
            {
                this.btnBuscar.Enabled = false;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (this.cbOpcion1.Text)
            {
                case "Plan":
                    this.dgvReportePlanes.DataSource = PlanLogic.GetInstance().ReportePlanes( ((Business.Entities.Plan) this.cbOpciones2.SelectedItem).ID  );
                    break;
                case "Materia":
                    this.dgvReportePlanes.DataSource = PlanLogic.GetInstance().ReportePlanes( null , ((Business.Entities.Materia)this.cbOpciones2.SelectedItem).ID);
                    break;
                default:
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
