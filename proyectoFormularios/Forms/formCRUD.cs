using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_de_forms.Forms.frmAcciones;
using login;

namespace Teira.Agustin.PrimerParcial.Forms
{
    public partial class formCRUD : Form
    {
        Entidades.Contenedora<Vehiculo> contenedora = new Entidades.Contenedora<Vehiculo>();
        Usuario usuario = new Usuario();

        /// <summary>
        /// Constructor de inicializacion del form del crud
        /// </summary>
        /// <param name="user">El tipo de usuario que se logueo</param>
        public formCRUD(Usuario user)
        {
            InitializeComponent();

            contenedora.vehiculosProperty = Contenedora<Vehiculo>.Deserializacion("");

            //Suscripcion a eventos
            this.contenedora.VehiculoAgregado += new VehiculoSubidoEventHandler(Advertencias.VehiculoNuevo);
            this.contenedora.VehiculoNoAgregado += new VehiculoSubidoEventHandler(Advertencias.VehiculoRepetido);
            this.contenedora.VehiculoModificado += new VehiculoSubidoEventHandler(Advertencias.VehiculoModificado);
            this.contenedora.VehiculoEliminado += new VehiculoSubidoEventHandler(Advertencias.VehiculoEliminado);


            DateTime thisDay = DateTime.Today;
            this.txtFecha.Text = thisDay.ToString("d");
            this.usuario = user;
            this.txtUsuario.Text = this.usuario.ToString();

            this.DefinirPerfiles();
            this.ActualizarVisor();
        }

        #region instrucciones botones

        /// <summary>
        /// Te crea un formulario en el que vas a poder agregar un nuevo objeto a la lista
        ///y esa lista despues se va a mostrar en el listBox
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmElegirTipo frmElegirTipo = new frmElegirTipo();
            frmElegirTipo.ShowDialog();

            frmVehiculos frmVehiculos = new frmVehiculos(frmElegirTipo);
            frmVehiculos.ShowDialog();
            if (frmVehiculos.DialogResult == DialogResult.OK)
            {
                this.contenedora.Agregar(frmVehiculos.vehicular);
                this.ActualizarVisor();
            }
        }


        /// <summary>
        ///Agarra el objeto seleccionado de la listBox, y crea un nuevo formulario
        ///que va a modificar el objeto que se selecciono, y el form ya tiene todos
        ///sus atributos
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.boxObjetcts.SelectedIndex;
            frmVehiculos frm = null;

            if (indice == -1)
            {
                return;
            }

            if (this.contenedora.vehiculosProperty[indice] is Auto)
            {
                frm = new frmAutos((Auto)this.contenedora.vehiculosProperty[indice]);
            }
            else if (this.contenedora.vehiculosProperty[indice] is Avion)
            {
                frm = new frmAviones((Avion)this.contenedora.vehiculosProperty[indice]);
            }
            else if (this.contenedora.vehiculosProperty[indice] is Tren)
            {
                frm = new frmTrenes((Tren)this.contenedora.vehiculosProperty[indice]);
            }

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                //si se presiono aceptar
                this.contenedora.Modificar(frm.vehicular, indice);
                //Actualiza el listbox
                this.ActualizarVisor();
            }

        }

        /// <summary>
        ///Elimina el objeto seleccionado en el boxObjects de la lista contenedora
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.boxObjetcts.SelectedIndex;

            if (indice == -1)
            {
                return;
            }
            this.contenedora.eliminar(indice);
            this.ActualizarVisor();
        }

        /// <summary>
        /// Cuando se esta por cerrar el form te tira una advertencia
        /// </summary>
        private void FormCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                // Cancelar el cierre del formulario si el usuario selecciona "No"
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Te salta un form para que selecciones por que atributo queres ordenar
        /// y despues iniciliza el metodo de ordenamiento elegido de forma descendente
        /// </summary>
        private void btnOrdenamientoDescendente_Click(object sender, EventArgs e)
        {
            frmSort frm = new frmSort(contenedora);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.OrdenamientoDescendente(frm);
            }
            this.ActualizarVisor();
        }

        /// <summary>
        /// Te salta un form para que selecciones por que atributo queres ordenar
        /// y despues iniciliza el metodo de ordenamiento elegido de forma ascendente
        /// </summary>
        private void btnOrdenamientoAscendente_Click(object sender, EventArgs e)
        {
            frmSort frm = new frmSort(contenedora);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.OrdenamientoAscendente(frm);
            }
            this.ActualizarVisor();
        }

        /// <summary>
        /// Enciende el vehiculo seleccionado
        /// </summary>
        private void btnEncender_Click(object sender, EventArgs e)
        {
            int indice = this.boxObjetcts.SelectedIndex;

            if (indice == -1)
            {
                return;
            }
            string estado = this.contenedora.vehiculosProperty[indice].Encender();
            MessageBox.Show(estado);
            this.ActualizarVisor();

        }

        /// <summary>
        /// te permite elegir de donde serializar los objetos
        /// </summary>
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ubicación y el nombre del archivo seleccionado por el usuario.
                string rutaElegida = openFileDialog.FileName;
                contenedora.vehiculosProperty = Contenedora<Vehiculo>.Deserializacion(rutaElegida);
                this.ActualizarVisor();
            }
        }
        /// <summary>
        /// te permite elegir de donde deserializar los objetos
        /// </summary>
        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ubicación y el nombre del archivo seleccionado por el usuario.
                string rutaElegida = saveFileDialog.FileName;
                Contenedora<Vehiculo>.Serializacion(this.contenedora.vehiculosProperty, rutaElegida);
            }
        }

        /// <summary>
        /// Te lleva al form de visualizador de los logins
        /// </summary>
        private void btnVisualidorLogins_Click(object sender, EventArgs e)
        {
            visualizadorLogins vl = new visualizadorLogins();
            vl.Show();
        }


        #endregion

        #region metodos

        /// <summary>
        /// Mediante el atributo de un form, elige si ordena una lista por 
        /// año o por vel max, y luego aplica el metodo de la clase contenedora
        /// para realizar el ordenamietno de forma descendente
        /// </summary>
        ///  <param name="frm">Es el formulario que elige que atributo va a ordenar</param>
        private void OrdenamientoAscendente(frmSort frm)
        {
            if (frm.ordenamiento == "año")
            {
                contenedora.vehiculosProperty.Sort(Contenedora<Vehiculo>.OrdenarAscedentePorAño);
            }
            else if (frm.ordenamiento == "velocidad")
            {
                contenedora.vehiculosProperty.Sort(Contenedora<Vehiculo>.OrdenarAscedenteVelMax);
            }
        }

        /// <summary>
        /// Mediante el atributo de un form, elige si ordena una lista por 
        /// año o por vel max, y luego aplica el metodo de la clase contenedora
        /// para realizar el ordenamiento de forma descendente
        /// </summary>
        ///  <param name="frm">Es el formulario que elige que atributo va a ordenar</param>
        private void OrdenamientoDescendente(frmSort frm)
        {
            if (frm.ordenamiento == "año")
            {
                contenedora.vehiculosProperty.Sort(Contenedora<Vehiculo>.OrdenarDescendentePorAño);
            }
            else if (frm.ordenamiento == "velocidad")
            {
                contenedora.vehiculosProperty.Sort(Contenedora<Vehiculo>.OrdenarDescendenteVelMax);
            }
        }

        /// <summary>
        ///A partir de la lista vehiculos, recorre la lista
        ///y muestra su string en la list box, y ademas serializa la lista en un json
        /// </summary>
        private void ActualizarVisor()
        {
            this.boxObjetcts.Items.Clear();
            foreach (Vehiculo v in this.contenedora.vehiculosProperty)
            {
                boxObjetcts.Items.Add(v.ToString());
            }

            try
            {
                Contenedora<Vehiculo>.Serializacion(this.contenedora.vehiculosProperty, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron guardar los datos correctamente debido a {ex}");
            }
        }

        /// <summary>
        /// Define que tipo de perfil es, y dependiendo que 
        /// perfil es el usuario, va a poder utilizar los botones
        /// del CRUD, o no
        /// </summary>
        private void DefinirPerfiles()
        {
            /*
            if (this.usuario.Perfil == "vendedor")
            {
                this.btnAgregar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
            else if (this.usuario.Perfil == "supervisor")
            {
                this.btnEliminar.Enabled = false;
            }
            */
        }

        #endregion

    }
}