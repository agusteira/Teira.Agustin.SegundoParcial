using login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teira.Agustin.PrimerParcial.Forms
{
    public partial class Login : Form
    {
        public Usuario usuario = new Usuario();

        /// <summary>
        /// Constructor del form del login
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si se aprieta el boton de login, se comparara el correo y la contraseña
        /// dada con los usuarios del json, y si todo esta okey, se sigue al crud
        /// y si no coincide, salta una advertencia
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            usuario = (Usuario.Verificar(this.txtMail.Text, txtPassword.Text));

            if (usuario != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en usuario y/o clave!!!", "CREDENCIALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Se cancela la ejecucion del programa
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
