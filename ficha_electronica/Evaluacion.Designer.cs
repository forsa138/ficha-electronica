namespace ficha_electronica
{
    partial class Evaluacion
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
            this.tbox_ses_corp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fch_ini_tto_corp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_com_corp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbx_id_tto = new System.Windows.Forms.TextBox();
            this.txbx_id_eva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_ses_corp
            // 
            this.tbox_ses_corp.Location = new System.Drawing.Point(185, 71);
            this.tbox_ses_corp.Name = "tbox_ses_corp";
            this.tbox_ses_corp.Size = new System.Drawing.Size(33, 20);
            this.tbox_ses_corp.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cantitda de sesiones";
            // 
            // fch_ini_tto_corp
            // 
            this.fch_ini_tto_corp.Location = new System.Drawing.Point(185, 45);
            this.fch_ini_tto_corp.Name = "fch_ini_tto_corp";
            this.fch_ini_tto_corp.Size = new System.Drawing.Size(222, 20);
            this.fch_ini_tto_corp.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha inicio tratamiento";
            // 
            // txbx_com_corp
            // 
            this.txbx_com_corp.Location = new System.Drawing.Point(185, 97);
            this.txbx_com_corp.Multiline = true;
            this.txbx_com_corp.Name = "txbx_com_corp";
            this.txbx_com_corp.Size = new System.Drawing.Size(433, 114);
            this.txbx_com_corp.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ingrese datos del tratamiento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbx_id_tto
            // 
            this.txbx_id_tto.Enabled = false;
            this.txbx_id_tto.Location = new System.Drawing.Point(185, 217);
            this.txbx_id_tto.Name = "txbx_id_tto";
            this.txbx_id_tto.Size = new System.Drawing.Size(85, 20);
            this.txbx_id_tto.TabIndex = 28;
            this.txbx_id_tto.Visible = false;
            // 
            // txbx_id_eva
            // 
            this.txbx_id_eva.Enabled = false;
            this.txbx_id_eva.Location = new System.Drawing.Point(288, 217);
            this.txbx_id_eva.Name = "txbx_id_eva";
            this.txbx_id_eva.Size = new System.Drawing.Size(85, 20);
            this.txbx_id_eva.TabIndex = 29;
            this.txbx_id_eva.Visible = false;
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 271);
            this.Controls.Add(this.txbx_id_eva);
            this.Controls.Add(this.txbx_id_tto);
            this.Controls.Add(this.tbox_ses_corp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fch_ini_tto_corp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbx_com_corp);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluacion";
            this.Text = "Evaluacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbox_ses_corp;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker fch_ini_tto_corp;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txbx_com_corp;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txbx_id_tto;
        public System.Windows.Forms.TextBox txbx_id_eva;
    }
}