using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2L06
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private UsuarioLogic _logic;
        public Usuario Entity { get; set; }
        public int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set { this.ViewState["SelectedID"] = value; }
        }

        public bool IsEntitySelected { get { return (this.SelectedID != 0); } }
        public enum FormMModes
        {
            Alta, Baja, Modificacion
        };

        public FormMModes FormMode
        {
            get { return (FormMModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }


        public UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadGrid();
            }
        }
        private void LoadGrid()
        {
            gridPanel.AutoGenerateColumns = false;
            gridPanel.DataSource = this.Logic.GetAll();
            gridPanel.DataBind();
        }

        protected void gridPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridPanel.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = Entity.Apellido;
            emailTextBox.Text = Entity.Email;
            habilitadoTextBox.Checked = Entity.Habilitado;
            nombreUsuarioTextBox.Text = Entity.NombreUsuario;
        }

        protected void EditarLinkButton_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                this.formPanel.Visible = true;
                FormMode = FormMModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.Email = this.emailTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Habilitado = this.habilitadoTextBox.Checked;
            usuario.Clave = this.claveTextBox.Text;
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.ValidateForm();

            if (!eApellido.Visible && !eNombre.Visible && !eEmail.Visible && !eClave.Visible && !eRepetirClave.Visible)
            {

                switch (FormMode)
                {
                    case FormMModes.Alta:
                        this.Entity = new Usuario();
                        Entity.State = BusinessEntity.States.New;
                        this.LoadEntity(Entity);
                        //this.SaveEntity(Entity);
                        this.LoadGrid();
                        break;
                    case FormMModes.Baja:
                        this.DeleteEntity(SelectedID);
                        this.LoadGrid();
                        break;
                    case FormMModes.Modificacion:
                        this.Entity = new Usuario();
                        this.Entity.ID = SelectedID;
                        Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(Entity);
                        //this.SaveEntity(Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                }

                this.formPanel.Visible = false;
            }
        }
        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Visible = enable;
            this.apellidoTextBox.Visible = enable;
            this.emailTextBox.Visible = enable;
            this.nombreUsuarioTextBox.Visible = enable;
            this.habilitadoTextBox.Visible = enable;
            this.claveTextBox.Visible = enable;
        }

        protected void EliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {

                this.formPanel.Visible = true;
                this.FormMode = FormMModes.Baja;
                this.EnableForm(false);
                this.LoadForm(SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {


            this.formPanel.Visible = true;
            this.FormMode = FormMModes.Alta;
            this.ClearForm();

        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.habilitadoTextBox.Text = string.Empty;
            this.claveTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }
        private void ValidateFields(TextBox textBox, Label label)
        {
            if (textBox.Text.Equals("") || textBox.Text is null)
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }
        private void ValidateForm()
        {
            this.ValidateFields(apellidoTextBox, eApellido);
            this.ValidateFields(nombreTextBox, eNombre);
            this.ValidateFields(emailTextBox, eEmail);
            this.ValidateFields(nombreUsuarioTextBox, eNombreUsuario);
            this.ValidateFields(claveTextBox, eClave);
            this.ValidateFields(reprtirClaveTextBox, eRepetirClave);
            if (claveTextBox.Text != reprtirClaveTextBox.Text)
            {
                this.eRepetirClave.Visible = true;
            }
            else
            {
                this.eRepetirClave.Visible = true;
            }

        }
    }
}