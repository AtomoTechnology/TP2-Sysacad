using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Business.Entities.Usuario UsuarioActual = new Business.Entities.Usuario();
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo)
        {
            InitializeComponent();
            this.CargarPlanes();
            Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            UsuarioActual = UsuarioLogic.GetInstance().GetOne(ID);
            if (UsuarioActual != null)
            {
                if (modo == ModoForm.Baja)
                {
                    DialogResult res = MessageBox.Show("¿ Estas seguro de que quiere borrar el usuario ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        UsuarioLogic.GetInstance().Delete(ID);

                    }

                }
                else
                {
                    MapearDeDatos();

                }
            }



        }

        public override void MapearDeDatos()
        {

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
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Crear";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.txtConfirmarClave.Visible = false;
                    this.lblConfirmarClave.Visible = false;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }


        }
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:

                    //this.txtID.Text = this.UsuarioActual.ID.ToString();
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Direccion = this.txtDireccion.Text;
                    this.UsuarioActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    this.UsuarioActual.Telefono = this.txtTelefono.Text;
                    this.UsuarioActual.FechaNac = this.txtFechaNac.Value;
                    this.UsuarioActual.TipoPersona = Convert.ToInt32(this.cbTipoPersona.Text);
                    this.UsuarioActual.IdPlan = ((Business.Entities.Plan)this.cbPlanes.SelectedItem).ID;

                    UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:

                    break;
                case ModoForm.Modificacion:
                    this.txtID.Text = this.UsuarioActual.ID.ToString();
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Direccion = this.txtDireccion.Text;
                    this.UsuarioActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    this.UsuarioActual.Telefono = this.txtTelefono.Text;
                    this.UsuarioActual.FechaNac = this.txtFechaNac.Value;
                    this.UsuarioActual.TipoPersona = Convert.ToInt32(this.cbTipoPersona.Text);
                    this.UsuarioActual.IdPlan = ((Business.Entities.Plan)this.cbPlanes.SelectedItem).ID;
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:

                    break;
                default:

                    break;
            }


        }
        public override void GuardarCambios()
        {

            this.MapearADatos();
            Usuario usr = UsuarioLogic.GetInstance().GetOneByEmailUsernameLegajo(UsuarioActual);
            if (usr == null)
            {

                UsuarioLogic.GetInstance().Save(UsuarioActual);
                this.Close();
            }
            else
            {
                MessageBox.Show("El legajo/email/nombreUsuario ya existio!!");
            }

        }
        public override bool Validar()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(this.txtEmail.Text);
            if (Modo == ModoForm.Modificacion)
            {
                this.txtConfirmarClave.Text = this.txtClave.Text;
            }
            if (!match.Success || !Regex.IsMatch(txtLegajo.Text, @"^\d+$") || txtLegajo.Text.Length < 5 || txtLegajo.Text.Length > 5 || txtApellido.Text == "" || txtClave.Text.Length < 8 || txtNombre.Text == "" || txtUsuario.Text == "" || txtClave.Text == "" || txtConfirmarClave.Text != txtClave.Text || cbTipoPersona.SelectedItem == null || cbPlanes.SelectedItem == null || txtFechaNac.Value == null)
            {
                this.Notificar("Datos invalido", "Revisar los datos del formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CargarPlanes()
        {
            this.cbPlanes.DataSource = PlanLogic.GetInstance().GetAll();
            this.cbPlanes.DisplayMember = "DescPlan";
            this.cbPlanes.ValueMember = "ID";
        }

    }
}
