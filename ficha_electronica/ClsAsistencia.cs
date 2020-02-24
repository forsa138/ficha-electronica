using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ficha_electronica
{
    class ClsAsistencia
    {
        private Conexion Cn = new Conexion();
        private SqlCommand Cmd = new SqlCommand();


        public void InsertarAsistencia(string rut_paciente, DateTime f_asistencia, string profesional, int id_tto, string observaciones)
        {
            Cmd.Connection = Cn.AbrirConexion();
            Cmd.CommandText = "AgregarAsistencia";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@rut_paciente", rut_paciente);
            Cmd.Parameters.AddWithValue("@f_asistencia",f_asistencia );
            Cmd.Parameters.AddWithValue("@profesional", profesional );
            Cmd.Parameters.AddWithValue("@id_tto",id_tto );
            Cmd.Parameters.AddWithValue("@observaciones",observaciones );
            Cmd.ExecuteNonQuery();


        }

    }
}
