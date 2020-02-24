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
using System.Collections;


namespace ficha_electronica
{
    public partial class Reporte_ttos : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Reporte_ttos()
        {
            InitializeComponent();
            //GrafPctexTtos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte_ttos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Evaluacion' Puede moverla o quitarla según sea necesario.
            //this.evaluacionTableAdapter.Fill(this.fElectronicaDataSet.Evaluacion);
            //// TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Tratamiennto' Puede moverla o quitarla según sea necesario.
            //this.tratamienntoTableAdapter.Fill(this.fElectronicaDataSet.Tratamiennto);

            //this.reportViewer1.RefreshReport();

            GrafTtosVendidos();
            GrafSesTtos();
            DashboardDatos();

        }


        ArrayList Nombre_tto = new ArrayList();
        ArrayList QTto = new ArrayList();


        private void GrafTtosVendidos()
        {
            cmd = new SqlCommand("Q_TtosVendidos2", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre_tto.Add(dr.GetString(0));
                QTto.Add(dr.GetInt32(1));

            }

            chart_TtosVendidos.Series[0].Points.DataBindXY(Nombre_tto, QTto);
            dr.Close();
            cn.Close();
        }

        ArrayList SsnTto = new ArrayList();
        ArrayList Cant_ST = new ArrayList();

        private void GrafSesTtos()
        {
            cmd = new SqlCommand("SesionesxTts2", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SsnTto.Add(dr.GetString(0));
                Cant_ST.Add(dr.GetInt32(1));
            }

            chart_S_xTtos.Series[0].Points.DataBindXY(SsnTto, Cant_ST);
            dr.Close();
            cn.Close();
        }

        private void DashboardDatos()
        {

            cmd = new SqlCommand("DASHBOARD_Datos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            //declaracion de parametros de salida
            SqlParameter Qttos = new SqlParameter("@nombre_tto", 0); Qttos.Direction = ParameterDirection.Output;
            SqlParameter Tsesiones = new SqlParameter("@n_sesiones", 0); Tsesiones.Direction = ParameterDirection.Output;
            SqlParameter QEvas = new SqlParameter("@id_tto", 0); QEvas.Direction = ParameterDirection.Output;
            SqlParameter QPcte = new SqlParameter("@rut", 0); QPcte.Direction = ParameterDirection.Output;

            //agregar los parametros anteriores al comando
            cmd.Parameters.Add(Qttos);
            cmd.Parameters.Add(Tsesiones);
            cmd.Parameters.Add(QEvas);
            cmd.Parameters.Add(QPcte);

            //abrir conexion y ejecutar los procedimientos
            cn.Open();
            cmd.ExecuteNonQuery();

            //se agregan los valores de los parametros a los label
            label_Eva.Text = cmd.Parameters["@id_tto"].Value.ToString();
            label_Ses.Text = cmd.Parameters["@n_sesiones"].Value.ToString();
            label_Pcte.Text = cmd.Parameters["@rut"].Value.ToString();
            label_Ttos.Text = cmd.Parameters["@nombre_tto"].Value.ToString(); 

            cn.Close();



        }
    }
}
