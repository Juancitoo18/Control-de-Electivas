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
    public class NegocioMaterias
    {
        private DaoMaterias DaoMateria;
        public NegocioMaterias()
        {
            DaoMateria = new DaoMaterias();
        }
        public DataTable ListarMaterias()
        {
            return DaoMateria.ObtenerMaterias();
        }
        public bool AgregarMateria(MateriaElectiva Materia)
        {
            bool Resultado = false;

            if (Materia.Id == 0) 
            {
                Resultado = DaoMateria.Agregar(Materia);
                return Resultado;
            }

            return Resultado;
        }
        public bool EditarMateria(MateriaElectiva Materia)
        {
            return DaoMateria.Editar(Materia);
        }
        public bool DarDeBaja(int id)
        {
            return DaoMateria.DarDeBaja(id);
        }

        public DataTable ListarMateriasPorVencer(int meses, int años)
        {
            return DaoMateria.ListarMateriasPorVencer(meses, años);
        }

        public DataTable ListarMateriasVencidas()
        {
            return DaoMateria.ListarMateriasVencidas();
        }

        public MateriaElectiva BuscarPorNumeroResolucion(string numeroResolucion)
        {
            return DaoMateria.BuscarPorNumeroResolucion(numeroResolucion);
        }

        public bool ActualizarFechas(MateriaElectiva materia)
        {
            return DaoMateria.ActualizarFechas(materia);
        }
    }
}
