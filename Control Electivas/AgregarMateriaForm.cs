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
    public partial class AgregarMateriaForm : Form
    {
        private MateriaElectiva Mate;
        private NegocioMaterias NegMate;
        private NegocioCarrera NegCarre;
        public AgregarMateriaForm()
        {
            InitializeComponent();
            Mate = new MateriaElectiva();
            NegMate = new NegocioMaterias();
            NegCarre = new NegocioCarrera();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MateriaElectiva existente = NegMate.BuscarPorNumeroResolucion(txtResolucion.Text);

            if (existente != null && existente.Id != Mate.Id)
            {
                MessageBox.Show($"No se puede agregar porque el número de resolución ya está cargado en la materia: {existente.Nombre}",
                                "Duplicado detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool Resultado = NegMate.AgregarMateria(CargarMateria(Mate));
            if (Resultado)
            {
                MessageBox.Show("Se agregó con éxito");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en la carga");
                this.DialogResult = DialogResult.None;
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AgregarMateriaForm_Load(object sender, EventArgs e)
        {
            DataTable dt = NegCarre.ListarCarreras();

            DataRow fila = dt.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cmbCarrera.DataSource = dt;
            cmbCarrera.DisplayMember = "Nombre";
            cmbCarrera.ValueMember = "Id";
            cmbCarrera.SelectedIndex = 0;

            dtpVencimiento.Value = DateTime.Now.AddYears(4);
            dtpAprobacion.Value = DateTime.Now;
        }

        private void AgregarMateriaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None) 
            {
                Application.Exit(); 
            }
        }

        private MateriaElectiva CargarMateria(MateriaElectiva Mate)
        {
            Mate.Nombre = txtNombre.Text;
            if (Mate.IdCarrera == null)
                Mate.IdCarrera = new Carrera();
            Mate.IdCarrera.Id = (int)cmbCarrera.SelectedValue;
            Mate.NumeroResolucion = txtResolucion.Text;
            Mate.FechaAprobacion = dtpAprobacion.Value;
            Mate.FechaVencimiento = dtpVencimiento.Value;
            Mate.Estado = true;

            return Mate;
        }
    }
}
