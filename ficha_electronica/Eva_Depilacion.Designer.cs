namespace ficha_electronica
{
    partial class Eva_Depilacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_dep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txbox_zonatratar = new System.Windows.Forms.TextBox();
            this.textBox_Obs_dep = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar zona del cuerpo: ";
            // 
            // comboBox1_dep
            // 
            this.comboBox1_dep.FormattingEnabled = true;
            this.comboBox1_dep.Location = new System.Drawing.Point(209, 60);
            this.comboBox1_dep.Name = "comboBox1_dep";
            this.comboBox1_dep.Size = new System.Drawing.Size(347, 21);
            this.comboBox1_dep.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indicar zona a tratar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observaciones: ";
            // 
            // Txbox_zonatratar
            // 
            this.Txbox_zonatratar.Location = new System.Drawing.Point(209, 90);
            this.Txbox_zonatratar.Multiline = true;
            this.Txbox_zonatratar.Name = "Txbox_zonatratar";
            this.Txbox_zonatratar.Size = new System.Drawing.Size(347, 53);
            this.Txbox_zonatratar.TabIndex = 5;
            // 
            // textBox_Obs_dep
            // 
            this.textBox_Obs_dep.Location = new System.Drawing.Point(209, 162);
            this.textBox_Obs_dep.Multiline = true;
            this.textBox_Obs_dep.Name = "textBox_Obs_dep";
            this.textBox_Obs_dep.Size = new System.Drawing.Size(347, 55);
            this.textBox_Obs_dep.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha inicio tratamiento";
            // 
            // Eva_Depilacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 271);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Obs_dep);
            this.Controls.Add(this.Txbox_zonatratar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1_dep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eva_Depilacion";
            this.Text = "Eva_Depilacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_dep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txbox_zonatratar;
        private System.Windows.Forms.TextBox textBox_Obs_dep;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
    }
}