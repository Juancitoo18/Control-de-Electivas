using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DAO
{
    public class DaoCarrera
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable ObtenerCarreras()
        {
            string consulta = "SELECT Id, Nombre FROM Carreras";
            return ds.ObtenerTabla("Carreras", consulta);
        }
    }
}
