using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ficha_electronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea salir del sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
                Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Acoplar formulario a Panel Contenedor del inicio
        private void AbrirFormhijo(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        //Darle movilidad a la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void BotonPaciente_Click(object sender, EventArgs e)
        {
            SubmenuPaciente.Visible = true;
            SubmenuReportes.Visible = false;
          
        }

        private void BtnBuscaPaciente_Click(object sender, EventArgs e)
        {
            SubmenuPaciente.Visible = false;
            AbrirFormhijo(new buscar_paciente());

        }

        private void BtnCreapaciente_Click(object sender, EventArgs e)
        {
            SubmenuPaciente.Visible = false;
            AbrirFormhijo(new Crear_paciente());
            
        }

        private void BotonReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
            SubmenuPaciente.Visible = false;
        }

        private void BtnReportePaciente_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormhijo(new Reporte_pacientes());
        }

        private void BtnReporteTratamientos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormhijo(new Reporte_ttos());
        }

        private void AsistenciaPaciente(object sender, EventArgs e)
        {
            AbrirFormhijo(new Asistencia_Paciente());

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Cuadro_dialogo1 cd = new Cuadro_dialogo1();
            cd.Show();
        }
    }
    }




    

