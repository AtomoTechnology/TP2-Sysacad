
namespace UI.Desktop
{
    partial class Docentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docentes));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.btnAddUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnEditUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUsuario = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.tsUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(958, 534);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(958, 572);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsUsuarios);
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidades.Controls.Add(this.dgvDocentes, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnAceptar, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClose, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 2;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEspecialidades.Size = new System.Drawing.Size(958, 534);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDocentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDocentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocentes.ColumnHeadersHeight = 30;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.legajo,
            this.Nombre_Usuario,
            this.Nombre,
            this.Apellido,
            this.direccion,
            this.tipo_persona});
            this.tlpEspecialidades.SetColumnSpan(this.dgvDocentes, 2);
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes.EnableHeadersVisualStyles = false;
            this.dgvDocentes.GridColor = System.Drawing.Color.White;
            this.dgvDocentes.Location = new System.Drawing.Point(3, 3);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocentes.RowHeadersWidth = 62;
            this.dgvDocentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvDocentes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocentes.RowTemplate.DividerHeight = 1;
            this.dgvDocentes.RowTemplate.Height = 28;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(952, 454);
            this.dgvDocentes.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 8;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 144;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.DataPropertyName = "NombreUsuario";
            this.Nombre_Usuario.HeaderText = "Nombre Usuario";
            this.Nombre_Usuario.MinimumWidth = 8;
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            this.Nombre_Usuario.Width = 274;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 160;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 164;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 184;
            // 
            // tipo_persona
            // 
            this.tipo_persona.DataPropertyName = "DescTipoPersona";
            this.tipo_persona.HeaderText = "Tipo Persona";
            this.tipo_persona.MinimumWidth = 8;
            this.tipo_persona.Name = "tipo_persona";
            this.tipo_persona.ReadOnly = true;
            this.tipo_persona.Width = 232;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bowlby One SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(522, 463);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(216, 68);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(744, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(211, 68);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuarios.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUsuario,
            this.btnEditUsuario,
            this.btnDeleteUsuario});
            this.tsUsuarios.Location = new System.Drawing.Point(30, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(120, 38);
            this.tsUsuarios.TabIndex = 0;
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsuario.Image")));
            this.btnAddUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(34, 33);
            this.btnAddUsuario.Text = "Agregar Usuario";
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUsuario.Image")));
            this.btnEditUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(34, 33);
            this.btnEditUsuario.Text = "editar Usuario";
            // 
            // btnDeleteUsuario
            // 
            this.btnDeleteUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUsuario.Image")));
            this.btnDeleteUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUsuario.Name = "btnDeleteUsuario";
            this.btnDeleteUsuario.Size = new System.Drawing.Size(34, 33);
            this.btnDeleteUsuario.Text = "Borrar Usuario";
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.tscEspecialidades);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.ToolStripButton btnAddUsuario;
        private System.Windows.Forms.ToolStripButton btnEditUsuario;
        private System.Windows.Forms.ToolStripButton btnDeleteUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_persona;
    }
}