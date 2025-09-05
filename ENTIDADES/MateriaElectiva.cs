using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class MateriaElectiva
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Carrera IdCarrera { get; set; }  
        public string NumeroResolucion { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Desde { get; set; }  
        public string Hasta { get; set; }  
        public bool Estado { get; set; }

        public MateriaElectiva()
        {
            IdCarrera = new Carrera(); 
        }
    }
}
