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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListarMaterias()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMaterias.DataSource = ml.GetAll();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.ListarMaterias();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarMaterias();
        }

        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            this.ListarMaterias();
        }

        private void btnEditMateria_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(( (Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID ,ApplicationForm.ModoForm.Modificacion);
            md.ShowDialog();
            this.ListarMaterias();

        }

        private void tbnDeleteMateria_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            md.ShowDialog();
            this.ListarMaterias();

        }
    }
}
