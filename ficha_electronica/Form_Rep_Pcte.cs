using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ficha_electronica
{
    public partial class Form_Rep_Pcte : Form
    {
        public Form_Rep_Pcte()
        {
            InitializeComponent();
        }



        private void Form_Rep_Pcte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.fElectronicaDataSet.Paciente);
            // TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Evaluacion' Puede moverla o quitarla según sea necesario.
            this.evaluacionTableAdapter.Fill(this.fElectronicaDataSet.Evaluacion);
            // TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Asistencia' Puede moverla o quitarla según sea necesario.
            this.asistenciaTableAdapter.Fill(this.fElectronicaDataSet.Asistencia);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        //report parameter muestra el rut del parametro creado en el dataset (@RutPaciente) para filtrar el reporte por rut
        private void btbGenerar_Click(object sender, EventArgs e)
        {
            //ReportParameter r = new ReportParameter("RutPaciente", txtbx_rut_pcnte.Text);
            //reportViewer1.LocalReport.SetParameters(r);
            //reportViewer1.RefreshReport();
        }


        private void txtbx_rut_pcnte_TextChanged(object sender, EventArgs e)
        {
            ReportParameter r = new ReportParameter("RutPaciente", txtbx_rut_pcnte.Text);
            reportViewer1.LocalReport.SetParameters(r);
            reportViewer1.RefreshReport();


        }
    }
}
