using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using colores;

namespace Teira.Agustin.PrimerParcial.Forms
{
    public partial class frmVehiculos : Form
    {
        public Entidades.Vehiculo vehicular;
        public string tipo;

        #region constructores
        public frmVehiculos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga para la modificacion de un objeto y que se carguen sus atributos en el form
        /// </summary>
        /// <param name="v"> vehiculo donde tomara los atributos</param>
        public frmVehiculos(Entidades.Vehiculo v) : this()
        {
            this.txtAño.Text = v.añoFabricacionProperty.ToString();
            this.txtVelMax.Text = v.velMaxProperty.ToString();
            this.txtColor.Text = v.colorProperty.ToString();
        }

        /// <summary>
        /// Sobrecarga para cuando se agrega un objeto y saber el tipo de objeto elegido
        /// </summary>
        /// <param name="frm">form que se abrio anteriormente y define el tipo</param>
        public frmVehiculos(frmElegirTipo frm) : this()
        {
            try
            {
                this.tipo = frm.tipoElegido;
                this.lblTipo.Text = this.tipo.ToUpper();
                this.definirTipoParaLabels(this.tipo);
            }
            catch { }
            
        }

        #endregion

        #region botones
        /// <summary>
        /// //Boton para crear el objeto a partir de los elementos dados por el usuario
        ///Si el usuario se equivoca en el tipo de dato dado, salta un message box 
        ///diciendole que corriga sus errores
        /// </summary>
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                int año = int.Parse(this.txtAño.Text);
                int velocidadMax = int.Parse(this.txtVelMax.Text);
                string color = this.txtColor.Text;
                int atributo1 = int.Parse(this.txtAtributo1.Text);

                string atributo2 = this.txtAtributo2.Text;


                if (this.tipo == "auto")
                {
                    int atributo2Numero = int.Parse(atributo2);
                    this.vehicular = new Entidades.Auto(año, velocidadMax, color, atributo1, atributo2Numero);
                }
                else if (this.tipo == "avion")
                {
                    int atributo2Numero = int.Parse(atributo2);
                    this.vehicular = new Entidades.Avion(año, velocidadMax, color, atributo1, atributo2Numero);
                }
                else if (this.tipo == "tren")
                {
                    this.vehicular = new Entidades.Tren(año, velocidadMax, color, atributo1, atributo2);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores correctos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region funciones para cambiar los labels del form
        private void cambiarLabels(string atributoExtra1, string atributoExtra2, string tipo)
        {
            this.lblAtributo1.Text = atributoExtra1;
            this.lblAtributo2.Text = atributoExtra2;
            this.lblTipo.Text = tipo.ToUpper();
        }

        protected void definirTipoParaLabels(string tipo)
        {
            if (tipo == "auto")
            {
                this.cambiarLabels("Capacidad pasajeros:", "Volumen Tanque:", tipo);
            }
            else if (tipo == "avion")
            {
                cambiarLabels("Capacidad pasajeros:", "Cantidad motores:", tipo);
            }
            else if (tipo == "tren")
            {
                this.cambiarLabels("Cantidad vagones:", "Pais origen:", tipo);
            }
        }

        #endregion
    }
}
