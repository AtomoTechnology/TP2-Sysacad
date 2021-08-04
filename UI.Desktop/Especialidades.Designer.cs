
namespace UI.Desktop
{
    partial class Especialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidades));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsEspecialiddes = new System.Windows.Forms.ToolStrip();
            this.btnAddEsp = new System.Windows.Forms.ToolStripButton();
            this.btnEditEsp = new System.Windows.Forms.ToolStripButton();
            this.tbnDeleteEsp = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.tsEspecialiddes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1412, 804);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(1412, 842);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsEspecialiddes);
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnUpdate, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClose, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 2;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.Size = new System.Drawing.Size(1412, 804);
            this.tlpEspecialidades.TabIndex = 0;
            this.tlpEspecialidades.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpEspecialidades_Paint);
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AllowUserToOrderColumns = true;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidth = 62;
            this.dgvEspecialidades.RowTemplate.Height = 28;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(1406, 724);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackgroundImage = global::UI.Desktop.Properties.Resources.updated;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1009, 733);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 68);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1198, 733);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(211, 68);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // tsEspecialiddes
            // 
            this.tsEspecialiddes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialiddes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsEspecialiddes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEsp,
            this.btnEditEsp,
            this.tbnDeleteEsp});
            this.tsEspecialiddes.Location = new System.Drawing.Point(14, 0);
            this.tsEspecialiddes.Name = "tsEspecialiddes";
            this.tsEspecialiddes.Size = new System.Drawing.Size(120, 38);
            this.tsEspecialiddes.TabIndex = 0;
            // 
            // btnAddEsp
            // 
            this.btnAddEsp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEsp.Image")));
            this.btnAddEsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEsp.Name = "btnAddEsp";
            this.btnAddEsp.Size = new System.Drawing.Size(34, 33);
            this.btnAddEsp.Text = "Agregar Especialidad";
            this.btnAddEsp.Click += new System.EventHandler(this.btnAddEsp_Click_1);
            // 
            // btnEditEsp
            // 
            this.btnEditEsp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEsp.Image")));
            this.btnEditEsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEsp.Name = "btnEditEsp";
            this.btnEditEsp.Size = new System.Drawing.Size(34, 33);
            this.btnEditEsp.Text = "editar Especialidad";
            this.btnEditEsp.Click += new System.EventHandler(this.btnEditEsp_Click_1);
            // 
            // tbnDeleteEsp
            // 
            this.tbnDeleteEsp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbnDeleteEsp.Image = ((System.Drawing.Image)(resources.GetObject("tbnDeleteEsp.Image")));
            this.tbnDeleteEsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbnDeleteEsp.Name = "tbnDeleteEsp";
            this.tbnDeleteEsp.Size = new System.Drawing.Size(34, 33);
            this.tbnDeleteEsp.Text = "Borrar Especialidad";
            this.tbnDeleteEsp.Click += new System.EventHandler(this.tbnDeleteEsp_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 842);
            this.Controls.Add(this.tscEspecialidades);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.tsEspecialiddes.ResumeLayout(false);
            this.tsEspecialiddes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsEspecialiddes;
        private System.Windows.Forms.ToolStripButton btnAddEsp;
        private System.Windows.Forms.ToolStripButton btnEditEsp;
        private System.Windows.Forms.ToolStripButton tbnDeleteEsp;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}