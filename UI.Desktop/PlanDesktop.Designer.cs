
namespace UI.Desktop
{
    partial class PlanDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanDesktop));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePlan = new System.Windows.Forms.Button();
            this.idLine = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDess = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDesc = new System.Windows.Forms.Label();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnSavePlan
            // 
            this.btnSavePlan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSavePlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePlan.FlatAppearance.BorderSize = 0;
            this.btnSavePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlan.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePlan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSavePlan.Location = new System.Drawing.Point(70, 542);
            this.btnSavePlan.Name = "btnSavePlan";
            this.btnSavePlan.Size = new System.Drawing.Size(148, 52);
            this.btnSavePlan.TabIndex = 3;
            this.btnSavePlan.Text = "Guardar";
            this.btnSavePlan.UseVisualStyleBackColor = false;
            this.btnSavePlan.Click += new System.EventHandler(this.btnSavePlan_Click);
            // 
            // idLine
            // 
            this.idLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.idLine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.idLine.Location = new System.Drawing.Point(84, 251);
            this.idLine.Name = "idLine";
            this.idLine.Size = new System.Drawing.Size(324, 2);
            this.idLine.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtId.Location = new System.Drawing.Point(84, 203);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(324, 47);
            this.txtId.TabIndex = 0;
            // 
            // txtDess
            // 
            this.txtDess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDess.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDess.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDess.Location = new System.Drawing.Point(84, 316);
            this.txtDess.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtDess.Multiline = true;
            this.txtDess.Name = "txtDess";
            this.txtDess.Size = new System.Drawing.Size(324, 47);
            this.txtDess.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(84, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 2);
            this.panel1.TabIndex = 5;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.Color.White;
            this.lbDesc.Location = new System.Drawing.Point(79, 270);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(139, 29);
            this.lbDesc.TabIndex = 4;
            this.lbDesc.Text = "Descripcion";
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEspecialidades.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidades.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.ItemHeight = 29;
            this.cbEspecialidades.Location = new System.Drawing.Point(84, 447);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(324, 37);
            this.cbEspecialidades.Sorted = true;
            this.cbEspecialidades.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Especialidad";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(260, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 52);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(107, 29);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(276, 37);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Agregar un Plan ";
            // 
            // PlanDesktop
            // 
            this.AcceptButton = this.btnSavePlan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 699);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEspecialidades);
            this.Controls.Add(this.txtDess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.idLine);
            this.Controls.Add(this.btnSavePlan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanDesktop";
            this.Load += new System.EventHandler(this.PlanDesktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePlan;
        private System.Windows.Forms.Panel idLine;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTitle;
    }
}