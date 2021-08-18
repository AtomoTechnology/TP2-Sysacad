
namespace UI.Desktop
{
    partial class UserPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPerfil));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderPerfil = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreferencias = new System.Windows.Forms.Button();
            this.btnMateriasAprobadas = new System.Windows.Forms.Button();
            this.lineBorder = new System.Windows.Forms.Panel();
            this.btnMisDatos = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeaderPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlHeaderPerfil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBody, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.05505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.94495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1688, 955);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlHeaderPerfil
            // 
            this.pnlHeaderPerfil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlHeaderPerfil.Controls.Add(this.pictureBox2);
            this.pnlHeaderPerfil.Controls.Add(this.panel1);
            this.pnlHeaderPerfil.Controls.Add(this.lblUsername);
            this.pnlHeaderPerfil.Controls.Add(this.pictureBox1);
            this.pnlHeaderPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderPerfil.Location = new System.Drawing.Point(3, 3);
            this.pnlHeaderPerfil.Name = "pnlHeaderPerfil";
            this.pnlHeaderPerfil.Size = new System.Drawing.Size(1682, 386);
            this.pnlHeaderPerfil.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UI.Desktop.Properties.Resources.CerrarForm1;
            this.pictureBox2.Location = new System.Drawing.Point(1603, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnPreferencias);
            this.panel1.Controls.Add(this.btnMateriasAprobadas);
            this.panel1.Controls.Add(this.lineBorder);
            this.panel1.Controls.Add(this.btnMisDatos);
            this.panel1.Location = new System.Drawing.Point(-12, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1697, 96);
            this.panel1.TabIndex = 2;
            // 
            // btnPreferencias
            // 
            this.btnPreferencias.BackColor = System.Drawing.Color.Transparent;
            this.btnPreferencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreferencias.FlatAppearance.BorderSize = 0;
            this.btnPreferencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPreferencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferencias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferencias.ForeColor = System.Drawing.Color.White;
            this.btnPreferencias.Location = new System.Drawing.Point(797, 3);
            this.btnPreferencias.Name = "btnPreferencias";
            this.btnPreferencias.Size = new System.Drawing.Size(221, 72);
            this.btnPreferencias.TabIndex = 8;
            this.btnPreferencias.Text = "Preferencias";
            this.btnPreferencias.UseVisualStyleBackColor = false;
            this.btnPreferencias.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnMateriasAprobadas
            // 
            this.btnMateriasAprobadas.BackColor = System.Drawing.Color.Transparent;
            this.btnMateriasAprobadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriasAprobadas.FlatAppearance.BorderSize = 0;
            this.btnMateriasAprobadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMateriasAprobadas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMateriasAprobadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriasAprobadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriasAprobadas.ForeColor = System.Drawing.Color.White;
            this.btnMateriasAprobadas.Location = new System.Drawing.Point(477, 2);
            this.btnMateriasAprobadas.Name = "btnMateriasAprobadas";
            this.btnMateriasAprobadas.Size = new System.Drawing.Size(314, 72);
            this.btnMateriasAprobadas.TabIndex = 6;
            this.btnMateriasAprobadas.Text = "Materias Aprobadas";
            this.btnMateriasAprobadas.UseVisualStyleBackColor = false;
            this.btnMateriasAprobadas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lineBorder
            // 
            this.lineBorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineBorder.Location = new System.Drawing.Point(297, 83);
            this.lineBorder.Name = "lineBorder";
            this.lineBorder.Size = new System.Drawing.Size(169, 10);
            this.lineBorder.TabIndex = 4;
            // 
            // btnMisDatos
            // 
            this.btnMisDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnMisDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisDatos.FlatAppearance.BorderSize = 0;
            this.btnMisDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMisDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisDatos.ForeColor = System.Drawing.Color.White;
            this.btnMisDatos.Location = new System.Drawing.Point(289, 3);
            this.btnMisDatos.Name = "btnMisDatos";
            this.btnMisDatos.Size = new System.Drawing.Size(182, 71);
            this.btnMisDatos.TabIndex = 7;
            this.btnMisDatos.Text = "Mis datos";
            this.btnMisDatos.UseVisualStyleBackColor = false;
            this.btnMisDatos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(280, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(127, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.AutoSize = true;
            this.pnlBody.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(3, 395);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1682, 557);
            this.pnlBody.TabIndex = 1;
            // 
            // UserPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Desktop.Properties.Resources.Shadow_Notificaciones;
            this.ClientSize = new System.Drawing.Size(1688, 955);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPerfil";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.UserPerfil_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlHeaderPerfil.ResumeLayout(false);
            this.pnlHeaderPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlHeaderPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMateriasAprobadas;
        private System.Windows.Forms.Panel lineBorder;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnMisDatos;
        private System.Windows.Forms.Button btnPreferencias;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}