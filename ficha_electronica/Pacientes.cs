using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ficha_electronica
{
    public class Pacientes
    {
        public string Rut { get; set; }
        public string Nombre_completo { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Ocupacion { get; set; }
        public string Telefono { get; set; }
        public string F_evaluacion { get; set; }

        public Pacientes() { }

        public Pacientes(string pRut, string pNombre_completo, string pFecha_nacimiento, string pDireccion, string pEmail, string pOcupacion,
            string pTelefono, string pF_evaluacion)
        {
            this.Rut = pRut;
            this.Nombre_completo = pNombre_completo;
            this.Fecha_nacimiento = pFecha_nacimiento;
            this.Direccion = pDireccion;
            this.Email = pEmail;
            this.Ocupacion = pOcupacion;
            this.Telefono = pTelefono;
            this.F_evaluacion = pF_evaluacion;

        }



        private Conexion Cn = new Conexion();
        private SqlCommand Cmd = new SqlCommand();

        public void ModificarPcte(string rut, string nombre_completo, string fecha_nacimiento, string direccion, string email, string ocupacion,
            string telefono, string f_evaluacion)
        {
            Cmd.Connection = Cn.AbrirConexion();
            Cmd.CommandText = "sp_Modificar";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@rut", rut);
            Cmd.Parameters.AddWithValue("@nombre_completo",nombre_completo );
            Cmd.Parameters.AddWithValue("@fecha_nacimiento",fecha_nacimiento );
            Cmd.Parameters.AddWithValue("@direccion",direccion );
            Cmd.Parameters.AddWithValue("@email", email);
            Cmd.Parameters.AddWithValue("@ocupacion",ocupacion );
            Cmd.Parameters.AddWithValue("@telefono", telefono);
            Cmd.Parameters.AddWithValue("@f_evaluacion", f_evaluacion );


            Cmd.ExecuteNonQuery();


        }

        public void EditarPcte(string rut, string nombre_completo, string fecha_nacimiento, string direccion, string email, string ocupacion,
            string telefono, string f_evaluacion)
        {

        }

    }
}
