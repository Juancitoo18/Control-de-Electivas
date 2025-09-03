using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DAO
{
    public class DaoMaterias
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable ObtenerMaterias()
        {
            string consulta = "SELECT m.Id, m.Nombre, c.Nombre as Carrera,  m.CarreraId ,m.NumeroResolucion, m.FechaAprobacion, m.FechaVencimiento FROM MateriasElectivas m INNER JOIN Carreras c on c.Id = m.CarreraId WHERE m.Estado = 1";
            return ds.obtenerTablaId(consulta);
        }
        public bool Agregar(MateriaElectiva materia)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "sp_AgregarMateriaElectiva";

                ArmarParametrosMateriaAgregar(ref comando, materia);

                int filas = ds.EjectuarProcedimientoAlmacenado(comando, "sp_AgregarMateriaElectiva");
                if (filas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ArmarParametrosMateriaAgregar(ref SqlCommand comando, MateriaElectiva materia)
        {
            SqlParameter SqlParametros;
            SqlParametros = comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100);
            SqlParametros.Value = materia.Nombre;
            SqlParametros = comando.Parameters.Add("@CarreraId", SqlDbType.Int);
            SqlParametros.Value = materia.IdCarrera.Id;
            SqlParametros = comando.Parameters.Add("@NumeroResolucion", SqlDbType.NVarChar, 50);
            SqlParametros.Value = materia.NumeroResolucion;
            SqlParametros = comando.Parameters.Add("@FechaAprobacion", SqlDbType.Date);
            SqlParametros.Value = materia.FechaAprobacion;
            SqlParametros = comando.Parameters.Add("@FechaVencimiento", SqlDbType.Date);
            SqlParametros.Value = materia.FechaVencimiento;
            SqlParametros = comando.Parameters.Add("@Estado", SqlDbType.Bit);
            SqlParametros.Value = materia.Estado;
        }

        public MateriaElectiva BuscarPorNumeroResolucion(string numeroResolucion)
        {
            string consulta = "SELECT TOP 1 m.Id, m.Nombre, c.Nombre AS Carrera, m.NumeroResolucion FROM MateriasElectivas m INNER JOIN Carreras c ON c.Id = m.CarreraId WHERE m.NumeroResolucion = @NumeroResolucion";

            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@NumeroResolucion", numeroResolucion);

            DataTable dt = ds.ConsultaTabla(comando, "MateriaResolucion");

            if (dt.Rows.Count > 0)
            {
                return new MateriaElectiva
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Nombre = dt.Rows[0]["Nombre"].ToString(),
                    NumeroResolucion = dt.Rows[0]["NumeroResolucion"].ToString()
                };
            }

            return null; // No existe
        }

        public bool Editar(MateriaElectiva materia)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spEditarMateria";
                ArmarParametrosMateriaEditar(ref comando, materia);
                int filas = ds.EjectuarProcedimientoAlmacenado(comando, "spEditarMateria");
                return filas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ArmarParametrosMateriaEditar(ref SqlCommand comando, MateriaElectiva materia)
        {
            SqlParameter SqlParametros;
            SqlParametros = comando.Parameters.Add("@Id", SqlDbType.Int);
            SqlParametros.Value = materia.Id;
            SqlParametros = comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100);
            SqlParametros.Value = materia.Nombre;
            SqlParametros = comando.Parameters.Add("@CarreraId", SqlDbType.Int);
            SqlParametros.Value = materia.IdCarrera.Id;
            SqlParametros = comando.Parameters.Add("@NumeroResolucion", SqlDbType.NVarChar, 50);
            SqlParametros.Value = materia.NumeroResolucion;
            SqlParametros = comando.Parameters.Add("@FechaAprobacion", SqlDbType.Date);
            SqlParametros.Value = materia.FechaAprobacion;
            SqlParametros = comando.Parameters.Add("@FechaVencimiento", SqlDbType.Date);
            SqlParametros.Value = materia.FechaVencimiento;
            SqlParametros = comando.Parameters.Add("@Estado", SqlDbType.Bit);
            SqlParametros.Value = materia.Estado;
        }

        public bool DarDeBaja(int id)
        {
            string consulta = "UPDATE MateriasElectivas SET Estado = 0 WHERE Id = @Id AND Estado = 1";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Id", id);
            return ds.EjecutarSQL(comando) > 0;
        }

        public DataTable ListarMateriasPorVencer(int meses)
        {
            string consulta = "SELECT m.Id, m.Nombre, c.Nombre AS Carrera, m.CarreraId, m.NumeroResolucion,m.FechaAprobacion, m.FechaVencimiento FROM MateriasElectivas m INNER JOIN Carreras c ON c.Id = m.CarreraId WHERE m.Estado = 1 AND m.FechaVencimiento BETWEEN GETDATE() AND DATEADD(MONTH, @Meses, GETDATE());";

            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Meses", meses);

            return ds.ConsultaTabla(comando, "MateriasPorVencer");
        }

        public DataTable ListarMateriasVencidas()
        {
            string consulta = "SELECT m.Id, m.Nombre, c.Nombre AS Carrera, m.CarreraId, m.NumeroResolucion, m.FechaAprobacion, m.FechaVencimiento FROM MateriasElectivas m INNER JOIN Carreras c ON c.Id = m.CarreraId WHERE m.Estado = 1 AND m.FechaVencimiento < GETDATE();";

            SqlCommand comando = new SqlCommand(consulta);
            return ds.ConsultaTabla(comando, "MateriasVencidas");
        }

        public bool ActualizarFechas(MateriaElectiva materia)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE MateriasElectivas SET FechaAprobacion = @FechaAprobacion, FechaVencimiento = @FechaVencimiento WHERE Id = @Id";

                comando.Parameters.AddWithValue("@FechaAprobacion", materia.FechaAprobacion);
                comando.Parameters.AddWithValue("@FechaVencimiento", materia.FechaVencimiento);
                comando.Parameters.AddWithValue("@Id", materia.Id);

                return ds.EjecutarSQL(comando) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
