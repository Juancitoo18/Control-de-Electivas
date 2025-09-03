using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class AccesoDatos
    {
        public AccesoDatos() { }

        string rutaBDSucursales = "Data Source=localhost\\sqlexpress; Initial Catalog=dbElectivas; Integrated Security=True";

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;

            }
            catch (Exception)
            {
                return null;
            }
        }
        private SqlDataAdapter ObtenerAdaptador(string consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int EjecutarEscalar(SqlCommand comando)
        {
            comando.Connection = ObtenerConexion();
            return Convert.ToInt32(comando.ExecuteScalar());
        }
        public DataTable ObtenerTabla(string NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }
        public DataTable obtenerTablaId(string consulta)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }

        public int EjectuarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int filasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            filasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return filasCambiadas;
        }

        public int EjecutarSQL(SqlCommand comando)
        {
            int filasAfectadas = 0;
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    filasAfectadas = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SQL: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
            return filasAfectadas;
        }

        public Boolean existe(String Consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(Consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;

            }
            return estado;
        }
        public DataTable ConsultaTabla(SqlCommand comando, string nombreTabla)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = ObtenerConexion())
            {
                if (conexion == null)
                    throw new Exception("No se pudo abrir la conexión a la base de datos.");

                comando.Connection = conexion;   
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(dt);
            }
            return dt;
        }
    }
}
