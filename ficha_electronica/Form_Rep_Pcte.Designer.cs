namespace ficha_electronica
{
    partial class Form_Rep_Pcte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.asistenciaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fElectronicaDataSet = new ficha_electronica.FElectronicaDataSet();
            this.evaluacionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asistenciaTableAdapter = new ficha_electronica.FElectronicaDataSetTableAdapters.AsistenciaTableAdapter();
            this.evaluacionTableAdapter = new ficha_electronica.FElectronicaDataSetTableAdapters.EvaluacionTableAdapter();
            this.pacienteTableAdapter = new ficha_electronica.FElectronicaDataSetTableAdapters.PacienteTableAdapter();
            this.txtbx_rut_pcnte = new System.Windows.Forms.TextBox();
            this.btbGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fElectronicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // asistenciaBindingSource3
            // 
            this.asistenciaBindingSource3.DataMember = "Asistencia";
            this.asistenciaBindingSource3.DataSource = this.fElectronicaDataSet;
            // 
            // fElectronicaDataSet
            // 
            this.fElectronicaDataSet.DataSetName = "FElectronicaDataSet";
            this.fElectronicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluacionBindingSource2
            // 
            this.evaluacionBindingSource2.DataMember = "Evaluacion";
            this.evaluacionBindingSource2.DataSource = this.fElectronicaDataSet;
            // 
            // pacienteBindingSource2
            // 
            this.pacienteBindingSource2.DataMember = "Paciente";
            this.pacienteBindingSource2.DataSource = this.fElectronicaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            reportDataSource4.Name = "DataSet_Asistencia";
            reportDataSource4.Value = this.asistenciaBindingSource3;
            reportDataSource5.Name = "DataSet_Evaluacion";
            reportDataSource5.Value = this.evaluacionBindingSource2;
            reportDataSource6.Name = "DataSet_Paciente";
            reportDataSource6.Value = this.pacienteBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ficha_electronica.ReportePaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(790, 405);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // evaluacionTableAdapter
            // 
            this.evaluacionTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtbx_rut_pcnte
            // 
            this.txtbx_rut_pcnte.Location = new System.Drawing.Point(13, 7);
            this.txtbx_rut_pcnte.Name = "txtbx_rut_pcnte";
            this.txtbx_rut_pcnte.Size = new System.Drawing.Size(100, 20);
            this.txtbx_rut_pcnte.TabIndex = 1;
            this.txtbx_rut_pcnte.Visible = false;
            this.txtbx_rut_pcnte.TextChanged += new System.EventHandler(this.txtbx_rut_pcnte_TextChanged);
            // 
            // btbGenerar
            // 
            this.btbGenerar.Location = new System.Drawing.Point(119, 5);
            this.btbGenerar.Name = "btbGenerar";
            this.btbGenerar.Size = new System.Drawing.Size(84, 23);
            this.btbGenerar.TabIndex = 2;
            this.btbGenerar.Text = "Generar";
            this.btbGenerar.UseVisualStyleBackColor = true;
            this.btbGenerar.Visible = false;
            this.btbGenerar.Click += new System.EventHandler(this.btbGenerar_Click);
            // 
            // Form_Rep_Pcte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btbGenerar);
            this.Controls.Add(this.txtbx_rut_pcnte);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Rep_Pcte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Paciente";
            this.Load += new System.EventHandler(this.Form_Rep_Pcte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fElectronicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FElectronicaDataSet fElectronicaDataSet;
        private System.Windows.Forms.BindingSource asistenciaBindingSource3;
        private FElectronicaDataSetTableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
        private System.Windows.Forms.BindingSource evaluacionBindingSource2;
        private FElectronicaDataSetTableAdapters.EvaluacionTableAdapter evaluacionTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource2;
        private FElectronicaDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Button btbGenerar;
        public System.Windows.Forms.TextBox txtbx_rut_pcnte;
    }
}