namespace ficha_electronica
{
    partial class Eva_corporal
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
            this.txbx_com_corp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fch_ini_tto_corp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_ses_corp = new System.Windows.Forms.TextBox();
            this.tbox_idtto = new System.Windows.Forms.TextBox();
            this.tbox_id_corp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbx_com_corp
            // 
            this.txbx_com_corp.Location = new System.Drawing.Point(138, 133);
            this.txbx_com_corp.Multiline = true;
            this.txbx_com_corp.Name = "txbx_com_corp";
            this.txbx_com_corp.Size = new System.Drawing.Size(433, 114);
            this.txbx_com_corp.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(436, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ingrese datos relacionados con Evaluación Corporal (Edad, Tall, Peso, IMC, % Gras" +
    "a total, \r\n% Grasa viceral, % Musculatura, etc)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha inicio tratamiento";
            // 
            // fch_ini_tto_corp
            // 
            this.fch_ini_tto_corp.Location = new System.Drawing.Point(271, 20);
            this.fch_ini_tto_corp.Name = "fch_ini_tto_corp";
            this.fch_ini_tto_corp.Size = new System.Drawing.Size(222, 20);
            this.fch_ini_tto_corp.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantitda de sesiones";
            // 
            // tbox_ses_corp
            // 
            this.tbox_ses_corp.Location = new System.Drawing.Point(271, 49);
            this.tbox_ses_corp.Name = "tbox_ses_corp";
            this.tbox_ses_corp.Size = new System.Drawing.Size(33, 20);
            this.tbox_ses_corp.TabIndex = 21;
            // 
            // tbox_idtto
            // 
            this.tbox_idtto.Location = new System.Drawing.Point(606, 19);
            this.tbox_idtto.Name = "tbox_idtto";
            this.tbox_idtto.Size = new System.Drawing.Size(63, 20);
            this.tbox_idtto.TabIndex = 22;
            this.tbox_idtto.Visible = false;
            // 
            // tbox_id_corp
            // 
            this.tbox_id_corp.Enabled = false;
            this.tbox_id_corp.Location = new System.Drawing.Point(606, 45);
            this.tbox_id_corp.Name = "tbox_id_corp";
            this.tbox_id_corp.Size = new System.Drawing.Size(63, 20);
            this.tbox_id_corp.TabIndex = 23;
            this.tbox_id_corp.Visible = false;
            // 
            // Eva_corporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 271);
            this.Controls.Add(this.tbox_id_corp);
            this.Controls.Add(this.tbox_idtto);
            this.Controls.Add(this.tbox_ses_corp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fch_ini_tto_corp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbx_com_corp);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eva_corporal";
            this.Text = "Eva_corporal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker fch_ini_tto_corp;
        public System.Windows.Forms.TextBox tbox_ses_corp;
        public System.Windows.Forms.TextBox txbx_com_corp;
        public System.Windows.Forms.TextBox tbox_idtto;
        public System.Windows.Forms.TextBox tbox_id_corp;
    }
}