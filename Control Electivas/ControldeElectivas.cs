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
    public partial class ControldeElectivas : Form
    {
        private MateriaElectiva Mate;
        private NegocioMaterias NegMate;
        private Usuario usuarioLogueado;

        public ControldeElectivas(Usuario usuario)
        {
            InitializeComponent();
            Mate = new MateriaElectiva();
            NegMate = new NegocioMaterias();
            usuarioLogueado = usuario;
        }
        private void ControldeElectivas_Load(object sender, EventArgs e)
        {
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            CargarMaterias();
            this.Text = $"Control de Electivas - {usuarioLogueado.NombreUsuario.ToUpper()}";
        }
        private void ControldeElectivas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }

        }

        
        #region Funcionalidad de Botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CargarMaterias();
            btnVolver.Visible = false;
            tsmEditar.Enabled = true;
            tsmDardeBaja.Enabled = true;
            tsmAgregar.Visible = true;
            tsmDardeBaja.Visible = true;
            tsmEditar.Visible = true;
            tsmDardeBaja2.Visible = false;
            tsmActualizarFecha.Visible = false;
            lbTitulo.Text = "Materias Electivas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
        }

        private void tsmCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña cambiar = new CambiarContraseña(usuarioLogueado);
            cambiar.ShowDialog();
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            OpenAgregar();
        }

        private void tsmDardeBaja_Click(object sender, EventArgs e)
        {
            DarBaja(true);
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

                MateriaElectiva materia = new MateriaElectiva
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Materias Electivas"].ToString(),
                    NumeroResolucion = row["Resolución de Habilitación"].ToString(),
                    FechaAprobacion = Convert.ToDateTime(row["Fecha de Resolucion Habilitación"]),
                    FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                    Desde = row["Desde"].ToString(),
                    Hasta = row["Hasta"].ToString(),
                    Estado = Convert.ToBoolean(row["Estado"]),
                    IdCarrera = new Carrera
                    {
                        Id = Convert.ToInt32(row["CarreraId"]),
                        Nombre = row["Carrera"].ToString()
                    }
                };

                Editar frmEditar = new Editar(materia);

                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    CargarMaterias();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una materia para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tsmMateriasPorVencer_Click(object sender, EventArgs e)
        {
            DataTable dt = NegMate.ListarMateriasPorVencer(6,2);
            dgvMaterias.DataSource = dt;
            TamañoColumnas(dgvMaterias);

            btnVolver.Visible = true;
            tsmEditar.Enabled = false;
            tsmDardeBaja.Enabled = false;
            tsmAgregar.Visible = true;
            tsmDardeBaja.Visible = true;
            tsmEditar.Visible = true;
            tsmDardeBaja2.Visible = false;
            tsmActualizarFecha.Visible = false;
            lbTitulo.Text = "Materias Electivas Por Vencer";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
        }

        private void tsmMateriasVencidas_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Materias Electivas Vencidas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            dgvMaterias.DataSource = NegMate.ListarMateriasVencidas();
            TamañoColumnas(dgvMaterias);
            btnVolver.Visible = true;
            tsmAgregar.Visible = false;
            tsmDardeBaja.Visible = false;
            tsmEditar.Visible = false;
            tsmDardeBaja2.Visible = true;
            tsmActualizarFecha.Visible = true;
        }

        private void tsmActualizarFecha_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

                MateriaElectiva materia = new MateriaElectiva
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Materias Electivas"].ToString(),
                    NumeroResolucion = row["Resolución de Habilitación"].ToString(),
                    FechaAprobacion = Convert.ToDateTime(row["Fecha de Resolucion Habilitación"]),
                    FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                    Desde = row["Desde"].ToString(),
                    Hasta = row["Hasta"].ToString(),
                    Estado = Convert.ToBoolean(row["Estado"]),
                    IdCarrera = new Carrera
                    {
                        Id = Convert.ToInt32(row["CarreraId"]),
                        Nombre = row["Carrera"].ToString()
                    }
                };

                Actualizar_Fecha actualizar = new Actualizar_Fecha(materia);
                actualizar.FechasActualizadas += () => CargarMateriasVencidas();
                actualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una materia para actualizar la fecha.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmDardeBaja2_Click(object sender, EventArgs e)
        {
            DarBaja(false);
        }

        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }
        #endregion

        // Funciones Globales
        
        #region Funciones
        private void TamañoColumnas(DataGridView dgvMaterias)
        {
            dgvMaterias.Columns["Id"].Visible = false;
            dgvMaterias.Columns["Materias Electivas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Carrera"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["CarreraId"].Visible = false;
            dgvMaterias.Columns["FechaVencimiento"].Visible = false;
            dgvMaterias.Columns["Estado"].Visible = false;
            dgvMaterias.Columns["Desde"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Hasta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void CargarMaterias()
        {
            dgvMaterias.DataSource = NegMate.ListarMaterias();
            TamañoColumnas(dgvMaterias);
        }
        private void DarBaja(bool EsElectiva)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;
                int idMateria = Convert.ToInt32(row["Id"]);

                if (MessageBox.Show("¿Está seguro que desea dar de baja esta materia?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (NegMate.DarDeBaja(idMateria))
                    {
                        MessageBox.Show("Materia dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (EsElectiva)
                            CargarMaterias();
                        else
                            CargarMateriasVencidas();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una materia primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CargarMateriasVencidas()
        {
            lbTitulo.Text = "Materias Electivas Vencidas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            dgvMaterias.DataSource = NegMate.ListarMateriasVencidas();
            TamañoColumnas(dgvMaterias);
        }
        private void OpenAgregar()
        {
            AgregarMateriaForm Agre = new AgregarMateriaForm();

            if (Agre.ShowDialog() == DialogResult.OK)
            {
                CargarMaterias();
            }
        }



        #endregion

        private void tsmFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
