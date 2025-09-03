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

        private void CargarMaterias()
        {
            dgvMaterias.DataSource = NegMate.ListarMaterias();
            dgvMaterias.Columns["Id"].Visible = false;
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Carrera"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["CarreraId"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenAgregar();
        }

        private void OpenAgregar()
        {
            AgregarMateriaForm Agre = new AgregarMateriaForm();

            if (Agre.ShowDialog() == DialogResult.OK)
            {
                CargarMaterias(); 
            }
        }

        private void ControldeElectivas_Load(object sender, EventArgs e)
        {
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            CargarMaterias();
            lblUsuario.Text = $"Usuario: {usuarioLogueado.NombreUsuario.ToUpper()}";
        }

        private void ControldeElectivas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

                MateriaElectiva materia = new MateriaElectiva
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    NumeroResolucion = row["NumeroResolucion"].ToString(),
                    FechaAprobacion = Convert.ToDateTime(row["FechaAprobacion"]),
                    FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                    Estado = true,
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

        private void btnBaja_Click(object sender, EventArgs e)
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
                        CargarMaterias();
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

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            DataTable dt = NegMate.ListarMateriasPorVencer(12);
            dgvMaterias.DataSource = dt;
            dgvMaterias.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Carrera"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            btnAgregar.Visible = false;
            btnBaja.Visible = false;
            btnEditar.Visible = false;
            btnVencimientos.Visible = false;
            btnVolver.Visible = true;
            btnMateriasVencidas.Visible = true;
            lblkCambiar.Visible = false;
            lbTitulo.Text = "Materias Electivas Por Vencer";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CargarMaterias();
            btnAgregar.Visible = true;
            btnBaja.Visible = true;
            btnEditar.Visible = true;
            btnVencimientos.Visible = true;
            btnVolver.Visible = false;
            btnMateriasVencidas.Visible = false;
            btnBaja2.Visible = false;
            btnActualizarFecha.Visible = false;
            lblkCambiar.Visible = true;
            lbTitulo.Text = "Materias Electivas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
        }

        private void btnMateriasVencidas_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Materias Electivas Vencidas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            dgvMaterias.DataSource = NegMate.ListarMateriasVencidas();
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Carrera"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnMateriasVencidas.Visible = false;
            btnActualizarFecha.Visible = true;
            btnBaja2.Visible = true;
            lblkCambiar.Visible = false;
        }

        public void CargarMateriasVencidas()
        {
            lbTitulo.Text = "Materias Electivas Vencidas";
            lbTitulo.Left = (this.ClientSize.Width - lbTitulo.Width) / 2;
            dgvMaterias.DataSource = NegMate.ListarMateriasVencidas();
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMaterias.Columns["Carrera"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnMateriasVencidas.Visible = false;
            btnActualizarFecha.Visible = true;
            btnBaja2.Visible = true;
            
        }

        private void lblkCambiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContraseña cambiar = new CambiarContraseña(usuarioLogueado);
            cambiar.ShowDialog();
        }

        private void btnActualizarFecha_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvMaterias.CurrentRow.DataBoundItem;

                MateriaElectiva materia = new MateriaElectiva
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    NumeroResolucion = row["NumeroResolucion"].ToString(),
                    FechaAprobacion = Convert.ToDateTime(row["FechaAprobacion"]),
                    FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                    Estado = true,
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

        private void btnBaja2_Click(object sender, EventArgs e)
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
    }
}
