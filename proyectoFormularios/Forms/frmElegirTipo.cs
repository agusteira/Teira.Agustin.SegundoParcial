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
    public partial class frmElegirTipo : Form
    {
        public string tipoElegido;

        /// <summary>
        /// Inicializa los componenetes del form
        /// </summary>
        public frmElegirTipo()
        {
            InitializeComponent();
        }

        #region botones
        /// <summary>
        /// si se aprieta este boton, se cambia el atributo tipo a auto
        /// </summary>
        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.Tipo("auto");
        }

        /// <summary>
        /// si se aprieta este boton, se cambia el atributo tipo a avion
        /// </summary>
        private void btnAvion_Click(object sender, EventArgs e)
        {
            this.Tipo("avion");
        }

        /// <summary>
        /// si se aprieta este boton, se cambia el atributo tipo a tren
        /// </summary>
        private void btnTren_Click(object sender, EventArgs e)
        {
            this.Tipo("tren");
        }

        /// <summary>
        /// cambia el atributo tipo, y cierra el form
        /// </summary>
        /// <param name="tipo"> el string tipo elegido que se va a cambiar</param>
        private void Tipo(string tipo)
        {
            this.tipoElegido = tipo;
            this.Close();
        }
        #endregion
    }
}
