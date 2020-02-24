using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ficha_electronica
{
    class ClsEvaluacion
    {
        private Conexion Cn = new Conexion();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Leerfilas;

        public DataTable ListarTto()
        {
            DataTable tabla = new DataTable();
            Cmd.Connection = Cn.AbrirConexion();
            Cmd.CommandText = "ListaTratamientos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Leerfilas = Cmd.ExecuteReader();
            tabla.Load(Leerfilas);
            Leerfilas.Close();
            Cn.CerrarConexion();
            return tabla;
        }

        //creo procedimiento almacenado para guardar la info de las evaluaciones en el form de crear paciente
        public void InsertarDatos( string rut_paciente, DateTime f_ini_tto_dep , string comentario_tto_fac, int n_sesiones, int id_tto)
        {
            Cmd.Connection = Cn.AbrirConexion();
            Cmd.CommandText = "AgregarTratamiento";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@rut_paciente",rut_paciente);
            Cmd.Parameters.AddWithValue("@f_ini_tto_dep", f_ini_tto_dep);
            Cmd.Parameters.AddWithValue("@comentario_tto_fac",comentario_tto_fac );
            Cmd.Parameters.AddWithValue("@n_sesiones",n_sesiones );
            Cmd.Parameters.AddWithValue("@id_tto", id_tto);
            Cmd.ExecuteNonQuery();


        }
    }
}
