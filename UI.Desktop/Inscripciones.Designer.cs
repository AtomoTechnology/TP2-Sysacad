
namespace UI.Desktop
{
    partial class Insccipciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insccipciones));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarNota = new System.Windows.Forms.Button();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertarNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertarCondicion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.btnAddInscripcion = new System.Windows.Forms.ToolStripButton();
            this.btnEditInscripcion = new System.Windows.Forms.ToolStripButton();
            this.tbnDeleteInscripcion = new System.Windows.Forms.ToolStripButton();
            this.pnlFiltroIns = new System.Windows.Forms.Panel();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarIns = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarFiltro = new System.Windows.Forms.Button();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.pnlFiltroIns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1467, 616);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(1467, 649);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsMaterias);
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.ColumnCount = 3;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tlpEspecialidades.Controls.Add(this.btnRegistrarNota, 1, 2);
            this.tlpEspecialidades.Controls.Add(this.dgvInscripciones, 1, 0);
            this.tlpEspecialidades.Controls.Add(this.btnUpdate, 1, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClose, 2, 1);
            this.tlpEspecialidades.Controls.Add(this.pnlFiltroIns, 0, 0);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 3;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpEspecialidades.Size = new System.Drawing.Size(1467, 616);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.AutoSize = true;
            this.btnRegistrarNota.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpEspecialidades.SetColumnSpan(this.btnRegistrarNota, 2);
            this.btnRegistrarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarNota.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarNota.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarNota.Location = new System.Drawing.Point(1031, 537);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(433, 76);
            this.btnRegistrarNota.TabIndex = 3;
            this.btnRegistrarNota.Text = "Registrar Nota";
            this.btnRegistrarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarNota.UseVisualStyleBackColor = false;
            this.btnRegistrarNota.Visible = false;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AllowUserToResizeColumns = false;
            this.dgvInscripciones.AllowUserToResizeRows = false;
            this.dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInscripciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInscripciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.dgvInscripciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInscripciones.ColumnHeadersHeight = 30;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.isCurso,
            this.descMateria,
            this.descComision,
            this.legajo,
            this.NombreApellido,
            this.Condicion,
            this.nota,
            this.InsertarNota,
            this.InsertarCondicion});
            this.tlpEspecialidades.SetColumnSpan(this.dgvInscripciones, 2);
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.EnableHeadersVisualStyles = false;
            this.dgvInscripciones.Location = new System.Drawing.Point(358, 3);
            this.dgvInscripciones.MultiSelect = false;
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInscripciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInscripciones.RowHeadersWidth = 62;
            this.dgvInscripciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvInscripciones.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInscripciones.RowTemplate.Height = 28;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(1106, 454);
            this.dgvInscripciones.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID Inscripcion";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 242;
            // 
            // isCurso
            // 
            this.isCurso.DataPropertyName = "IdCurso";
            this.isCurso.HeaderText = "ID Curso";
            this.isCurso.MinimumWidth = 8;
            this.isCurso.Name = "isCurso";
            this.isCurso.ReadOnly = true;
            this.isCurso.Width = 169;
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
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 8;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 144;
            // 
            // NombreApellido
            // 
            this.NombreApellido.DataPropertyName = "NombreCompleto";
            this.NombreApellido.HeaderText = "Nombre Apellido";
            this.NombreApellido.MinimumWidth = 8;
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.ReadOnly = true;
            this.NombreApellido.Width = 281;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.MinimumWidth = 8;
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            this.Condicion.Width = 190;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "notaString";
            this.nota.HeaderText = "Nota";
            this.nota.MinimumWidth = 8;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Width = 115;
            // 
            // InsertarNota
            // 
            this.InsertarNota.DataPropertyName = "InsertarNota";
            this.InsertarNota.HeaderText = "Insertar Nota";
            this.InsertarNota.MinimumWidth = 8;
            this.InsertarNota.Name = "InsertarNota";
            this.InsertarNota.ReadOnly = true;
            this.InsertarNota.Width = 231;
            // 
            // InsertarCondicion
            // 
            this.InsertarCondicion.DataPropertyName = "InsertarCondicion";
            this.InsertarCondicion.HeaderText = "Insertar Condicion";
            this.InsertarCondicion.Items.AddRange(new object[] {
            "Aprobada",
            "Cursando",
            "Libre",
            "Regular"});
            this.InsertarCondicion.MinimumWidth = 8;
            this.InsertarCondicion.Name = "InsertarCondicion";
            this.InsertarCondicion.ReadOnly = true;
            this.InsertarCondicion.Sorted = true;
            this.InsertarCondicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InsertarCondicion.Width = 306;
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
            this.btnUpdate.Location = new System.Drawing.Point(999, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 68);
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
            this.btnClose.Location = new System.Drawing.Point(1255, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 68);
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
            this.btnAddInscripcion,
            this.btnEditInscripcion,
            this.tbnDeleteInscripcion});
            this.tsMaterias.Location = new System.Drawing.Point(14, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(120, 33);
            this.tsMaterias.TabIndex = 0;
            // 
            // btnAddInscripcion
            // 
            this.btnAddInscripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInscripcion.Image")));
            this.btnAddInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddInscripcion.Name = "btnAddInscripcion";
            this.btnAddInscripcion.Size = new System.Drawing.Size(34, 28);
            this.btnAddInscripcion.Text = "Agregar Inscripcion";
            this.btnAddInscripcion.Click += new System.EventHandler(this.btnAddInscripcion_Click);
            // 
            // btnEditInscripcion
            // 
            this.btnEditInscripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInscripcion.Image")));
            this.btnEditInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditInscripcion.Name = "btnEditInscripcion";
            this.btnEditInscripcion.Size = new System.Drawing.Size(34, 28);
            this.btnEditInscripcion.Text = "editar Inscripcion";
            this.btnEditInscripcion.Click += new System.EventHandler(this.btnEditInscripcion_Click);
            // 
            // tbnDeleteInscripcion
            // 
            this.tbnDeleteInscripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbnDeleteInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("tbnDeleteInscripcion.Image")));
            this.tbnDeleteInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnDeleteInscripcion.Name = "tbnDeleteInscripcion";
            this.tbnDeleteInscripcion.Size = new System.Drawing.Size(34, 28);
            this.tbnDeleteInscripcion.Text = "Borrar Inscripcion";
            this.tbnDeleteInscripcion.ToolTipText = "Borrar Curso";
            this.tbnDeleteInscripcion.Click += new System.EventHandler(this.tbnDeleteInscripcion_Click);
            // 
            // pnlFiltroIns
            // 
            this.pnlFiltroIns.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFiltroIns.Controls.Add(this.btnBorrarFiltro);
            this.pnlFiltroIns.Controls.Add(this.label2);
            this.pnlFiltroIns.Controls.Add(this.btnFiltrarIns);
            this.pnlFiltroIns.Controls.Add(this.label1);
            this.pnlFiltroIns.Controls.Add(this.label5);
            this.pnlFiltroIns.Controls.Add(this.cbComision);
            this.pnlFiltroIns.Controls.Add(this.cbMateria);
            this.pnlFiltroIns.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltroIns.Name = "pnlFiltroIns";
            this.pnlFiltroIns.Size = new System.Drawing.Size(293, 454);
            this.pnlFiltroIns.TabIndex = 4;
            this.pnlFiltroIns.Visible = false;
            // 
            // cbMateria
            // 
            this.cbMateria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMateria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMateria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.ItemHeight = 28;
            this.cbMateria.Location = new System.Drawing.Point(22, 101);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(255, 36);
            this.cbMateria.Sorted = true;
            this.cbMateria.TabIndex = 1;
            // 
            // cbComision
            // 
            this.cbComision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbComision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cbComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbComision.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComision.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.ItemHeight = 28;
            this.cbComision.Location = new System.Drawing.Point(22, 190);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(255, 36);
            this.cbComision.Sorted = true;
            this.cbComision.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comision";
            // 
            // btnFiltrarIns
            // 
            this.btnFiltrarIns.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFiltrarIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarIns.FlatAppearance.BorderSize = 0;
            this.btnFiltrarIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarIns.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarIns.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrarIns.Location = new System.Drawing.Point(22, 265);
            this.btnFiltrarIns.Name = "btnFiltrarIns";
            this.btnFiltrarIns.Size = new System.Drawing.Size(250, 59);
            this.btnFiltrarIns.TabIndex = 21;
            this.btnFiltrarIns.Text = "Filtrar";
            this.btnFiltrarIns.UseVisualStyleBackColor = false;
            this.btnFiltrarIns.Click += new System.EventHandler(this.btnFiltrarIns_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(110, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filtro";
            // 
            // btnBorrarFiltro
            // 
            this.btnBorrarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarFiltro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBorrarFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFiltro.Font = new System.Drawing.Font("Bowlby One SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarFiltro.Location = new System.Drawing.Point(22, 371);
            this.btnBorrarFiltro.Name = "btnBorrarFiltro";
            this.btnBorrarFiltro.Size = new System.Drawing.Size(250, 68);
            this.btnBorrarFiltro.TabIndex = 23;
            this.btnBorrarFiltro.Text = "Borrar filtro";
            this.btnBorrarFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarFiltro.UseVisualStyleBackColor = false;
            this.btnBorrarFiltro.Click += new System.EventHandler(this.btnBorrarFiltro_Click);
            // 
            // Insccipciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 649);
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insccipciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Insccipciones_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            this.tlpEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.pnlFiltroIns.ResumeLayout(false);
            this.pnlFiltroIns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton btnAddInscripcion;
        private System.Windows.Forms.ToolStripButton btnEditInscripcion;
        private System.Windows.Forms.ToolStripButton tbnDeleteInscripcion;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertarNota;
        private System.Windows.Forms.DataGridViewComboBoxColumn InsertarCondicion;
        private System.Windows.Forms.Button btnRegistrarNota;
        private System.Windows.Forms.Panel pnlFiltroIns;
        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarIns;
        private System.Windows.Forms.Button btnBorrarFiltro;
    }
}