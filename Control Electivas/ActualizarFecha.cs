using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace Control_Electivas
{
    public partial class Actualizar_Fecha : Form
    {
        private MateriaElectiva materiaSeleccionada;
        private int idMateria;
        private NegocioMaterias negocio;
        public event Action FechasActualizadas;

        public Actualizar_Fecha(MateriaElectiva materia)
        {
            InitializeComponent();
            materiaSeleccionada = materia;
            idMateria = materia.Id;
            negocio = new NegocioMaterias();
            lblMateria.Text = materiaSeleccionada.Nombre;
            lblMateria.Left = (this.ClientSize.Width - lblMateria.Width) / 2;
            dtpFechaInicio.Value = materiaSeleccionada.FechaAprobacion;
            dtpFechaVencimiento.Value = materiaSeleccionada.FechaVencimiento;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DateTime fechaAprobacion = dtpFechaInicio.Value;
            DateTime fechaVencimiento = dtpFechaVencimiento.Value;
            
            MateriaElectiva materia = new MateriaElectiva
            {
                Id = idMateria,
                FechaAprobacion = fechaAprobacion,
                FechaVencimiento = fechaVencimiento,
                Desde = fechaAprobacion.Year.ToString(),
                Hasta = fechaVencimiento.Year.ToString()
            };

            
            bool actualizado = negocio.ActualizarFechas(materia);

            if (actualizado)
            {
                MessageBox.Show("Fechas actualizadas correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FechasActualizadas?.Invoke(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar las fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        

