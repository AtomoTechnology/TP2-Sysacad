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
    public partial class MateriasAprobadas : Form
    {
        public MateriasAprobadas()
        {
            InitializeComponent();
            this.dgvMateriasAprobadas.AutoGenerateColumns = false;
        }

        private void MateriasAprobadas_Load(object sender, EventArgs e)
        {
            if( Sesion.currentUser != null && Sesion.currentUser.TipoPersona == 3)
            {

              this.dgvMateriasAprobadas.DataSource =  InscripcionLogic.GetInstance().GetMateriasAprobadasAlumnos(Sesion.currentUser.IdPersona);
            }
           

           
        }

    }
}
