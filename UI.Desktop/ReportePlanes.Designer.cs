
namespace UI.Desktop
{
    partial class ReportePlanes
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
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReportePlanes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpcion1 = new System.Windows.Forms.ComboBox();
            this.cbOpciones2 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePlanes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1952, 1075);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(1952, 1100);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            this.tscEspecialidades.TopToolStripPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tscEspecialidades.TopToolStripPanel.ForeColor = System.Drawing.Color.White;
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tlpEspecialidades.Controls.Add(this.dgvReportePlanes, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.panel1, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnSalir, 1, 2);
            this.tlpEspecialidades.Controls.Add(this.btnUpdate, 0, 2);
            this.tlpEspecialidades.Controls.Add(this.panel2, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 3;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpEspecialidades.Size = new System.Drawing.Size(1952, 1075);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // dgvReportePlanes
            // 
            this.dgvReportePlanes.AllowUserToAddRows = false;
            this.dgvReportePlanes.AllowUserToDeleteRows = false;
            this.dgvReportePlanes.AllowUserToOrderColumns = true;
            this.dgvReportePlanes.AllowUserToResizeColumns = false;
            this.dgvReportePlanes.AllowUserToResizeRows = false;
            this.dgvReportePlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvReportePlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportePlanes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.dgvReportePlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportePlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportePlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportePlanes.ColumnHeadersHeight = 30;
            this.dgvReportePlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReportePlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descPlan,
            this.descMateria,
            this.hsSemanales,
            this.hsTotales});
            this.dgvReportePlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportePlanes.EnableHeadersVisualStyles = false;
            this.dgvReportePlanes.Location = new System.Drawing.Point(3, 86);
            this.dgvReportePlanes.MultiSelect = false;
            this.dgvReportePlanes.Name = "dgvReportePlanes";
            this.dgvReportePlanes.ReadOnly = true;
            this.dgvReportePlanes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReportePlanes.RowHeadersWidth = 62;
            this.dgvReportePlanes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportePlanes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportePlanes.RowTemplate.Height = 28;
            this.dgvReportePlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportePlanes.Size = new System.Drawing.Size(1587, 923);
            this.dgvReportePlanes.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.tlpEspecialidades.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1946, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.cbOpciones2);
            this.panel3.Controls.Add(this.cbOpcion1);
            this.panel3.Location = new System.Drawing.Point(3, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 844);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bowlby One SC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte Planes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1596, 1015);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(264, 57);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1337, 1015);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(253, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1596, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 923);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bowlby One SC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(-16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOpcion1
            // 
            this.cbOpcion1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbOpcion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOpcion1.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcion1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbOpcion1.FormattingEnabled = true;
            this.cbOpcion1.Items.AddRange(new object[] {
            "",
            "Plan",
            "Materia"});
            this.cbOpcion1.Location = new System.Drawing.Point(19, 102);
            this.cbOpcion1.Name = "cbOpcion1";
            this.cbOpcion1.Size = new System.Drawing.Size(320, 51);
            this.cbOpcion1.TabIndex = 1;
            this.cbOpcion1.SelectedIndexChanged += new System.EventHandler(this.cbOpcion1_SelectedIndexChanged);
            // 
            // cbOpciones2
            // 
            this.cbOpciones2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbOpciones2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpciones2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOpciones2.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpciones2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbOpciones2.FormattingEnabled = true;
            this.cbOpciones2.Items.AddRange(new object[] {
            "Plan",
            "Materia"});
            this.cbOpciones2.Location = new System.Drawing.Point(14, 284);
            this.cbOpciones2.Name = "cbOpciones2";
            this.cbOpciones2.Size = new System.Drawing.Size(325, 51);
            this.cbOpciones2.TabIndex = 2;
            this.cbOpciones2.SelectedIndexChanged += new System.EventHandler(this.cbOpciones2_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(14, 464);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(325, 52);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar Por : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(14, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdPlan";
            this.ID.HeaderText = "ID Plan";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 132;
            // 
            // descPlan
            // 
            this.descPlan.DataPropertyName = "DescPlan";
            this.descPlan.HeaderText = "Desc. Plan";
            this.descPlan.MinimumWidth = 8;
            this.descPlan.Name = "descPlan";
            this.descPlan.ReadOnly = true;
            this.descPlan.Width = 173;
            // 
            // descMateria
            // 
            this.descMateria.DataPropertyName = "DescMateria";
            this.descMateria.HeaderText = "Desc Materia";
            this.descMateria.MinimumWidth = 8;
            this.descMateria.Name = "descMateria";
            this.descMateria.ReadOnly = true;
            this.descMateria.Width = 201;
            // 
            // hsSemanales
            // 
            this.hsSemanales.DataPropertyName = "HsSemanales";
            this.hsSemanales.HeaderText = "Hs Semanales";
            this.hsSemanales.MinimumWidth = 8;
            this.hsSemanales.Name = "hsSemanales";
            this.hsSemanales.ReadOnly = true;
            this.hsSemanales.Width = 216;
            // 
            // hsTotales
            // 
            this.hsTotales.DataPropertyName = "HsTotales";
            this.hsTotales.HeaderText = "HS. Totales";
            this.hsTotales.MinimumWidth = 8;
            this.hsTotales.Name = "hsTotales";
            this.hsTotales.ReadOnly = true;
            this.hsTotales.Width = 185;
            // 
            // ReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1952, 1100);
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportePlanes";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.ReportePlanes_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePlanes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvReportePlanes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbOpciones2;
        private System.Windows.Forms.ComboBox cbOpcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTotales;
    }
}