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
using System.Data.Sql;



namespace ficha_electronica
{
    public partial class ModPaciente : Form
    {
        public ModPaciente()
        {
            InitializeComponent();
        }

        //Conexion cn = new Conexion();
        SqlConnection cn = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True");

        //buscar_paciente bp = new buscar_paciente();

        //string Operacion = "Modificar";

        private void ModPaciente_Load(object sender, EventArgs e)
        {
            //if(bp.dataGridView1.SelectedRows.Count > 0)
            //{
            //    bp.operacion = "Modificar";
            //    textBox_nombrePcte.Text = bp.dataGridView1.CurrentRow.Cells["nombre_completo"].Value.ToString();
            //    //dateTimePicker1_F_nacim.Value = bp.dataGridView1.CurrentRow.Cells[3];
            //    textBox_direccion.Text = bp.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            //    textBox_email.Text = bp.dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            //    textBox_ocupacion.Text = bp.dataGridView1.CurrentRow.Cells["ocupacion"].Value.ToString();
            //    textBox_telefono.Text = bp.dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            //    //dateTimePicker2_F_eva.Value = bp.dataGridView1.CurrentRow.Cells["7"];


            //}


        }

        void Modificar()
        {
            //Conexion cn = new Conexion();
            //SqlCommand comm = new SqlCommand("update Paciente set rut='" + textBox_rutPcnte.Text + "',nombre_completo = '" + textBox_nombrePcte.Text + "', fecha_nacimiento = " + dateTimePicker1_F_nacim.Value + ", direccion = '" + textBox_direccion.Text + "', email = '" + textBox_email.Text + "', ocupacion = '" + textBox_ocupacion.Text + "', telefono = '" + textBox_telefono.Text + "', f_evaluacion = " + dateTimePicker2_F_eva.Value + ", where rut = ' + textBox_rutPcnte.Text + '", cn);
            //comm.Connection.Open();
            //comm.ExecuteNonQuery();
            //MessageBox.Show("Modificacion Exitosa");
            //cn.Close();
        }

        public void mostrarDatosBP()
        {
            
            buscar_paciente bp = new buscar_paciente();
            Conexion cn = new Conexion();
            cn.consulta("select * from Paciente", "Paciente");
            bp.dataGridView1.DataSource = cn.ds.Tables["Paciente"];

        }


        private void BtnCancelMod_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea cancelar la modificación?", "Información Paciente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                this.Close();

        }

        private void BtnGuardarMod_Click(object sender, EventArgs e)
        {
            //public void ModPacientes(string rut, string nombre_completo, string direccion, string email, string ocupacion,
            //    string telefono, DateTime f_nacimiento, DateTime f_evaluacion)
            //{
            //    Cmd.Connection = Cn.AbrirConexion();
            //    Cmd.CommandText = "update Paciente set nombre_completo='" + nombre_completo + "', fecha_nacimiento=" + f_nacimiento + ",direccion='" + direccion + "', email='" + email + "', ocupacion='" + ocupacion + "', telefono='" + telefono + "', f_evaluacion=" + f_evaluacion + ", where rut='"+rut+"'";
            //    Cmd.CommandType = CommandType.Text;
            //    Cmd.ExecuteNonQuery();
            //    Cn.AbrirConexion();
            //buscar_paciente bp = new buscar_paciente();
            //string actualizar = "nombre_completo = '" + textBox_nombrePcte.Text + "', fecha_nacimiento = " + dateTimePicker1_F_nacim.Value + ", direccion = '" + textBox_direccion.Text + "', email = '" + textBox_email.Text + "', ocupacion = '" + textBox_ocupacion.Text + "', telefono = '" + textBox_telefono.Text + "', f_evaluacion = " + dateTimePicker2_F_eva.Value + "";
            //if (cn.modificar("Paciente", actualizar, "rut=" + textBox_rutPcnte.Text))
            //{
            //    MessageBox.Show("datos guardados");
            //    bp.mostrarDatos();

            //    Limpia_txtbox limpiar = new Limpia_txtbox();
            //    limpiar.LimpiarCampos(this);

            //}

            //else
            //{
            //    MessageBox.Show("error al guardar");
            //}

            //Modificar();

            Pacientes pct = new Pacientes();
            pct.ModificarPcte(
                textBox_rutPcnte.Text,
                textBox_nombrePcte.Text,
                Convert.ToString(dateTimePicker1_F_nacim.Value),
                textBox_direccion.Text,
                textBox_email.Text,
                textBox_ocupacion.Text,
                textBox_telefono.Text,
                Convert.ToString(dateTimePicker2_F_eva.Value)
                );

            MessageBox.Show("Modificación exitosa");
            
            mostrarDatosBP();
            Close();

        }
    }
}
