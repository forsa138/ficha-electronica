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
    public partial class Crear_paciente : Form
    {
        public Crear_paciente()
        {
            InitializeComponent();

            cn.conectar();
            ListarTratamiento();
       
        }

        Conexion cn = new Conexion();
        ClsEvaluacion ObjTto = new ClsEvaluacion();

        // listar los tratamientos en el combobox
        private void ListarTratamiento()
        {
            ClsEvaluacion ObjTto = new ClsEvaluacion();
            comboBox1.DataSource = ObjTto.ListarTto();
            comboBox1.DisplayMember = "nombre_tto";
            comboBox1.ValueMember = "id_tto";

        }


        //Acoplar formulario a Panel Contenedor del inicio
        private void AbrirFormfacial(object formFacial)
        {
            if (this.Panel_tto.Controls.Count > 0)
                this.Panel_tto.Controls.RemoveAt(0);
            Form ff = formFacial as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.Panel_tto.Controls.Add(ff);
            this.Panel_tto.Tag = ff;
            ff.Show();

        }

        private void BtnFacial_Click(object sender, EventArgs e)
        {
            AbrirFormfacial(new Eva_Facial());
        }

        private void AbrirFormcorp(object formCorp)
        {
            if (this.Panel_tto.Controls.Count > 0)
                this.Panel_tto.Controls.RemoveAt(0);
            Form fc = formCorp as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.Panel_tto.Controls.Add(fc);
            this.Panel_tto.Tag = fc;
            fc.Show();

        }

        private void BtnCorporal_Click(object sender, EventArgs e)
        {
            AbrirFormcorp(new Eva_corporal());
        }

        private void AbrirFormdep(object formDep)
        {
            if (this.Panel_tto.Controls.Count > 0)
                this.Panel_tto.Controls.RemoveAt(0);
            Form fd = formDep as Form;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;
            this.Panel_tto.Controls.Add(fd);
            this.Panel_tto.Tag = fd;
            fd.Show();

        }

        private void Btn_Depilacion_Click(object sender, EventArgs e)
        {
            AbrirFormdep(new Eva_Depilacion());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void AbrirFormAspcte(object formAspcte)
        {
            if (this.PanelDPersonales.Controls.Count > 0)
                this.PanelDPersonales.Controls.RemoveAt(0);
            Form fasp = formAspcte as Form;
            fasp.TopLevel = false;
            fasp.Dock = DockStyle.Fill;
            this.PanelDPersonales.Controls.Add(fasp);
            this.PanelDPersonales.Tag = fasp;
            fasp.Show();
        }


        // guarda os datos del paciente 
        public void button1_Click(object sender, EventArgs e)
        {
            //muestra los pacientes creados en el datagridview del form buscar paciente
            buscar_paciente bpaciente = new buscar_paciente();

            

            string guardar ="insert into Paciente values('"+textBox2.Text+"','"+textBox1.Text+"','"+dateTimePicker1.Value+"','"+textBox4.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox5.Text+ "','" + dateTimePicker2.Value + "')";
            if (cn.insertar(guardar))
            {
                MessageBox.Show("datos guardados");
                bpaciente.mostrarDatos();


                this.Hide();

            }
            
            else
            {
                MessageBox.Show("error al guardar");
            }

            Convert.ToInt32(comboBox1.SelectedValue);


            ClsEvaluacion EvTto = new ClsEvaluacion();
            EvTto.InsertarDatos(
                textBox2.Text,
                fch_ini_tto_corp.Value, 
                txbx_com_corp.Text,
                Convert.ToInt32(tbox_ses_corp.Text),
                Convert.ToInt32(comboBox1.SelectedValue)
                );


            //Evaluacion ev = new Evaluacion();
            //string guardar_c = "insert into values('" +ev.txbx_id_eva.Text + "','"+textBox2.Text+"','"+ev.fch_ini_tto_corp.Value+"','"+ev.txbx_com_corp.Text+"','"+Convert.ToInt32(ev.tbox_ses_corp.Text)+"','"+ev.txbx_id_tto+"')";
            
            //string guarda_C="insert into Corporal values('"+cn.cl+"')";


            ////resultado de dialogo, dar OK cierra formulario, cancelar lo mantiene
            //DialogResult res = MessageBox.Show("¿Desea guardar los cambios?","Informacion Paciente", MessageBoxButtons.OKCancel);
            //if (res == DialogResult.OK)
            //    this.Close();



        }

        private void BtnIrAsistencia_Click(object sender, EventArgs e)
        {
            //DialogResult res = MessageBox.Show("¿Desea guardar los cambios?", "Informacion Paciente", MessageBoxButtons.OKCancel);
            //if (res == DialogResult.OK) 
            //    this.Close();

            //    Asistencia_Paciente AsPcte = new Asistencia_Paciente();
            //    AsPcte.Show();
            //    AsPcte.ShowInTaskbar = false;

            //if (res == DialogResult.Cancel)
            // //   AsPcte.Close();
            //    FindForm();


            //AbrirFormAspcte(new Asistencia_Paciente());


        }

        private void AbrirFormEva(object formEva)
        {
            if (this.PanelDPersonales.Controls.Count > 0)
                this.PanelDPersonales.Controls.RemoveAt(0);
            Form feva = formEva as Form;
            feva.TopLevel = false;
            feva.Dock = DockStyle.Fill;
            this.PanelDPersonales.Controls.Add(feva);
            this.PanelDPersonales.Tag = feva;
            feva.Show();
        }

        private void Panel_tto_Paint(object sender, PaintEventArgs e)
        {
            //AbrirFormEva(new Evaluacion());
        }

        private void Crear_paciente_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'fElectronicaDataSet.Tratamiennto' Puede moverla o quitarla según sea necesario.
            //this.tratamienntoTableAdapter.Fill(this.fElectronicaDataSet.Tratamiennto);

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (comboBox1.Text)
        //    {
        //        case "Tratamiento Corporal":
        //            AbrirFormcorp(new Eva_corporal());
        //            break;
        //        case "Tratamiento Facial":
        //            AbrirFormfacial(new Eva_Facial());
        //            break;
        //        case "Depilacion":
        //            AbrirFormdep(new Eva_Depilacion());
        //            break;
        //    }

        //}
    }
}
