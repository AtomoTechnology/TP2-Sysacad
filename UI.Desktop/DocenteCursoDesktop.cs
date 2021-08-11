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
    public partial class DocenteCursoDesktop : Form
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }
        public DocenteCursoDesktop( int ID )
        {
            InitializeComponent();
            this.txtIdCurso.Text = ID.ToString();
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
    }
}
