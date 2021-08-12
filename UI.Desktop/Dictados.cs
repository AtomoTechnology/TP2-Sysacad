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
    public partial class Dictados : Form
    {
        public Dictados()
        {
            InitializeComponent();
            this.dgvDictados.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ListarDictados();
        }
        private void ListarDictados()
        {
           this.dgvDictados.DataSource =  DictadoLogic.GetInstance().GetAll( Sesion.idUser );
        }

        private void Dictados_Load(object sender, EventArgs e)
        {
            this.ListarDictados();
        }
    }
}
