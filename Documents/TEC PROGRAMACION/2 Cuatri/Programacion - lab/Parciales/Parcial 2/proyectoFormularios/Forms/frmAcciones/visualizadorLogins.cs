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

namespace Proyecto_de_forms.Forms.frmAcciones
{
    public partial class visualizadorLogins : Form
    {
        /// <summary>
        /// Constructor que te carga el archivo donde
        /// se guardan todos los logueos a la aplicacion
        /// y te los agrega a un list box para visualirzarlos
        /// </summary>
        public visualizadorLogins()
        {
            InitializeComponent();
            string[] logLines = Usuario.Registro();

            foreach (string line in logLines)
            {
                lstLogins.Items.Add(line);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
