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
    public partial class UserPerfil : Form
    {
        public UserPerfil()
        {
            InitializeComponent();
            if (Sesion.currentUser.TipoPersona == 1 || Sesion.currentUser.TipoPersona == 2)
            {

                this.pnlMateriasAprobadas.Visible = false;
                this.btnMateriasAprobadas.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lineBorder.Width = this.btnMateriasAprobadas.Width;
            this.lineBorder.Left = this.btnMateriasAprobadas.Left;
            if (this.pnlBody.Controls.Count > 0)
            {
                this.pnlBody.Controls.RemoveAt(0);
            }
            MateriasAprobadas materiasAprobadas = new MateriasAprobadas();
            materiasAprobadas.TopLevel = false;
            this.pnlBody.Controls.Add(materiasAprobadas);
            materiasAprobadas.Dock = DockStyle.Fill;
            this.pnlBody.Tag = materiasAprobadas;
            materiasAprobadas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.lineBorder.Width = this.btnMisDatos.Width;
            this.lineBorder.Left = this.btnMisDatos.Left;
            if (this.pnlBody.Controls.Count > 0)
            {
                this.pnlBody.Controls.RemoveAt(0);
            }

            MisDatos md = new MisDatos();
            md.TopLevel = false;
            md.Dock = DockStyle.Fill;

            this.pnlBody.Controls.Add(md);
            this.pnlBody.Tag = md;
            md.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.lineBorder.Width = this.btnPreferencias.Width;
            this.lineBorder.Left = this.btnPreferencias.Left;
            if (this.pnlBody.Controls.Count > 0)
            {
                this.pnlBody.Controls.RemoveAt(0);
            }
            Preferences md = new Preferences();
            md.TopLevel = false;
            md.Dock = DockStyle.Fill;

            this.pnlBody.Controls.Add(md);
            this.pnlBody.Tag = md;
            md.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPerfil_Load(object sender, EventArgs e)
        {

            this.lblCantidadMateriasAprobadas.Text = InscripcionLogic.GetInstance().GetMateriasAprobadasAlumnos(Sesion.currentUser.ID).Count.ToString();

            this.lblFullname.Text = Sesion.currentUser.Apellido + " " + Sesion.currentUser.Nombre;
            this.lblLegajo.Text = Sesion.currentUser.Legajo.ToString();
            this.lineBorder.Width = this.btnMisDatos.Width;
            this.lineBorder.Left = this.btnMisDatos.Left;
            if (this.pnlBody.Controls.Count > 0)
            {
                this.pnlBody.Controls.RemoveAt(0);
            }

            MisDatos md = new MisDatos();
            md.TopLevel = false;
            md.Dock = DockStyle.Fill;

            this.pnlBody.Controls.Add(md);
            this.pnlBody.Tag = md;
            md.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbEditarDatos_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usrDesk = new UsuarioDesktop(Sesion.currentUser.ID, ApplicationForm.ModoForm.Modificacion);
            usrDesk.ShowDialog();
        }
    }
}
