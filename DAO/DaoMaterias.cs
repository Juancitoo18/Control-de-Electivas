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
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],   
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1";
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
                return filas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ArmarParametrosMateriaAgregar(ref SqlCommand comando, MateriaElectiva materia)
        {
            comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = materia.Nombre;
            comando.Parameters.Add("@CarreraId", SqlDbType.Int).Value = materia.IdCarrera.Id;
            comando.Parameters.Add("@NumeroResolucion", SqlDbType.NVarChar, 50).Value = materia.NumeroResolucion;
            comando.Parameters.Add("@FechaAprobacion", SqlDbType.Date).Value = materia.FechaAprobacion;
            comando.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = materia.FechaVencimiento;
            comando.Parameters.Add("@Desde", SqlDbType.NVarChar, 50).Value = materia.Desde;
            comando.Parameters.Add("@Hasta", SqlDbType.NVarChar, 50).Value = materia.Hasta;
            comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = materia.Estado;
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
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = materia.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = materia.Nombre;
            comando.Parameters.Add("@CarreraId", SqlDbType.Int).Value = materia.IdCarrera.Id;
            comando.Parameters.Add("@NumeroResolucion", SqlDbType.NVarChar, 50).Value = materia.NumeroResolucion;
            comando.Parameters.Add("@FechaAprobacion", SqlDbType.Date).Value = materia.FechaAprobacion;
            comando.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = materia.FechaVencimiento;
            comando.Parameters.Add("@Desde", SqlDbType.NVarChar, 50).Value = materia.Desde;
            comando.Parameters.Add("@Hasta", SqlDbType.NVarChar, 50).Value = materia.Hasta;
            comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = materia.Estado;
        }

        public bool DarDeBaja(int id)
        {
            string consulta = "UPDATE MateriasElectivas SET Estado = 0 WHERE Id = @Id AND Estado = 1";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Id", id);
            return ds.EjecutarSQL(comando) > 0;
        }

        public DataTable ListarMateriasPorVencer(int meses, int Años)
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],   
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1 AND m.FechaVencimiento > DATEADD(MONTH, @Meses, GETDATE()) AND m.FechaVencimiento < DATEADD(YEAR, @Años, GETDATE());";

            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Meses", meses);
            comando.Parameters.AddWithValue("@Años", Años);

            return ds.ConsultaTabla(comando, "MateriasPorVencer");
        }

        public DataTable ListarMateriasVencidas()
        {
            string consulta = @"SELECT m.Id, 
                                   c.Nombre AS Carrera,                               
                                   m.Nombre AS [Materias Electivas],   
                                   m.CarreraId,
                                   m.NumeroResolucion AS [Resolución de Habilitación], 
                                   m.FechaAprobacion AS [Fecha de Resolucion Habilitación], 
                                   m.FechaVencimiento,
                                   m.Desde,
                                   m.Hasta,
                                   m.Estado
                            FROM MateriasElectivas m 
                            INNER JOIN Carreras c ON c.Id = m.CarreraId 
                            WHERE m.Estado = 1 AND m.FechaVencimiento < GETDATE();";

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
