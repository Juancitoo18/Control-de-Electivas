using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAO;
using System.Data;

namespace NEGOCIO
{
    public class NegocioUsuario
    {
        private DaoUsuario DaoUsuario;
        public NegocioUsuario()
        {
            DaoUsuario = new DaoUsuario();
        }

        public bool ValidarUsuario(string nombreUsuario, string clave)
        {
            return DaoUsuario.ValidarUsuario(nombreUsuario,clave);
        }
        public Usuario ObtenerUsuario(string nombreUsuario, string clave)
        {
            return DaoUsuario.ObtenerUsuario(nombreUsuario, clave);
        }
        public bool CambiarContraseña(int IdUsuario, string Nueva)
        {
            return DaoUsuario.CambiarContraseña(IdUsuario,Nueva);
        }
    }
}
