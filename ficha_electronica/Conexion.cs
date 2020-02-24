using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace ficha_electronica
{
    class Conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=WINMAC-PC; Initial Catalog=FElectronica; Integrated Security=True");

        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;

        public void conectar()
        {
            try
            {
                cn.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("error de conexion");

            }
            finally
            {
                cn.Close();
            }

        }

        //
        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            return cn;
        }
        //

        public void consulta(string sql,string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public bool insertar (string sql)
        {
            cn.Open();
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool modificar(string tabla, string campos,string condicion)
        {
            cn.Open();
            string modificar = " update " + tabla + " set " + campos + " where " + condicion;
            SqlCommand cmd = new SqlCommand(modificar, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
