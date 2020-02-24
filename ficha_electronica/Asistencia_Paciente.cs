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

namespace ficha_electronica
{
    public partial class Asistencia_Paciente : Form
    {
        public Asistencia_Paciente()
        {
            InitializeComponent();
            ListarTratamiento();
            mostrarDatosAsistencia();
        }

        Conexion cn = new Conexion();

        //string rutpcte = tbox_rut_pcte.Text;


        //mostrar datos en el datagridview cuando se crea un nuevo paciente
        public void mostrarDatosAsistencia()
        {

            cn.consulta("select * from Asistencia", "Asistencia");
            dataGridView1.DataSource = cn.ds.Tables["Asistencia"];

            using (SqlConnection con = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True"))
            {

                string rut = "select * from Asistencia WHERE rut_paciente like @rut_paciente + '%'";

                SqlCommand cmnd = new SqlCommand(rut, con);
                cmnd.Parameters.AddWithValue("@rut_paciente", tbox_rut_pcte.Text);
                SqlDataAdapter adap = new SqlDataAdapter(cmnd);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            //


            //SqlConnection cn = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True");
            ////SqlDataReader drd;


            //SqlCommand cmnd = new SqlCommand("select * from Asistencia where (rut_paciente like @rut_paciente", cn);
            //SqlParameter prm = new SqlParameter();
            //prm.ParameterName = "@rut_paciente";
            //cmnd.Parameters["@rut_paciente"].Value = tbox_rut_pcte.Text +"%";
            //dataGridView1.DataSource = cn.DataSource;
            ////prm.Value = tbox_rut_pcte.Text;

            //cmnd.Parameters.Add(prm);
            //drd = cmnd.ExecuteReader();

            //while (drd.Read())
            //{

            //}


            // 



        }


        ClsEvaluacion ObjTto = new ClsEvaluacion();

        //muestra los tratamientos en los combobox
        private void ListarTratamiento()
        {
            ClsEvaluacion ObjTto = new ClsEvaluacion();
            comboBox1.DataSource = ObjTto.ListarTto();
            comboBox1.DisplayMember = "nombre_tto";
            comboBox1.ValueMember = "id_tto";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea salir de Asistencia?", "Salir de Asistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                this.Close();
        }

        //insertar datos de asistencia en tabla asistencia
        private void button1_Click(object sender, EventArgs e)
        {
            ClsAsistencia ca = new ClsAsistencia();
            ca.InsertarAsistencia(
                tbox_rut_pcte.Text,
                dateTimePickerAsist.Value,
                textBox1.Text,
                Convert.ToInt32(comboBox1.SelectedValue),
                textBox2.Text);

            mostrarDatosAsistencia();

        }

        //muestra el rut del paciente seleccionado en formulario buscar paciente en el textbox rut del form asistencia
        // y filtra el datagrid de la asistencia por el rut del paciente seleccionad
        private void tbox_rut_pcte_TextChanged(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True"))
            {

                string rut = "select * from Asistencia WHERE rut_paciente like @rut_paciente + '%'";

                SqlCommand cmnd = new SqlCommand(rut, con);
                cmnd.Parameters.AddWithValue("@rut_paciente", tbox_rut_pcte.Text);
                SqlDataAdapter adap = new SqlDataAdapter(cmnd);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                dataGridView1.DataSource = dt;

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //tbox_rut_pcte.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();



            //if (tbox_rut_pcte.Text != "")
            //{
            //    dataGridView1.CurrentCell = null;
            //    foreach (DataGridViewRow d in dataGridView1.Rows)
            //    {
            //        d.Visible = false;
            //    }
            //    foreach (DataGridViewRow d in dataGridView1.Rows)
            //    {
            //        foreach (DataGridViewCell c in d.Cells)
            //        {

            //            if ((c.Value.ToString().ToUpper()).IndexOf(tbox_rut_pcte.Text.ToUpper()) == 0)
            //            {
            //                d.Visible = true;
            //                break;
            //            }
            //        }

            //    }

            //}


        }

        //private void tbox_rut_pcte_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = new DataView();
        //    dv.RowFilter = string.Format("rut_paciente LIKE  '%{0}%'", tbox_rut_pcte.Text);
        //    dataGridView1.DataSource = dv;
        //}
    }
}
