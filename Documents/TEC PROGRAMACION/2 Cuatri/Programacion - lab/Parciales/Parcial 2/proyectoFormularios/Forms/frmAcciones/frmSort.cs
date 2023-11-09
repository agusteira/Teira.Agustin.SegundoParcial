using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Proyecto_de_forms.Forms.frmAcciones
{
    public partial class frmSort : Form
    {
        public string ordenamiento;

        /// <summary>
        ///Constructor del form, inicializa sus componentes 
        /// </summary>
        public frmSort(Contenedora contenedora)
        {
            InitializeComponent();
        }


        /// <summary>
        /// si se aprieta este boton, se cambia el atributo ordenaminento a año
        /// </summary>
        private void btnAño_Click(object sender, EventArgs e)
        {
            this.ApretarBoton("año");
        }

        /// <summary>
        /// si se aprieta este boton, se cambia el atributo ordenaminento a velocidad
        /// </summary>
        private void btnVelocidad_Click(object sender, EventArgs e)
        {
            this.ApretarBoton("velocidad");
        }

        /// <summary>
        /// si se aprieta este boton, se cambia el atributo segun el parametro dado
        /// y ademas cierra el form
        /// </summary>
        /// <param name="texto">Es el parametro que va a cambiar el atributo ordenamiento</param>
        private void ApretarBoton(string texto)
        {
            DialogResult = DialogResult.OK;
            this.ordenamiento = texto;
            this.Close();
        }

        
    }
}
