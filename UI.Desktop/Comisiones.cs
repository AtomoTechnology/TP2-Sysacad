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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void  ListarComisiones()
        {
           this.dgvComisiones.DataSource =  ComisionLogic.GetInstance().GetAll();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.ListarComisiones();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarComisiones();
        }

        private void btnAddComision_Click(object sender, EventArgs e)
        {
            ComisionDesktop comDesk = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            comDesk.ShowDialog();
            this.ListarComisiones();
        }

        private void btnEditComision_Click(object sender, EventArgs e)
        {
            ComisionDesktop comDesk = new ComisionDesktop(((Business.Entities.Comision)(this.dgvComisiones.SelectedRows[0].DataBoundItem)).ID , ApplicationForm.ModoForm.Modificacion);
            comDesk.ShowDialog();
            this.ListarComisiones();
        }

        private void tbnDeleteComision_Click(object sender, EventArgs e)
        {
            ComisionDesktop comDesk = new ComisionDesktop(((Business.Entities.Comision)(this.dgvComisiones.SelectedRows[0].DataBoundItem)).ID, ApplicationForm.ModoForm.Baja);
            comDesk.ShowDialog();
            this.ListarComisiones();
        }
    }
}
