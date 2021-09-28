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
    public partial class Docentes : Form
    {
        public delegate void GetIdDocente(int ID);
        public event GetIdDocente GiveIdDocente; 
        public Docentes()
        {
            InitializeComponent();
            this.dgvDocentes.AutoGenerateColumns = false;
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            this.ListarDocentes();
        }
        private void ListarDocentes()
        {
           this.dgvDocentes.DataSource =  UsuarioLogic.GetInstance().GetAll(2);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //DocenteCursoDesktop dc = new DocenteCursoDesktop();
            //dc.txt
            GiveIdDocente(((Business.Entities.Usuario)this.dgvDocentes.SelectedRows[0].DataBoundItem).IdPersona);
            //MessageBox.Show(.ToString());
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
