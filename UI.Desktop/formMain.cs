using Business.Entities;
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
    public partial class formMain : Form
    {
        Form form = null;
        public formMain()
        {
            InitializeComponent();
            this.DiseableMenu();
        }

        private void mnuArchivo_Click(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {

            formLogin appLogin = new formLogin();
            //appLogin.ShowDialog();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {            
                this.Dispose();
            }
            else
            {

                this.pnlMenuAcademia.Visible = true;

                if (Sesion.userType == 1)
                {
                    this.GetAdmin();
                }
                else if (Sesion.userType == 2)
                {
                    this.GetTeacher();
                }
                else
                {
                    this.GetStudent();
                }
            }
           
          
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.pnlUserModal.Visible = false;
        }
        private void GetAdmin(  )
        {
            this.aBMAlumnoToolStripMenuItem.Visible = true;
            this.profesoresToolStripMenuItem.Visible =  true;
            this.adminToolStripMenuItem.Visible = true;

        }
        private void GetStudent()
        {
            this.aBMAlumnoToolStripMenuItem.Visible = true;
            this.profesoresToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Visible = false;
        }
        private void GetTeacher()
        {
            this.aBMAlumnoToolStripMenuItem.Visible = false;
            this.profesoresToolStripMenuItem.Visible = true;
            this.adminToolStripMenuItem.Visible = false;
        }
        private void DiseableMenu()
        {
            this.pnlMenuAcademia.Visible = false;
            //this.aBMAlumnoToolStripMenuItem.Visible = false;
            //this.profesoresToolStripMenuItem.Visible = false;
            //this.adminToolStripMenuItem.Visible = false;
            //this.mnsPrincipal.Visible = false;
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void crearPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Usuarios();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
            
            //if(usuario == null)
            //{
            //usuario = new Usuario();
            //usuario.FormClosed += Usuario_FormClosed;
            //usuario.Show();
            //}
            //else
            //{
            //    usuario.Activate();
            //}
            //usuario.ShowDialog();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Planes();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void CloseOtherForm()
        {
            foreach (var item in MdiChildren)
            {
                item.Close();
                item.Dispose();
            }
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Comisiones();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Cursos();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Materias();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Especialidades();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Insccipciones();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.pnlUserModal.Visible)
            {
                this.pnlUserModal.Visible = false;
            }
            else
            {

             this.pnlUserModal.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
