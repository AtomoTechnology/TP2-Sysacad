
namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.btnAsignarCurso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbDocente = new System.Windows.Forms.PictureBox();
            this.pbCursos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asignar Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Docente";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.Location = new System.Drawing.Point(46, 173);
            this.txtIdCurso.Multiline = true;
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(232, 50);
            this.txtIdCurso.TabIndex = 6;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDocente.Location = new System.Drawing.Point(46, 317);
            this.txtIdDocente.Multiline = true;
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(232, 50);
            this.txtIdDocente.TabIndex = 7;
            // 
            // btnAsignarCurso
            // 
            this.btnAsignarCurso.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsignarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarCurso.Font = new System.Drawing.Font("Bowlby One SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarCurso.Location = new System.Drawing.Point(46, 514);
            this.btnAsignarCurso.Name = "btnAsignarCurso";
            this.btnAsignarCurso.Size = new System.Drawing.Size(144, 53);
            this.btnAsignarCurso.TabIndex = 8;
            this.btnAsignarCurso.Text = "Asignar";
            this.btnAsignarCurso.UseVisualStyleBackColor = false;
            this.btnAsignarCurso.Click += new System.EventHandler(this.btnAsignarCurso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bowlby One SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(223, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 53);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbDocente
            // 
            this.pbDocente.BackColor = System.Drawing.Color.White;
            this.pbDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDocente.Image = global::UI.Desktop.Properties.Resources.estudiante;
            this.pbDocente.Location = new System.Drawing.Point(298, 317);
            this.pbDocente.Name = "pbDocente";
            this.pbDocente.Size = new System.Drawing.Size(64, 50);
            this.pbDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDocente.TabIndex = 10;
            this.pbDocente.TabStop = false;
            this.pbDocente.Click += new System.EventHandler(this.pbDocente_Click);
            // 
            // pbCursos
            // 
            this.pbCursos.BackColor = System.Drawing.Color.White;
            this.pbCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCursos.Image = global::UI.Desktop.Properties.Resources.estudiante;
            this.pbCursos.Location = new System.Drawing.Point(298, 173);
            this.pbCursos.Name = "pbCursos";
            this.pbCursos.Size = new System.Drawing.Size(64, 50);
            this.pbCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCursos.TabIndex = 12;
            this.pbCursos.TabStop = false;
            this.pbCursos.Click += new System.EventHandler(this.pbCursos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bowlby One SC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbCargo.Location = new System.Drawing.Point(46, 439);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(316, 40);
            this.cbCargo.Sorted = true;
            this.cbCargo.TabIndex = 14;
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(410, 612);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCursos);
            this.Controls.Add(this.pbDocente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignarCurso);
            this.Controls.Add(this.txtIdDocente);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocenteCursoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocenteCursoDesktop";
            ((System.ComponentModel.ISupportInitialize)(this.pbDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.Button btnAsignarCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbDocente;
        private System.Windows.Forms.PictureBox pbCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCargo;
    }
}