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
    public partial class formLogin : Form
    {
        public bool isOk = false;
        public formLogin()
        {
            InitializeComponent();  
           
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text != "" && this.txtPass.Text != "")
            {
                Business.Entities.Usuario currentUser = UsuarioLogic.GetInstance().LogIn(this.txtUsuario.Text, this.txtPass.Text);
                if (currentUser != null )
                {
                    this.DialogResult = DialogResult.OK;
                    //Sesion.idUser = currentUser.ID;
                    //Sesion.userName = currentUser.NombreUsuario;
                    //Sesion.userType = currentUser.TipoPersona;
                    Sesion.currentUser = currentUser;
                    isOk = true;
                    //this.Close();
                    
                    
                     //MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 else
                 {
                              MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos !!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void lmkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (new LogOut().ShowDialog() == DialogResult.OK)
            {
                Application.Exit();

            }
        }
    }
}
