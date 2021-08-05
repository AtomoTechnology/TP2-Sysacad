
namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.btnAddComision = new System.Windows.Forms.ToolStripButton();
            this.btnEditComision = new System.Windows.Forms.ToolStripButton();
            this.tbnDeleteComision = new System.Windows.Forms.ToolStripButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1243, 753);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(1243, 786);
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
            this.tlpEspecialidades.Controls.Add(this.dgvComisiones, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnUpdate, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClose, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 3;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEspecialidades.Size = new System.Drawing.Size(1243, 753);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.AllowUserToResizeColumns = false;
            this.dgvComisiones.AllowUserToResizeRows = false;
            this.dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvComisiones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComisiones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvComisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComisiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComisiones.ColumnHeadersHeight = 30;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descComision,
            this.anioEspecialidad,
            this.descPlan});
            this.tlpEspecialidades.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.EnableHeadersVisualStyles = false;
            this.dgvComisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComisiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComisiones.RowHeadersWidth = 62;
            this.dgvComisiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvComisiones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvComisiones.RowTemplate.Height = 28;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(1237, 653);
            this.dgvComisiones.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(758, 662);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(227, 68);
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
            this.btnClose.Location = new System.Drawing.Point(991, 662);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(249, 68);
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
            this.btnAddComision,
            this.btnEditComision,
            this.tbnDeleteComision});
            this.tsMaterias.Location = new System.Drawing.Point(14, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(120, 33);
            this.tsMaterias.TabIndex = 0;
            // 
            // btnAddComision
            // 
            this.btnAddComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddComision.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComision.Image")));
            this.btnAddComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddComision.Name = "btnAddComision";
            this.btnAddComision.Size = new System.Drawing.Size(34, 28);
            this.btnAddComision.Text = "Agregar Comision";
            this.btnAddComision.Click += new System.EventHandler(this.btnAddComision_Click);
            // 
            // btnEditComision
            // 
            this.btnEditComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditComision.Image = ((System.Drawing.Image)(resources.GetObject("btnEditComision.Image")));
            this.btnEditComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditComision.Name = "btnEditComision";
            this.btnEditComision.Size = new System.Drawing.Size(34, 28);
            this.btnEditComision.Text = "editar Comision";
            this.btnEditComision.Click += new System.EventHandler(this.btnEditComision_Click);
            // 
            // tbnDeleteComision
            // 
            this.tbnDeleteComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbnDeleteComision.Image = ((System.Drawing.Image)(resources.GetObject("tbnDeleteComision.Image")));
            this.tbnDeleteComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnDeleteComision.Name = "tbnDeleteComision";
            this.tbnDeleteComision.Size = new System.Drawing.Size(34, 28);
            this.tbnDeleteComision.Text = "Borrar Comision";
            this.tbnDeleteComision.ToolTipText = "Borrar Comision";
            this.tbnDeleteComision.Click += new System.EventHandler(this.tbnDeleteComision_Click);
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
            // descComision
            // 
            this.descComision.DataPropertyName = "DescComision";
            this.descComision.HeaderText = "Desc. Comision";
            this.descComision.MinimumWidth = 8;
            this.descComision.Name = "descComision";
            this.descComision.ReadOnly = true;
            this.descComision.Width = 264;
            // 
            // anioEspecialidad
            // 
            this.anioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.anioEspecialidad.HeaderText = "Año Especialidad";
            this.anioEspecialidad.MinimumWidth = 8;
            this.anioEspecialidad.Name = "anioEspecialidad";
            this.anioEspecialidad.ReadOnly = true;
            this.anioEspecialidad.Width = 291;
            // 
            // descPlan
            // 
            this.descPlan.DataPropertyName = "DescPlan";
            this.descPlan.HeaderText = "Desc Plan";
            this.descPlan.MinimumWidth = 8;
            this.descPlan.Name = "descPlan";
            this.descPlan.ReadOnly = true;
            this.descPlan.Width = 188;
            // 
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 786);
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton btnAddComision;
        private System.Windows.Forms.ToolStripButton btnEditComision;
        private System.Windows.Forms.ToolStripButton tbnDeleteComision;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPlan;
    }
}