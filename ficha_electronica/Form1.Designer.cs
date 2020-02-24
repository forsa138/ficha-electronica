namespace ficha_electronica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_izq = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnReportePaciente = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnReporteTratamientos = new System.Windows.Forms.Button();
            this.SubmenuPaciente = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnCreapaciente = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnBuscaPaciente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonReportes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonPaciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_izq.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            this.SubmenuPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.pictureBox2);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1084, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1055, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel_izq
            // 
            this.Panel_izq.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Panel_izq.Controls.Add(this.SubmenuReportes);
            this.Panel_izq.Controls.Add(this.SubmenuPaciente);
            this.Panel_izq.Controls.Add(this.panel3);
            this.Panel_izq.Controls.Add(this.button3);
            this.Panel_izq.Controls.Add(this.panel2);
            this.Panel_izq.Controls.Add(this.BotonReportes);
            this.Panel_izq.Controls.Add(this.panel1);
            this.Panel_izq.Controls.Add(this.BotonPaciente);
            this.Panel_izq.Controls.Add(this.pictureBox1);
            this.Panel_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_izq.Location = new System.Drawing.Point(0, 35);
            this.Panel_izq.Name = "Panel_izq";
            this.Panel_izq.Size = new System.Drawing.Size(200, 635);
            this.Panel_izq.TabIndex = 1;
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel4);
            this.SubmenuReportes.Controls.Add(this.BtnReportePaciente);
            this.SubmenuReportes.Controls.Add(this.panel7);
            this.SubmenuReportes.Controls.Add(this.BtnReporteTratamientos);
            this.SubmenuReportes.Location = new System.Drawing.Point(36, 190);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(161, 100);
            this.SubmenuReportes.TabIndex = 2;
            this.SubmenuReportes.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 35);
            this.panel4.TabIndex = 5;
            // 
            // BtnReportePaciente
            // 
            this.BtnReportePaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnReportePaciente.FlatAppearance.BorderSize = 0;
            this.BtnReportePaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnReportePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportePaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReportePaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportePaciente.Location = new System.Drawing.Point(15, 3);
            this.BtnReportePaciente.Name = "BtnReportePaciente";
            this.BtnReportePaciente.Size = new System.Drawing.Size(149, 35);
            this.BtnReportePaciente.TabIndex = 6;
            this.BtnReportePaciente.Text = "ReportePacientes";
            this.BtnReportePaciente.UseVisualStyleBackColor = false;
            this.BtnReportePaciente.Click += new System.EventHandler(this.BtnReportePaciente_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(3, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 35);
            this.panel7.TabIndex = 5;
            // 
            // BtnReporteTratamientos
            // 
            this.BtnReporteTratamientos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnReporteTratamientos.FlatAppearance.BorderSize = 0;
            this.BtnReporteTratamientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnReporteTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporteTratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteTratamientos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReporteTratamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporteTratamientos.Location = new System.Drawing.Point(15, 41);
            this.BtnReporteTratamientos.Name = "BtnReporteTratamientos";
            this.BtnReporteTratamientos.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteTratamientos.TabIndex = 6;
            this.BtnReporteTratamientos.Text = "Reporte Tratamientos";
            this.BtnReporteTratamientos.UseVisualStyleBackColor = false;
            this.BtnReporteTratamientos.Click += new System.EventHandler(this.BtnReporteTratamientos_Click);
            // 
            // SubmenuPaciente
            // 
            this.SubmenuPaciente.Controls.Add(this.panel6);
            this.SubmenuPaciente.Controls.Add(this.BtnCreapaciente);
            this.SubmenuPaciente.Controls.Add(this.panel5);
            this.SubmenuPaciente.Controls.Add(this.BtnBuscaPaciente);
            this.SubmenuPaciente.Location = new System.Drawing.Point(36, 149);
            this.SubmenuPaciente.Name = "SubmenuPaciente";
            this.SubmenuPaciente.Size = new System.Drawing.Size(164, 84);
            this.SubmenuPaciente.TabIndex = 2;
            this.SubmenuPaciente.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(3, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 35);
            this.panel6.TabIndex = 5;
            // 
            // BtnCreapaciente
            // 
            this.BtnCreapaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnCreapaciente.FlatAppearance.BorderSize = 0;
            this.BtnCreapaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnCreapaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreapaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreapaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreapaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreapaciente.Location = new System.Drawing.Point(15, 41);
            this.BtnCreapaciente.Name = "BtnCreapaciente";
            this.BtnCreapaciente.Size = new System.Drawing.Size(149, 35);
            this.BtnCreapaciente.TabIndex = 6;
            this.BtnCreapaciente.Text = "Crear Pacientes";
            this.BtnCreapaciente.UseVisualStyleBackColor = false;
            this.BtnCreapaciente.Click += new System.EventHandler(this.BtnCreapaciente_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 35);
            this.panel5.TabIndex = 3;
            // 
            // BtnBuscaPaciente
            // 
            this.BtnBuscaPaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnBuscaPaciente.FlatAppearance.BorderSize = 0;
            this.BtnBuscaPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnBuscaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscaPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscaPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscaPaciente.Location = new System.Drawing.Point(15, 0);
            this.BtnBuscaPaciente.Name = "BtnBuscaPaciente";
            this.BtnBuscaPaciente.Size = new System.Drawing.Size(149, 35);
            this.BtnBuscaPaciente.TabIndex = 4;
            this.BtnBuscaPaciente.Text = "Busca Pacientes";
            this.BtnBuscaPaciente.UseVisualStyleBackColor = false;
            this.BtnBuscaPaciente.Click += new System.EventHandler(this.BtnBuscaPaciente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Location = new System.Drawing.Point(3, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 50);
            this.panel3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 35);
            this.panel2.TabIndex = 3;
            // 
            // BotonReportes
            // 
            this.BotonReportes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BotonReportes.FlatAppearance.BorderSize = 0;
            this.BotonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BotonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReportes.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonReportes.Image = ((System.Drawing.Image)(resources.GetObject("BotonReportes.Image")));
            this.BotonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonReportes.Location = new System.Drawing.Point(12, 149);
            this.BotonReportes.Name = "BotonReportes";
            this.BotonReportes.Size = new System.Drawing.Size(185, 35);
            this.BotonReportes.TabIndex = 4;
            this.BotonReportes.Text = "Reportes";
            this.BotonReportes.UseVisualStyleBackColor = false;
            this.BotonReportes.Click += new System.EventHandler(this.BotonReportes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 35);
            this.panel1.TabIndex = 2;
            // 
            // BotonPaciente
            // 
            this.BotonPaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BotonPaciente.FlatAppearance.BorderSize = 0;
            this.BotonPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BotonPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonPaciente.Image = ((System.Drawing.Image)(resources.GetObject("BotonPaciente.Image")));
            this.BotonPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonPaciente.Location = new System.Drawing.Point(12, 108);
            this.BotonPaciente.Name = "BotonPaciente";
            this.BotonPaciente.Size = new System.Drawing.Size(185, 35);
            this.BotonPaciente.TabIndex = 2;
            this.BotonPaciente.Text = "Pacientes";
            this.BotonPaciente.UseVisualStyleBackColor = false;
            this.BotonPaciente.Click += new System.EventHandler(this.BotonPaciente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Location = new System.Drawing.Point(200, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(884, 650);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1084, 670);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.Panel_izq);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_izq.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            this.SubmenuPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel Panel_izq;
        private System.Windows.Forms.Button BotonPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonReportes;
        private System.Windows.Forms.Panel SubmenuPaciente;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnCreapaciente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnBuscaPaciente;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnReporteTratamientos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnReportePaciente;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

