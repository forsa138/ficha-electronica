using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace ficha_electronica
{
    public partial class Reporte_pacientes : Form
    {
        public Reporte_pacientes()
        {
            InitializeComponent();
            mostrarDatos();
        }

        Conexion cn = new Conexion();

        public void mostrarDatos()
        {
            cn.consulta("select * from Paciente", "Paciente");
            dataGridView1.DataSource = cn.ds.Tables["Paciente"];

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Rep_Pcte rp = new Form_Rep_Pcte();
            rp.txtbx_rut_pcnte.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rp.Show();
            this.Hide();

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
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


        }
    }
}
