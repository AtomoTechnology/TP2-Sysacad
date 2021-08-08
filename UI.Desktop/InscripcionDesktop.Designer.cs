
namespace UI.Desktop
{
    partial class InscripcionDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionDesktop));
            this.txtNota = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.idLine = new System.Windows.Forms.Panel();
            this.btnSaveInscripcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCondicions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNota
            // 
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNota.Location = new System.Drawing.Point(51, 584);
            this.txtNota.MaxLength = 2;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(353, 47);
            this.txtNota.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(51, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 2);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(47, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nota";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(45, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(393, 37);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Realizar una Inscripcion";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(260, 694);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cursos";
            // 
            // cbCursos
            // 
            this.cbCursos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCursos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCursos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.ItemHeight = 28;
            this.cbCursos.Location = new System.Drawing.Point(52, 367);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(357, 36);
            this.cbCursos.Sorted = true;
            this.cbCursos.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtId.Location = new System.Drawing.Point(52, 136);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(352, 47);
            this.txtId.TabIndex = 3;
            // 
            // idLine
            // 
            this.idLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.idLine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.idLine.Location = new System.Drawing.Point(52, 184);
            this.idLine.Name = "idLine";
            this.idLine.Size = new System.Drawing.Size(352, 2);
            this.idLine.TabIndex = 2;
            // 
            // btnSaveInscripcion
            // 
            this.btnSaveInscripcion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInscripcion.FlatAppearance.BorderSize = 0;
            this.btnSaveInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInscripcion.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInscripcion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveInscripcion.Location = new System.Drawing.Point(51, 694);
            this.btnSaveInscripcion.Name = "btnSaveInscripcion";
            this.btnSaveInscripcion.Size = new System.Drawing.Size(148, 52);
            this.btnSaveInscripcion.TabIndex = 5;
            this.btnSaveInscripcion.Text = "Guardar";
            this.btnSaveInscripcion.UseVisualStyleBackColor = false;
            this.btnSaveInscripcion.Click += new System.EventHandler(this.btnSaveCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(47, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alumnos";
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlumnos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.ItemHeight = 28;
            this.cbAlumnos.Location = new System.Drawing.Point(52, 257);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(357, 36);
            this.cbAlumnos.Sorted = true;
            this.cbAlumnos.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(47, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Condicion";
            // 
            // cbCondicions
            // 
            this.cbCondicions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCondicions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondicions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondicions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbCondicions.FormattingEnabled = true;
            this.cbCondicions.ItemHeight = 28;
            this.cbCondicions.Items.AddRange(new object[] {
            "Aprobada",
            "Cursando",
            "Libre",
            "Regular"});
            this.cbCondicions.Location = new System.Drawing.Point(52, 474);
            this.cbCondicions.Name = "cbCondicions";
            this.cbCondicions.Size = new System.Drawing.Size(357, 36);
            this.cbCondicions.Sorted = true;
            this.cbCondicions.TabIndex = 19;
            // 
            // InscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(471, 793);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCondicions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAlumnos);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.idLine);
            this.Controls.Add(this.btnSaveInscripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscripcionDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveInscripcion;
        private System.Windows.Forms.Panel idLine;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCondicions;
    }
}