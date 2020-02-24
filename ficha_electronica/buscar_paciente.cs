using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha_electronica
{
    public partial class buscar_paciente : Form
    {
        public buscar_paciente()
        {
            InitializeComponent();
            mostrarDatos();
        }

        Conexion cn = new Conexion();

        public string operacion = "Modificar";

        //mostrar datos en el datagridview cuando se crea un nuevo paciente
        public void mostrarDatos()
        {
            
            cn.consulta("select * from Paciente", "Paciente");
            dataGridView1.DataSource = cn.ds.Tables["Paciente"];
            
        }

        //buscar paciente y mostrarlo a medida que voy escribiendo
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="" )
            {
               dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow d in dataGridView1.Rows)
                {
                    d.Visible = false;
                }
                foreach (DataGridViewRow d in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell c in d.Cells)
                    {

                        if ((c.Value.ToString().ToUpper()).IndexOf(textBox1.Text.ToUpper()) == 0)
                        {
                            d.Visible = true;
                            break;
                        }
                    }

                }

            }
            else
            {
                mostrarDatos();
            }
             // para mostrar los datos filtrados en el datagridview cse debe cambiar las propiedades de dgrid
             // en el form, en AllowusertoAdd y AllowusertoDelete de true a false


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Asistencia_Paciente ap = new Asistencia_Paciente();
            ap.tbox_rut_pcte.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abre el formulario modificar paciente y muestra los datos de la linea del paciente del datagrid a modificar
            ModPaciente mp = new ModPaciente();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                mp.textBox_rutPcnte.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                mp.textBox_nombrePcte.Text = dataGridView1.CurrentRow.Cells["nombre_completo"].Value.ToString();
                mp.dateTimePicker1_F_nacim.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_nacimiento"].Value.ToString());
                mp.textBox_direccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                mp.textBox_email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                mp.textBox_ocupacion.Text = dataGridView1.CurrentRow.Cells["ocupacion"].Value.ToString();
                mp.textBox_telefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                mp.dateTimePicker2_F_eva.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["f_evaluacion"].Value.ToString());

                mp.Show();


            }
            else
            {
                MessageBox.Show("Seleccione la fila de paciente a modificar");
            }


            //if()
        }

        //refrescar el datagrid con los datos actualizdos
        private void button3_Click(object sender, EventArgs e)
        {
            cn.consulta("select * from Paciente", "Paciente");
            dataGridView1.DataSource = cn.ds.Tables["Paciente"];

        }
    }

}
