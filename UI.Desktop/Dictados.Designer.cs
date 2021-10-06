
namespace UI.Desktop
{
    partial class Dictados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictados));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDictados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.btnAddCurso = new System.Windows.Forms.ToolStripButton();
            this.btnEditCurso = new System.Windows.Forms.ToolStripButton();
            this.tbnDeleteCurso = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAsignarDocente = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1266, 735);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(844, 547);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsMaterias);
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidades.Controls.Add(this.dgvDictados, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnUpdate, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClose, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 3;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEspecialidades.Size = new System.Drawing.Size(1266, 735);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // dgvDictados
            // 
            this.dgvDictados.AllowUserToAddRows = false;
            this.dgvDictados.AllowUserToDeleteRows = false;
            this.dgvDictados.AllowUserToResizeColumns = false;
            this.dgvDictados.AllowUserToResizeRows = false;
            this.dgvDictados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDictados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDictados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.dgvDictados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDictados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDictados.ColumnHeadersHeight = 30;
            this.dgvDictados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDictados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Legajo,
            this.NombreCompleto,
            this.IDcurso,
            this.descMateria,
            this.descComision,
            this.descCargo});
            this.tlpEspecialidades.SetColumnSpan(this.dgvDictados, 2);
            this.dgvDictados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictados.EnableHeadersVisualStyles = false;
            this.dgvDictados.Location = new System.Drawing.Point(3, 3);
            this.dgvDictados.MultiSelect = false;
            this.dgvDictados.Name = "dgvDictados";
            this.dgvDictados.ReadOnly = true;
            this.dgvDictados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDictados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDictados.RowHeadersWidth = 62;
            this.dgvDictados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDictados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDictados.RowTemplate.Height = 28;
            this.dgvDictados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictados.Size = new System.Drawing.Size(1260, 635);
            this.dgvDictados.TabIndex = 0;
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
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 8;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 144;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Docente";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 166;
            // 
            // IDcurso
            // 
            this.IDcurso.DataPropertyName = "IDCurso";
            this.IDcurso.HeaderText = "ID Curso";
            this.IDcurso.MinimumWidth = 8;
            this.IDcurso.Name = "IDcurso";
            this.IDcurso.ReadOnly = true;
            this.IDcurso.Width = 169;
            // 
            // descMateria
            // 
            this.descMateria.DataPropertyName = "DescMateria";
            this.descMateria.HeaderText = "Desc. Materia";
            this.descMateria.MinimumWidth = 8;
            this.descMateria.Name = "descMateria";
            this.descMateria.ReadOnly = true;
            this.descMateria.Width = 240;
            // 
            // descComision
            // 
            this.descComision.DataPropertyName = "DescComision";
            this.descComision.HeaderText = "Desc Comision";
            this.descComision.MinimumWidth = 8;
            this.descComision.Name = "descComision";
            this.descComision.ReadOnly = true;
            this.descComision.Width = 255;
            // 
            // descCargo
            // 
            this.descCargo.DataPropertyName = "DescCargo";
            this.descCargo.HeaderText = "Cargo";
            this.descCargo.MinimumWidth = 8;
            this.descCargo.Name = "descCargo";
            this.descCargo.ReadOnly = true;
            this.descCargo.Width = 135;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(812, 644);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 68);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1036, 644);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 68);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCurso,
            this.btnEditCurso,
            this.tbnDeleteCurso,
            this.toolStripSeparator1,
            this.btnAsignarDocente});
            this.tsMaterias.Location = new System.Drawing.Point(4, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(240, 57);
            this.tsMaterias.TabIndex = 0;
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCurso.Image")));
            this.btnAddCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(34, 52);
            this.btnAddCurso.Text = "Agregar Curso";
            // 
            // btnEditCurso
            // 
            this.btnEditCurso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCurso.Image")));
            this.btnEditCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCurso.Name = "btnEditCurso";
            this.btnEditCurso.Size = new System.Drawing.Size(34, 28);
            this.btnEditCurso.Text = "editar Curso";
            // 
            // tbnDeleteCurso
            // 
            this.tbnDeleteCurso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbnDeleteCurso.Image = ((System.Drawing.Image)(resources.GetObject("tbnDeleteCurso.Image")));
            this.tbnDeleteCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnDeleteCurso.Name = "tbnDeleteCurso";
            this.tbnDeleteCurso.Size = new System.Drawing.Size(34, 28);
            this.tbnDeleteCurso.Text = "Borrar Curso";
            this.tbnDeleteCurso.ToolTipText = "Borrar Curso";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnAsignarDocente
            // 
            this.btnAsignarDocente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAsignarDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarDocente.Image")));
            this.btnAsignarDocente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsignarDocente.Name = "btnAsignarDocente";
            this.btnAsignarDocente.Size = new System.Drawing.Size(34, 28);
            this.btnAsignarDocente.Text = "Asignar Docente";
            // 
            // Dictados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 547);
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dictados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Dictados_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictados)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton btnAddCurso;
        private System.Windows.Forms.ToolStripButton btnEditCurso;
        private System.Windows.Forms.ToolStripButton tbnDeleteCurso;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvDictados;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAsignarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCargo;
    }
}