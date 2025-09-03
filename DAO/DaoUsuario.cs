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
    public class DaoUsuario
    {
        AccesoDatos ds = new AccesoDatos();
        public bool ValidarUsuario(string nombreUsuario, string clave)
        {
            string consulta = "SELECT COUNT(*) FROM Usuarios WHERE nombre_usuario = @usuario AND contraseña_usuario = @clave";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@usuario", nombreUsuario);
            comando.Parameters.AddWithValue("@clave", clave);
            return ds.EjecutarEscalar(comando) > 0;
        }

        public Usuario ObtenerUsuario(string nombreUsuario, string clave)
        {
            Usuario usuario = null;

            string consulta = "SELECT *  FROM Usuarios WHERE nombre_usuario = @usuario AND contraseña_usuario = @clave";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@usuario", nombreUsuario);
            comando.Parameters.AddWithValue("@clave", clave);

            DataTable tabla = ds.ConsultaTabla(comando, "Usuarios");

            if (tabla.Rows.Count > 0)
            {
                DataRow row = tabla.Rows[0];
                usuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"]),
                    NombreUsuario = row["nombre_usuario"].ToString(),
                    ContraseñaUsuario = row["contraseña_usuario"].ToString()
                };
            }

            return usuario;
        }

        public bool CambiarContraseña(int IdUsuario, string Nueva)
        {
            string consulta = "UPDATE Usuarios SET contraseña_usuario = @Nueva WHERE id_usuario = @Id AND Estado = 1";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Id", IdUsuario);
            comando.Parameters.AddWithValue("@Nueva", Nueva);
            return ds.EjecutarSQL(comando) > 0;
        }
    }
}
