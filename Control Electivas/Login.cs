using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using ENTIDADES;

namespace Control_Electivas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            Usuario Usu = new Usuario();

            Usu = negocioUsuario.ObtenerUsuario(usuario, clave);

            if (Usu != null)
            {
                OpenControl(Usu);
            }
            else
            {
                MessageBox.Show("❌ Usuario o clave incorrectos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpenControl(Usuario usuario)
        {
            ControldeElectivas control = new ControldeElectivas(usuario);
            control.Show();
            this.Hide();
            control.FormClosed += (s, args) => this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
