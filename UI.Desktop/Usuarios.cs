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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.ListarUsuarios();
        }
        public void ListarUsuarios()
        {
            this.dgvUsuarios.DataSource = UsuarioLogic.GetInstance().GetAll();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop( ApplicationForm.ModoForm.Alta);
            usuarioDesktop.ShowDialog();
            this.ListarUsuarios();
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            usuarioDesktop.ShowDialog();
            this.ListarUsuarios();
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            //usuarioDesktop.ShowDialog();
            this.ListarUsuarios();
        }
    }
}
