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
    public partial class Cuadro_dialogo1 : Form
    {
        public Cuadro_dialogo1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asistencia_Paciente AsPcte = new Asistencia_Paciente();
            AsPcte.Show();
            this.Close();
            ActiveForm.Close();
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
