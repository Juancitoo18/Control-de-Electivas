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
    public class NegocioCarrera
    {
        DaoCarrera dao = new DaoCarrera();

        public DataTable ListarCarreras()
        {
            return dao.ObtenerCarreras();
        }
    }
}
