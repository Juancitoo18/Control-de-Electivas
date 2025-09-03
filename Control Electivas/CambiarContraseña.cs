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
    public partial class CambiarContraseña : Form
    {
        private NegocioUsuario Neg;
        private Usuario usuarioLogueado;
        public CambiarContraseña(Usuario usuario)
        {
            InitializeComponent();
            Neg = new NegocioUsuario();
            usuarioLogueado = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string Actual = txtContraseñaActual.Text;
            string Nueva = txtContraseñaNueva.Text;
            string Confirmar = txtConfirmar.Text;
            int IdUsuario = usuarioLogueado.IdUsuario;

            if (usuarioLogueado.ContraseñaUsuario != Actual)
            {
                MessageBox.Show("Contraseña Actual Incorrecta!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseñaActual.Text = "";
                txtContraseñaNueva.Text = "";
                txtConfirmar.Text = "";
            }
            else if (Nueva != Confirmar)
            {
                MessageBox.Show("Las contraseñas no son iguales", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseñaNueva.Text = "";
                txtConfirmar.Text = "";
            }
            else
            {
                if (Neg.CambiarContraseña(IdUsuario,Nueva))
                {
                    MessageBox.Show("Cambio Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al dar cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
