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
    public partial class MisDatos : Form
    {
        Usuario UsuarioActual = new Usuario();
        public MisDatos()
        {
            InitializeComponent();
        }

        private void MisDatos_Load(object sender, EventArgs e)
        {
            UsuarioActual =  UsuarioLogic.GetInstance().GetOne(Sesion.currentUser.ID);
            this.txtID.Text = UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtDireccion.Text = this.UsuarioActual.Direccion;
            this.txtLegajo.Text = this.UsuarioActual.Legajo.ToString();
            this.txtTelefono.Text = this.UsuarioActual.Telefono;
            this.cbTipoPersona.Text = this.UsuarioActual.TipoPersona.ToString();
            this.txtFechaNac.Value = this.UsuarioActual.FechaNac;
            Plan p = PlanLogic.GetInstance().GetOne(UsuarioActual.IdPlan);
            this.CargarPlanes();
            this.cbPlanes.SelectedIndex = this.cbPlanes.FindString(p.DescPlan);
        }
        public void CargarPlanes()
        {
            this.cbPlanes.DataSource = PlanLogic.GetInstance().GetAll();
            this.cbPlanes.DisplayMember = "DescPlan";
            this.cbPlanes.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usrDesk = new UsuarioDesktop(Sesion.currentUser.ID, ApplicationForm.ModoForm.Modificacion);
            usrDesk.ShowDialog();
        }
    }
}
